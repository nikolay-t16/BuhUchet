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
    private ModelClothes modelClothes;
    private String[,] rubsList;
    public FormClothesList()
    {
      InitializeComponent();
      modelClothes = new ModelClothes();
      SetRubs();
    }
    public void SetRubs() {
      comboBoxParent.Items.Clear();
      rubsList = modelClothes.GetRubs();
      for (int i = 0; i < rubsList.Length/2; i++) {
        if (rubsList[i, 1] != "") {
          comboBoxParent.Items.Add(rubsList[i, 1]);
        }
      }
      comboBoxParent.SelectedIndex = 0;
        
      /*
      if (reader != null)
      {
        while (reader.Read())//а здесь собственно записи полей
        {
          MessageBox.Show(reader["name"].ToString());
          comboBoxParent.Items.Add(reader["name"].ToString());         
        }
      }*/
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      formClothesEdit = new FormClothesEdit();
      formClothesEdit.Show();
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
      dataGridViewClothesSearch.Rows.Clear();
      OleDbDataReader reader = modelClothes.Search(textBoxSearch.Text, rubsList[comboBoxParent.SelectedIndex, 0]);
      if (reader != null)
      {
        while (reader.Read())//а здесь собственно записи полей
        {
          int rowNumber = dataGridViewClothesSearch.Rows.Add();
          dataGridViewClothesSearch.Rows[rowNumber].Cells["id"].Value = reader["id"].ToString();
          dataGridViewClothesSearch.Rows[rowNumber].Cells["parent"].Value = reader["p_id"].ToString();
          dataGridViewClothesSearch.Rows[rowNumber].Cells["name"].Value = reader["name"].ToString();
        }
      }
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

          modelClothes.DeleteByIdSet(delet_id_str);
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
        formClothesEdit = new FormClothesEdit();
        Int16 id = 0;
        Int16.TryParse(dataGridViewClothesSearch.SelectedRows[0].Cells[0].Value.ToString(), out id);
        formClothesEdit.setId(id);
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
        
  }
}
