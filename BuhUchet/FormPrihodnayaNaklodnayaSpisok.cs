using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BuhUchet
{
  public partial class FormPrihodnayaNaklodnayaSpisok : Form
  {
    public FormPrihodnayaNaklodnayaSpisok()
    {
      InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
      FormPrihodnayaNaklodnaya f = new FormPrihodnayaNaklodnaya(0,this);
      f.Show();
    }

    private void FormPrihodnayaNaklodnayaSpisok_Load(object sender, EventArgs e)
    {
      LoadItems();
    }

    public void LoadItems() 
    {
      OleDbDataReader items = ModelPrihodnayaNaklodnaya.I().GetItems("1 order by date_add");
      dataGridViewList.Rows.Clear();
      if (items != null)
      {
        int rowNumber;
        while (items.Read())//а здесь собственно записи полей
        {
          rowNumber = dataGridViewList.Rows.Add();
          dataGridViewList.Rows[rowNumber].Cells["id"].Value = items["id"].ToString();
          dataGridViewList.Rows[rowNumber].Cells["nomer"].Value = items["nomer"].ToString();
          dataGridViewList.Rows[rowNumber].Cells["date"].Value = items["date_add"].ToString();
        }
      }
    }

    private void buttonOpen_Click(object sender, EventArgs e)
    {
      if (dataGridViewList.SelectedRows.Count == 1)
      {
        Int16 id = 0;
        Int16.TryParse(dataGridViewList.SelectedRows[0].Cells["id"].Value.ToString(), out id);
        FormPrihodnayaNaklodnaya f = new FormPrihodnayaNaklodnaya(id, this);
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
  }
}
