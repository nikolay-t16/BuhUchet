using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuhUchet
{
  struct OrderItemsItem
  {
    public string Id;
    public string IdOrder;
    public string IdClothes;
    public string ClothesName;
    public string ClothesPrice;
    public string Count;
    public string Date;
    public ClothesItem Clothes;
  }
}
