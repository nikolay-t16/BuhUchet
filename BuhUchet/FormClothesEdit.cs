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
  public partial class FormClothesEdit : Form
  {
    private static ModelClothes modelClothes;
    private Int16 itemId = 0;
    private String[,] rubsList;
    public FormClothesEdit()
    {
      InitializeComponent();
      modelClothes = new ModelClothes();
      SetRubs();
    }
    public void SetRubs()
    {
      comboBoxParent.Items.Clear();
      rubsList = modelClothes.GetRubs();
      for (int i = 0; i < rubsList.Length / 2; i++)
      {
        if (rubsList[i, 1] != "")
        {
          comboBoxParent.Items.Add(rubsList[i, 1]);
        }
      }
      comboBoxParent.SelectedIndex = 0;
    }
    public void setId(Int16 id)
    {
      itemId = id;

    }

    public void SetDefaultFieldValues()
    {
      OleDbDataReader item = modelClothes.GetById(itemId.ToString());
      if (item != null)
      {
        item.Read();
        textBoxName.Text = item["name"].ToString();   

      }
      else
      {
        MessageBox.Show("Произошла ошибка, обратитесь к админестратоору");
        itemId = 0;
        textBoxName.Text = "";        
      }
    }
    private Boolean ValidTextBox(TextBox textBox, string fieldName)
    {
      char[] charsToTrim = { ' ' };
      if (textBox.Text.Trim(charsToTrim) == "")
      {
        textBox.Focus();
        MessageBox.Show("Не заполнено поле \"" + fieldName + "\"");
        return false;
      }
      return true;
    }
    protected Boolean ValidateFormFields()
    {
      if (
          ValidTextBox(textBoxName, "Название")
         )
      {
        return true;
      }
      else
      {
        return false;
      }
    }

   

    private void buttonEdit_Click(object sender, EventArgs e)
    {
      if (ValidateFormFields())
      {
        if (itemId == 0)
        {
          Boolean t = modelClothes.Insert(itemId, textBoxName.Text, rubsList[comboBoxParent.SelectedIndex, 0]);
          
          if (t)
          {
            MessageBox.Show("Запись успешно добавленна");
          }
          else
          {
            MessageBox.Show("Запись не добавленна, обратитесь к админестратору");
          }
        }
        else
        {
          Boolean t = modelClothes.Update(itemId, textBoxName.Text, rubsList[comboBoxParent.SelectedIndex, 0]);
          if (t)
          {
            MessageBox.Show("Запись успешно добавленна");
          }
          else
          {
            MessageBox.Show("Запись не добавленна, обратитесь к админестратору");
          }
        }
      }
    }
  }
}
