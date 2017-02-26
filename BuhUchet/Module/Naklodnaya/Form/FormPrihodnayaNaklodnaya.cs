using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuhUchet
{
  public partial class FormPrihodnayaNaklodnaya : Form
  {
    private int itemId;
    private FormPrihodnayaNaklodnayaSpisok formPrihodnayaNaklodnayaSpisok;
    public FormPrihodnayaNaklodnaya(int itemId, FormPrihodnayaNaklodnayaSpisok form_parent)
    {
      formPrihodnayaNaklodnayaSpisok = form_parent;
      InitializeComponent();
      this.itemId = itemId;
      if (this.itemId!=0) {
        LoadValues();
      }      
    }
    public void LoadValues() {

      dataGridViewList.Rows.Clear();
      var item = ModelPrihodnayaNaklodnaya.I().GetItem(itemId);
      if (item != null)
      {

        textBoxNomer.Text = item.Nomer;
        DateTime date = DateTime.ParseExact(item.DateAdd, "dd'.'MM'.'yyyy h:mm:ss", CultureInfo.InvariantCulture);
        dateTimePickerCreateDate.Value = date;
        var items = ModelPrihodnayaNakladnayaIt.I().GetItems(this.itemId.ToString());
        if (items != null) 
        {
          foreach (var it in items.Values) { 
            var rowNumber = dataGridViewList.Rows.Add();
            dataGridViewList.Rows[rowNumber].Cells["id"].Value = it.Id;
            dataGridViewList.Rows[rowNumber].Cells["id_clothes"].Value = it.IdClothes;
            dataGridViewList.Rows[rowNumber].Cells["group_name"].Value = it.GroupName;
            dataGridViewList.Rows[rowNumber].Cells["name"].Value = it.Name;
            dataGridViewList.Rows[rowNumber].Cells["count"].Value = it.Count;
            dataGridViewList.Rows[rowNumber].Cells["price"].Value = it.Price;            
          }
        }
        //ModelPrihodnayaNaklodnayaIt.I().GetById(item_id.ToString());
      }
    }
    private void button1_Click(object sender, EventArgs e)
    {
      if (textBoxNomer.Text!="")
      {
      if (itemId == 0) 
      {
        if (ModelPrihodnayaNaklodnaya.I().Insert(textBoxNomer.Text, dateTimePickerCreateDate.Value.Date.ToString()))
        {
          itemId = ModelPrihodnayaNaklodnaya.I().GetLustId();
          MessageBox.Show("Накладная успешно добавлена");
        }
        else 
        {
          MessageBox.Show("Произошла ошибка, попробуйте еще раз или обратитесь к админестратору");
        }
      }
      else 
      {
        if (ModelPrihodnayaNaklodnaya.I().Update(itemId.ToString(), textBoxNomer.Text, dateTimePickerCreateDate.Value.Date.ToString()))
        {
          MessageBox.Show("Накладная успешно изменена");
        }
        else
        {
          MessageBox.Show("Произошла ошибка, попробуйте еще раз или обратитесь к админестратору");
        }
      }
      formPrihodnayaNaklodnayaSpisok.LoadItems();
      }
      else 
      {
        MessageBox.Show("Укажите номер");
      }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      if (itemId > 0)
      {
        FormPrihodnayaNakadnayaEdit f = new FormPrihodnayaNakadnayaEdit(0, itemId, this);
        f.Show();
      }
      else
      {
        MessageBox.Show("Нужно создать накладную");
      }

    }

    private void FormPrihodnayaNaklodnaya_Load(object sender, EventArgs e)
    {

    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
      if (dataGridViewList.SelectedRows.Count == 1)
      {
        Int16 id = 0;
        Int16.TryParse(dataGridViewList.SelectedRows[0].Cells["id"].Value.ToString(), out id);
        FormPrihodnayaNakadnayaEdit f = new FormPrihodnayaNakadnayaEdit(id, itemId,this);
        f.Show();
      }
      else
      {
        if (dataGridViewList.SelectedRows.Count > 1)
        {
          MessageBox.Show("Выберите только одну запись");
        }
        else
        {
          MessageBox.Show("Выберите одну запись");
        }
      }
        
    }
    private String GetIdSetFromSelectedRows()
    {
      String set = "";
      for (int i = 0; i < dataGridViewList.SelectedRows.Count; i++)
      {
        if (set == "")
        {
          set += dataGridViewList.SelectedRows[i].Cells[0].Value.ToString();
        }
        else
        {
          set += "," + dataGridViewList.SelectedRows[i].Cells[0].Value.ToString();
        }
      }
      return set;
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
      Int32 selectedRowCount = dataGridViewList.SelectedRows.Count;

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

          ModelPrihodnayaNakladnayaIt.I().DeleteByIdSet(delet_id_str);
          LoadValues();
        }
      }
      else
      {
        MessageBox.Show("Выберите хотя бы одну строку");
      }
    }
  }
}
