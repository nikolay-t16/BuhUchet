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
      Dictionary<string, NaklodnayaItem> items = ModelPrihodnayaNaklodnaya.I().GetItems();
      dataGridViewList.Rows.Clear();
      if (items != null)
      {
        int rowNumber;
        foreach (var it in items.Values) 
        { 
          rowNumber = dataGridViewList.Rows.Add();
          dataGridViewList.Rows[rowNumber].Cells["id"].Value = it.Id;
          dataGridViewList.Rows[rowNumber].Cells["nomer"].Value = it.Nomer;
          dataGridViewList.Rows[rowNumber].Cells["date"].Value = it.DateAdd;
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

    private void buttonDelete_Click(object sender, EventArgs e)
    {
      if (dataGridViewList.SelectedRows.Count > 0)
      {
        var resault = MessageBox.Show(
      "Вы уверенны что хотите удалить выбранные строки?",
      "Подтверждение удаления",
      MessageBoxButtons.YesNo
      );
        if (resault == DialogResult.Yes)
        {
          {
            for (int i = 0; i < dataGridViewList.SelectedRows.Count; i++)
            {
              ModelPrihodnayaNaklodnaya.I().DeleteById(dataGridViewList.SelectedRows[i].Cells[0].Value.ToString());                            
            }
           
          }
          LoadItems();
          
        }        
      }
      else
      {
        MessageBox.Show("Выберите одну запись");
      }
        

        
    }

    private void CreateExcel_Click(object sender, EventArgs e)
    {
      if (dataGridViewList.SelectedRows.Count > 0)
      {
        for (int i = 0; i < dataGridViewList.SelectedRows.Count; i++)
        {
          ModelPrihodnayaNaklodnaya.I().DeleteById(dataGridViewList.SelectedRows[i].Cells[0].Value.ToString());
        }


        LoadItems();

      }
      
    }
  }
}
