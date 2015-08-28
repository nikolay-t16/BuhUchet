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
        public FormSpisokDetey()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewDetiSearch.Rows.Clear();

            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BuhUchet.mdb"))//это строка соединения с БД
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM deti WHERE fio like '%" + textBoxSearch.Text + "%'", conn);//Создаём SQL-запрос
               
                conn.Open();
                try
                {
                    OleDbDataReader reader = command.ExecuteReader();//Выполняем запрос, в данном случе на чтение
                    int i = 0;
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
                    //textBoxSearch.Text = i.ToString();
                }
                catch (Exception)
                {

                    textBoxSearch.Text = "Ошибка";
                    //throw;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridViewDetiSearch.SelectedRows.Count;

            if (selectedRowCount > 0)
            {
              var  resault = MessageBox.Show(
                    "Вы уверенны что хотите удалить выбранные строки?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo
                    );
              if (resault == DialogResult.Yes)
              {
                  String delet_id_str = "";
                  for (int i = 0; i < selectedRowCount; i++)
            {
                if (delet_id_str == "")
                {
                    delet_id_str += dataGridViewDetiSearch.SelectedRows[i].Cells[0].Value.ToString();

                }
                else {
                    delet_id_str += ","+dataGridViewDetiSearch.SelectedRows[i].Cells[0].Value.ToString();
                      
                }                     
              
            }
                  
                
                  using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BuhUchet.mdb"))//это строка соединения с БД
                  {

                      OleDbCommand command = new OleDbCommand("delete FROM deti WHERE id in (" + delet_id_str + ")", conn);//Создаём SQL-запрос

                      conn.Open();
                      try
                      {
                          int i = command.ExecuteNonQuery();//Выполняем запрос, в данном случе на чтение
                          MessageBox.Show(i.ToString());
                      }
                      catch (Exception)
                      {

                          textBoxSearch.Text = "Ошибка";
                          //throw;
                      }


                  } buttonSearch.PerformClick();
                          
              }
            }
            else {
                MessageBox.Show("Выберите хотя бы одну строку");
            }
        }
        
    }
}
