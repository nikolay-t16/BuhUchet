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
  public partial class FormPrihodnayaNakadnayaEdit : Form
  {
    protected FormPrihodnayaNaklodnaya fParent;
    protected int pId;
    protected int itemId;
    protected String[,] rubList;
    protected String[,] subRubList;
    protected String[,] subRubCurentList;
    public FormPrihodnayaNakadnayaEdit(int item_id,int p_id, FormPrihodnayaNaklodnaya f_parent)
    {
      
      InitializeComponent();
      itemId = item_id;
      pId = p_id;
      fParent = f_parent;
      
        LoadValues();
      
    }
    protected void LoadValues() 
    {
      comboBoxParent.Items.Clear();
      rubList = ModelClothes.I().GetRubs();
      subRubList = ModelClothes.I().GetSubRubs();
      for (int i = 0; i < rubList.Length / 2; i++)
      {
        if (rubList[i, 1] != "")
        {
          comboBoxParent.Items.Add(rubList[i, 1]);
        }
      }
      comboBoxParent.SelectedIndex = 0;
        if (itemId != 0)
        {
          OleDbDataReader it = ModelPrihodnayaNakladnayaIt.I().GetById(itemId.ToString());
          if (it != null)
          {
            it.Read();
            textName.Text = it["name"].ToString();
            textCount.Text = it["count"].ToString();
            textCena.Text = it["price"].ToString();
          }
        }
      
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      string id_clothes = "0";
      if (comboBoxParent.SelectedIndex > 0 && comboBoxClothes.SelectedIndex>0)
      {
        id_clothes = subRubCurentList[comboBoxClothes.SelectedIndex, 0];
      }
        if (itemId == 0)
        {
          if (ModelPrihodnayaNakladnayaIt.I().Insert(pId.ToString(), id_clothes, textName.Text, textCount.Text,textCena.Text))
          {
            itemId = ModelPrihodnayaNakladnayaIt.I().GetLustId();
            MessageBox.Show("Накладная успешно добавлена");
          }
          else
          {
            MessageBox.Show("Произошла ошибка, попробуйте еще раз или обратитесь к админестратору");
          }
        }
        else
        {
          if (ModelPrihodnayaNakladnayaIt.I().Update(itemId.ToString(), pId.ToString(), id_clothes, textName.Text, textCount.Text, textCena.Text))
          {
            MessageBox.Show("Накладная успешно изменена");
          }
          else
          {
            MessageBox.Show("Произошла ошибка, попробуйте еще раз или обратитесь к админестратору");
          }
        }
        fParent.LoadValues();      
    }

    private void comboBoxClothes_SelectedIndexChanged(object sender, EventArgs e){}

    private void comboBoxParent_SelectedIndexChanged(object sender, EventArgs e)
    {
      
      comboBoxClothes.Items.Clear();

      String id_rub = rubList[comboBoxParent.SelectedIndex, 0];
      if (id_rub != "0")
      {
        int count = 0;
        for (int i = 0; i < subRubList.Length / 3; i++)
        {
          if (subRubList[i, 1] == id_rub || subRubList[i, 0] == "0")
          {
            count++;
          }
        }
        subRubCurentList = new String[count, 3];
        for (int i = 0; i < subRubList.Length / 3; i++)
        {
          if (subRubList[i, 1] == id_rub || subRubList[i, 0] == "0")
          {
            subRubCurentList[i, 0] = subRubList[i, 0];
            subRubCurentList[i, 1] = subRubList[i, 1];
            subRubCurentList[i, 2] = subRubList[i, 2];
            comboBoxClothes.Items.Add(subRubList[i, 2]);
          }
        }
        comboBoxClothes.SelectedIndex = 0;


      }

      
    }
  }
}
