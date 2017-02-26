using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuhUchet
{
  public partial class FormClothesList : Form
  {
    private FormClothesEdit formClothesEdit;
    private List<ClothesTreeItem> rubList = new List<ClothesTreeItem>();
    public FormClothesList()
    {
      InitializeComponent();
      SetRubs();
    }
    public void SetRubs() {
      comboBoxParent.Items.Clear();
      rubList.Clear();
      rubList.Add(new ClothesTreeItem() { Id = "0",Name = "Пусто"});
      comboBoxParent.Items.Add("Пусто");
      foreach (var rubsList in ModelClothes.I().ClothesTree["0"]) {
        comboBoxParent.Items.Add(rubsList.Value.Name);
        rubList.Add(rubsList.Value);
      }
      comboBoxParent.SelectedIndex = 0;
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      formClothesEdit = new FormClothesEdit(this,0);
      formClothesEdit.Show();
    }
    public void Search() {
      dataGridViewClothesSearch.Rows.Clear();
      if (rubList.Count < comboBoxParent.SelectedIndex) {
        Console.WriteLine("Неправильный индекс рубрики");
        return;
      }

      var clothesList = ModelClothes.I().Search(textBoxSearch.Text, rubList[comboBoxParent.SelectedIndex].Id.ToString());
      if (clothesList.Count==0)
        return;
      for (var i = 0; i < clothesList.Count; i++) {
        dataGridViewClothesSearch.Rows.Add();
        dataGridViewClothesSearch.Rows[i].Cells["id"].Value = clothesList[i].Id;
        dataGridViewClothesSearch.Rows[i].Cells["parent"].Value = clothesList[i].ParentName;
        dataGridViewClothesSearch.Rows[i].Cells["name"].Value = clothesList[i].Name;
      }        
      
    }
    private void buttonSearch_Click(object sender, EventArgs e)
    {
      Search();
 
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
      Int32 selectedRowCount = dataGridViewClothesSearch.SelectedRows.Count;

      if (selectedRowCount > 0)
      {
        var resault = MessageBox.Show(
              "Вы уверенны что хотите удалить выбранные строки?",
              "Подтверждение удаления",
              MessageBoxButtons.YesNo
              );
        if (resault == DialogResult.Yes)
        {
          String delet_id_str = GetIdSetFromSelectedRows();

          ModelClothes.I().DeleteByIdSet(delet_id_str);
          buttonSearch.PerformClick();
        }
      }
      else
      {
        MessageBox.Show("Выберите хотя бы одну строку");
      }
    }

    private String GetIdSetFromSelectedRows()
    {
      String set = "";
      for (int i = 0; i < dataGridViewClothesSearch.SelectedRows.Count; i++)
      {
        if (set == "")
        {
          set += dataGridViewClothesSearch.SelectedRows[i].Cells[0].Value.ToString();
        }
        else
        {
          set += "," + dataGridViewClothesSearch.SelectedRows[i].Cells[0].Value.ToString();
        }
      }
      return set;
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
      if (dataGridViewClothesSearch.SelectedRows.Count == 1)
      {
        
        Int16 id = 0;
        Int16.TryParse(dataGridViewClothesSearch.SelectedRows[0].Cells[0].Value.ToString(), out id);
        formClothesEdit = new FormClothesEdit(this, id);
        formClothesEdit.SetDefaultFieldValues();
        formClothesEdit.Show();
      }
      else
      {
        if (dataGridViewClothesSearch.SelectedRows.Count > 1)
        {
          MessageBox.Show("Выберите только одну запись");
        }
        else
        {
          MessageBox.Show("Выберите одну запись");
        }
      }
    }

    private void FormClothesList_Load(object sender, EventArgs e)
    {
      Search();
    }

    private void dataGridViewClothesSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
        
  }
}
