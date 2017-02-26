using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BuhUchet
{
  public class OrderItem
  {
    public string Id;
    public string Date;
    public string IdChild;
    public string Fio;
    public ChildItem Child;
    public List<OrderClothesItem> Items;
  }
}