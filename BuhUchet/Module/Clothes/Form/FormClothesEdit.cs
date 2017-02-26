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
    private FormClothesList fParent;
    private int itemId = 0;
    private ClothesItem clothesItem;
    private List<ClothesTreeItem> rubList = new List<ClothesTreeItem>();
    public FormClothesEdit(FormClothesList f, int id)
    {
      Console.WriteLine("FormClothesEdit "+ id);
      fParent = f;
      itemId = id;
      InitializeComponent();
      
    }
    public void SetRubs()
    {

      comboBoxParent.Items.Clear();
      rubList.Clear();
      rubList.Add(new ClothesTreeItem() { Id = "0", Name = "Пусто" });
      comboBoxParent.Items.Add("Пусто");
      foreach (var rubsList in ModelClothes.I().ClothesTree["0"])
      {
        comboBoxParent.Items.Add(rubsList.Value.Name);
        rubList.Add(rubsList.Value);
        if (clothesItem!=null && clothesItem.PId == rubsList.Value.Id)
        {
          comboBoxParent.SelectedIndex = comboBoxParent.Items.Count - 1;
        }
      }
      if (comboBoxParent.SelectedIndex < 0) {
        comboBoxParent.SelectedIndex = 0;
      }
      
    }
    
    public void SetDefaultFieldValues()
    {
      textBoxName.Text = "";
      textBoxEdIzm.Text = "";
      textBoxSrok.Text = "";
      if (itemId == 0)
        return;
      clothesItem = ModelClothes.I().GetItem(itemId);
      if (clothesItem != null)
      {
        Console.WriteLine(itemId);
        textBoxName.Text = clothesItem.Name;
        textBoxEdIzm.Text = clothesItem.EdIzm;
        textBoxSrok.Text = clothesItem.SrokNoski;
      }
      else
      {
        MessageBox.Show("Произошла ошибка, обратитесь к админестратоору");
        itemId = 0;
        textBoxName.Text = "";        
      }
      SetRubs();
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
          var rubId = comboBoxParent.SelectedIndex>0?rubList[comboBoxParent.SelectedIndex].Id:"0";
          Boolean t = ModelClothes.I().Insert(
            textBoxName.Text,
            rubId,
            textBoxEdIzm.Text,
            textBoxSrok.Text
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
          Boolean t = ModelClothes.I().Update(
            itemId.ToString(), 
            textBoxName.Text,
            rubList[comboBoxParent.SelectedIndex].Id,
            textBoxEdIzm.Text,
            textBoxSrok.Text
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
        fParent.Search();
      }
    }

    private void FormClothesEdit_Load(object sender, EventArgs e)
    {
      SetDefaultFieldValues();
    }
  }
}
