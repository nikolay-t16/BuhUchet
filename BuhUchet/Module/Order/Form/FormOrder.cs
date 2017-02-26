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
using WindowsFormsApplication1.ArmCard;

namespace BuhUchet
{
  public partial class FormOrder : Form
  {
    public FormOrder()
    {
      InitializeComponent();
    }

    private void FormOrder_Load(object sender, EventArgs e)
    {
      LoadItems();
    }
    public void LoadItems()
    {
      OleDbDataReader items = ModelOrder.I().GetList();
      dataGridViewList.Rows.Clear();
      if (items != null)
      {
        int rowNumber;
        while (items.Read())//а здесь собственно записи полей
        {
          rowNumber = dataGridViewList.Rows.Add();
          dataGridViewList.Rows[rowNumber].Cells["id"].Value = items["id"].ToString();
          dataGridViewList.Rows[rowNumber].Cells["date"].Value = items["date"].ToString();
          dataGridViewList.Rows[rowNumber].Cells["name"].Value = items["fio"].ToString();
        } 
      }
    }

    private void buttonSerch_Click(object sender, EventArgs e)
    {
      if (textBoxSearch.Text.Trim() != "")
      {
        OleDbDataReader items = ModelOrder.I().Search(textBoxSearch.Text.Trim());
        dataGridViewList.Rows.Clear();
        if (items != null)
        {
          int rowNumber;
          while (items.Read())
          {
            rowNumber = dataGridViewList.Rows.Add();
            dataGridViewList.Rows[rowNumber].Cells["id"].Value = items["id"].ToString();
            dataGridViewList.Rows[rowNumber].Cells["date"].Value = items["date"].ToString();
            dataGridViewList.Rows[rowNumber].Cells["name"].Value = items["fio"].ToString();
          }
        }
      }
      else
      {
        MessageBox.Show("Ввежите поисковую строку");
      }

    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      FormOrderItem f = new FormOrderItem("0",this);
      f.Show();
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
      if (dataGridViewList.SelectedRows.Count == 1)
      {
        FormOrderItem f = new FormOrderItem(dataGridViewList.SelectedRows[0].Cells[0].Value.ToString(),this);
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

    private void buttonDel_Click(object sender, EventArgs e)
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
          ModelOrder.I().DeleteByIdSet(delet_id_str);
          if (textBoxSearch.Text.Trim() != "")
          {
            buttonSearch.PerformClick();
          }
          else 
          {
            LoadItems();
          }
        }
      }
      else
      {
        MessageBox.Show("Выберите хотя бы одну строку");
      }
    }

    private void CreateFile_Click(object sender, EventArgs e)
    {
      Int32 selectedRowCount = dataGridViewList.SelectedRows.Count;

      if (selectedRowCount ==1)
      {
        var id = dataGridViewList.SelectedRows[0].Cells[0].Value.ToString();
        var order = ModelOrder.I().GetItemForOtchet(id);
        var armCardReport = new ArmCardReport(order);
               
      }
      else
      {
        MessageBox.Show("Выберите одну строку");
      }
    }
  }
}
