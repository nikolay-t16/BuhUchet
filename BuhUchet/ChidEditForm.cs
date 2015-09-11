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
  public partial class ChildEditForm : Form
  {
    private static ModelChildren modelChildren;
    public ChildEditForm()
    {
      InitializeComponent();
      modelChildren = new ModelChildren();    
    }

    public void setId( Int32 id) {
      childId = id;
      textBoxId.ReadOnly = true;
      
    }

    public void SetDefaultFieldValues() {
      OleDbDataReader item = modelChildren.GetById(childId.ToString());
      if (item != null)
      {
        item.Read();
        System.Console.WriteLine(item["data_otkritiya_karty"].ToString());
        DateTime date = DateTime.ParseExact(item["data_otkritiya_karty"].ToString(), "dd'.'MM'.'yyyy h:mm:ss", CultureInfo.InvariantCulture);
        textBoxId.Text = item["id"].ToString();
        textBoxId.ReadOnly = true;
        textBoxFio.Text = item["fio"].ToString();
        textBoxClothesSize.Text = item["razmer_odegdy"].ToString();
        textBoxShoesSize.Text = item["razmer_obuvy"].ToString();
        textBoxHeadSize.Text = item["razmer_golavy"].ToString();
        dateTimePickerCreateDate.Value = date;
       
      }
      else 
      {
        MessageBox.Show("Произошла ошибка, обратитесь к админестратоору");
        childId = 0;
        textBoxId.Text = "";
        textBoxId.ReadOnly = false;
        textBoxFio.Text = "";
        textBoxClothesSize.Text = "";
        textBoxShoesSize.Text = "";
        textBoxHeadSize.Text = "";
      }
    }
    private Int32 childId = 0;
    
    
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
        if (childId == 0)
        {
          Int32 id = 0;
          Int32.TryParse(textBoxId.Text, out id);
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
        else 
        {
          Boolean t = modelChildren.Update(
                             textBoxId.Text,
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
}
