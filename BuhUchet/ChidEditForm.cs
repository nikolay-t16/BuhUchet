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
  public partial class ChildEditForm : Form
  {
    private static ModelChildren modelChildren;
    public ChildEditForm()
    {
      InitializeComponent();
      modelChildren = new ModelChildren();    
    }
    
    
    private void ChildEditForm_Load(object sender, EventArgs e)
    {
    
    }
    private Boolean ValidTextBox(TextBox textBox, string fieldName) {
      char[] charsToTrim = { ' ' };
      if (textBox.Text.Trim(charsToTrim) == "")
      {
        textBox.Focus();
        MessageBox.Show("Не заполнено поле \"" + fieldName + "\"");
        return false;
      }
      return true;
    }
    protected Boolean ValidateFormFields() {
      if (
          ValidTextBox(textBoxFio, "ФИО") &&
          ValidTextBox(textBoxClothesSize, "Размер одежды") &&
          ValidTextBox(textBoxShoesSize, "Размер обуви") &&
          ValidTextBox(textBoxHeadSize, "Размер головного у бора")
         )
      {
        return true;
      }
      else {
        return false;
      }
    }
    private void DhildSave_Click(object sender, EventArgs e)
    {
      if (ValidateFormFields())
      {
        Int32 id = 0;
        Int32.TryParse(textBoxId.Text,out id);
        Boolean t = modelChildren.Insert(
                           id,
                           dateTimePickerCreateDate.Value.Date.ToString(),
                           textBoxFio.Text,
                           textBoxClothesSize.Text,
                           textBoxShoesSize.Text,
                            textBoxHeadSize.Text
                           );
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
