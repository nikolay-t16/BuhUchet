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
  public partial class FormOrderItemEdit : Form
  {
    protected FormOrderItem fParent;
    private Dictionary<string, OrderItem> orderList;
    private Dictionary<string, OrderClothesItem> clothesList = new Dictionary<string, OrderClothesItem>();
    private string orderCount;
    private string orderId;
    private string orderClothesId;
    private string itemId;
    public FormOrderItemEdit(int item_id, string order_id, FormOrderItem f_parent)
    {
      InitializeComponent();
      fParent = f_parent;
      itemId = item_id.ToString();
      orderId = order_id.ToString();
      if (item_id > 0)
      {
        var orderItem = ModelOrderItems.I().GetItem(item_id.ToString());
        orderCount = orderItem.Count;
        orderClothesId = orderItem.IdClothes;
      }
      else {
        orderCount = "0";
        orderClothesId = "0";
      }
    }

    private void FormOrderItemEdit_Load(object sender, EventArgs e)
    {
      LoadOrderList();
      LoadClothesList();
      LoadCountList();
    }
    private void LoadOrderList()
    {
      comboBoxParent.Items.Clear();
      orderList = ModelOrder.I().OrderList;
      var i = 0;
      foreach (var it in orderList)
      {
        comboBoxParent.Items.Add(
          it.Value.Fio + 
          " ( " + it.Value.Date.Substring(0,10) + " )"
        );
        if (it.Value.Id == orderId)
        {
          comboBoxParent.SelectedIndex = i;
        }
        i++;
      }
      if (comboBoxParent.SelectedIndex < 0)
      {
        comboBoxParent.SelectedIndex = 0;
      }
      
    }
    private void LoadClothesList( string idClothesRub="0") {
      comboBoxClothes.Items.Clear();
      clothesList.Clear();
      var cList = ModelOrderItems.I().GetClothesList(orderId);
      var i = 0;
      foreach (var item in cList)
      {
        if (int.Parse(item.Value.Count) > 0)
        {
          comboBoxClothes.Items.Add(item.Value.Name + " ( " + item.Value.Price + " )");
          clothesList.Add(item.Key, item.Value);
          if (item.Key == orderClothesId) 
          {
            comboBoxClothes.SelectedIndex = i;
          }
        }
        i++;
      }
      if (comboBoxClothes.SelectedIndex < 0)
      {
        comboBoxClothes.SelectedIndex = 0;
      }
      comboBoxClothes.SelectedIndex = 0;
    }
    private void LoadCountList() {
      comboBoxCount.Items.Clear();
      for(var i=0;i<=int.Parse(clothesList.ElementAt(comboBoxClothes.SelectedIndex).Value.Count);i++){
        comboBoxCount.Items.Add(i.ToString());
        if(orderCount == i.ToString())
        {
          comboBoxCount.SelectedIndex = i;
        }
      }
      if(comboBoxCount.SelectedIndex<0)
      {
        comboBoxCount.SelectedIndex = 0;
      }
      
    }

    private void comboBoxClothes_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadCountList();
      Console.WriteLine("comboBoxClothes_SelectedIndexChanged");
    }

    private void Save_Click(object sender, EventArgs e)
    {
      if (itemId == "0") {
        Console.WriteLine("Добавление записи:" + orderId + ":" + clothesList.ElementAt(comboBoxClothes.SelectedIndex).Value.Count + ":" + comboBoxCount.SelectedIndex.ToString());
        if (ModelOrderItems.I().Insert(
          orderId,
          clothesList.ElementAt(comboBoxClothes.SelectedIndex).Value.Id,
          comboBoxCount.SelectedIndex.ToString()
          ))
        {
          itemId = ModelOrderItems.I().GetLustId().ToString();
          MessageBox.Show("Запись успешно добавлена");
          fParent.LoadItems(orderId);
        }
        else 
        {
          MessageBox.Show("Запись не добавлена, попробуйте еще раз или обратитесь к админестратору");
        }
      }
          else 
    {
        if (ModelOrderItems.I().Update(
          itemId,
          orderId,
          clothesList.ElementAt(comboBoxClothes.SelectedIndex).Value.Id,
          comboBoxCount.SelectedIndex.ToString()
          ))
        {
          MessageBox.Show("Запись успешно обновлена");
          fParent.LoadItems(orderId);
        }
        else 
        {
          MessageBox.Show("Запись не обновлена, попробуйте еще раз или обратитесь к админестратору");
        }
      }
    }

    
  }
}
