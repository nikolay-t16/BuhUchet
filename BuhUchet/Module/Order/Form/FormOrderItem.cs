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
using System.Globalization;

namespace BuhUchet
{
  public partial class FormOrderItem : Form
  {
    protected FormOrder fParent;
    String itemId;
    private Dictionary<string, ChildItem> childList = new Dictionary<string, ChildItem>();
    public FormOrderItem(String itemId, FormOrder fParent)
    {
      InitializeComponent();
      this.itemId = itemId;
      this.fParent = fParent;
      
    }

    public void FormOrderItem_Load(object sender, EventArgs e)
    {
      String id_child ="0";
      if (itemId != "0") 
      {

        OleDbDataReader item = ModelOrder.I().GetById(itemId);
        if (item != null) 
        {
          item.Read();
          id_child = item["id_child"].ToString();
          DateTime date = DateTime.ParseExact(item["date"].ToString(), "dd'.'MM'.'yyyy h:mm:ss", CultureInfo.InvariantCulture);
          dateTimePicker.Value = date;
          LoadItems(itemId);
        }
      }
      LoadChildList(id_child);
    }
    public void LoadItems(String idOrder) {
      dataGridView.Rows.Clear();
      OleDbDataReader items = ModelOrderItems.I().GetItems("id_order = " + idOrder + " order by id ASC");
      if (items != null)
      {
        
        int rowNumber;
        while (items.Read())
        {
          string group_name = "";
          if (items["id_clothes"].ToString() != "0")
          {
            foreach (var clothesRub in ModelClothes.I().ClothesTree) {
              if ( clothesRub.Value.ContainsKey( items["id_clothes"].ToString() ) ) {

                group_name =" / " + clothesRub.Value[items["id_clothes"].ToString()].Name;
                group_name = ModelClothes.I().ClothesTree["0"][clothesRub.Value[items["id_clothes"].ToString()].PId].Name + group_name; 
              }    
            }
          }
          rowNumber = dataGridView.Rows.Add();
          dataGridView.Rows[rowNumber].Cells["id"].Value = items["id"].ToString();
          dataGridView.Rows[rowNumber].Cells["clothes"].Value = group_name;
          dataGridView.Rows[rowNumber].Cells["count"].Value = items["count"].ToString();
        }
      }
    }
    protected void LoadChildList(String idChild) {
      comboBoxChild.Items.Clear();
      childList.Clear();
      childList = ModelChildren.I().GetChildList();
      if (childList.Count > 0)
      {
        
        int i = 0;
        foreach (var it in childList)
        {
          comboBoxChild.Items.Add(it.Value.Fio);
          if (idChild == it.Value.Id) 
          {
            comboBoxChild.SelectedIndex = i;
          }
          i++;
        }
        if (comboBoxChild.SelectedIndex < 0)
        {
          comboBoxChild.SelectedIndex = 0;
        }
        
      }
      
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (dataGridView.SelectedRows.Count == 1)
      {
        Int16 id = 0;
        Int16.TryParse(dataGridView.SelectedRows[0].Cells["id"].Value.ToString(), out id);
        FormOrderItemEdit f = new FormOrderItemEdit(id,itemId, this);
        f.Show();
      }
      else
      {
        if (dataGridView.SelectedRows.Count > 1)
        {
          MessageBox.Show("Выберите только одну запись");
        }
        else
        {
          MessageBox.Show("Выберите одну запись");
        }
      }
      
    }

    private void buttonDel_Click(object sender, EventArgs e)
    {
      if (dataGridView.SelectedRows.Count > 0)
      {
        var resault = MessageBox.Show(
      "Вы уверенны что хотите удалить выбранные строки?",
      "Подтверждение удаления",
      MessageBoxButtons.YesNo
      );
        if (resault == DialogResult.Yes)
        {
          {
            for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
            {
              ModelOrderItems.I().DeleteById(dataGridView.SelectedRows[i].Cells[0].Value.ToString());
            }

          }
          LoadItems(itemId);

        }
      }
      else
      {
        MessageBox.Show("Выберите одну запись");
      }
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      if (itemId == "0")
      {


        if (ModelOrder.I().Insert(dateTimePicker.Value.Date.ToString(), childList.ElementAt(comboBoxChild.SelectedIndex).Key))
        {
          itemId = ModelOrder.I().GetLustId().ToString();
          MessageBox.Show("Накладная успешно добавлена");
        }
        else
        {
          MessageBox.Show("Произошла ошибка, попробуйте еще раз или обратитесь к админестратору");
        }
      }
      else
      {
        if (ModelOrder.I().Update(itemId, dateTimePicker.Value.Date.ToString(), childList.ElementAt(comboBoxChild.SelectedIndex).Key))
        {
          MessageBox.Show("Накладная успешно изменена");
        }
        else
        {
          MessageBox.Show("Произошла ошибка, попробуйте еще раз или обратитесь к админестратору");
        }
      }
      fParent.LoadItems();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      FormOrderItemEdit f = new FormOrderItemEdit(0, itemId,this);
      f.Show();
    }
  }
}
