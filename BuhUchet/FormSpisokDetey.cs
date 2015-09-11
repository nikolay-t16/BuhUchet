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
    public partial class FormSpisokDetey : Form
    {
        private ChildEditForm childEditForm;
        private ModelChildren modelChildren;
        public FormSpisokDetey()
        {
            InitializeComponent();
            modelChildren = new ModelChildren();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewDetiSearch.Rows.Clear();
            OleDbDataReader reader = modelChildren.Search(textBoxSearch.Text);
            int i = 0;
            if (reader != null)
            {
              while (reader.Read())//а здесь собственно записи полей
              {
                i++;
                int rowNumber = dataGridViewDetiSearch.Rows.Add();
                dataGridViewDetiSearch.Rows[rowNumber].Cells["id"].Value = reader["id"].ToString();
                dataGridViewDetiSearch.Rows[rowNumber].Cells["data_otkritiya_karty"].Value = reader["data_otkritiya_karty"].ToString();
                dataGridViewDetiSearch.Rows[rowNumber].Cells["fio"].Value = reader["fio"].ToString();
                dataGridViewDetiSearch.Rows[rowNumber].Cells["razmer_odegdy"].Value = reader["razmer_odegdy"].ToString();
                dataGridViewDetiSearch.Rows[rowNumber].Cells["razmer_obuvy"].Value = reader["razmer_obuvy"].ToString();
                dataGridViewDetiSearch.Rows[rowNumber].Cells["razmer_golavy"].Value = reader["razmer_golavy"].ToString();
              }

            }   
                
            
        }

        private void detiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buhUchetDataSet);

        }

        private void FormSpisokDetey_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buhUchetDataSet.deti' table. You can move, or remove it, as needed.
            this.detiTableAdapter.Fill(this.buhUchetDataSet.deti);

        }

        private void dataGridViewDetiSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private String GetIdSetFromSelectedRows() {
          String set = "";
          for (int i = 0; i < dataGridViewDetiSearch.SelectedRows.Count; i++)
          {
            if (set == "")
            {
              set += dataGridViewDetiSearch.SelectedRows[i].Cells[0].Value.ToString();
            }
            else
            {
              set += "," + dataGridViewDetiSearch.SelectedRows[i].Cells[0].Value.ToString();
            }
          }        
          return set;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridViewDetiSearch.SelectedRows.Count;

            if (selectedRowCount > 0)
            {
              var  resault = MessageBox.Show(
                    "Вы уверенны что хотите удалить выбранные строки?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo
                    );
              if (resault == DialogResult.Yes)
              {
                  String delet_id_str = GetIdSetFromSelectedRows();
                  
                  modelChildren.DeleteByIdSet(delet_id_str);
                  buttonSearch.PerformClick();      
              }
            }
            else {
                MessageBox.Show("Выберите хотя бы одну строку");
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          childEditForm = new ChildEditForm();
          childEditForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
          if (dataGridViewDetiSearch.SelectedRows.Count == 1) 
          {
            childEditForm = new ChildEditForm();
            Int32 id = 0;
            Int32.TryParse(dataGridViewDetiSearch.SelectedRows[0].Cells[0].Value.ToString(), out id);
            childEditForm.setId(id);
            childEditForm.SetDefaultFieldValues();
            childEditForm.Show();
          }
          else 
          {
            if (dataGridViewDetiSearch.SelectedRows.Count > 1) 
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
