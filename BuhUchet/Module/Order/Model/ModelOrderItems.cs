using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace BuhUchet
{
  class ModelOrderItems: Model
  {
    protected static String tableClothes = "clothes";
    protected static ModelOrderItems Instanse;
    public static ModelOrderItems I() 
    {
      if (Instanse == null)
      {
        Instanse = new ModelOrderItems();
      }
      return Instanse;
    }
    protected ModelOrderItems()
      : base("order_items")
    {
    }
    protected String[,] MakeSet(string id_order, String id_clothes, String count)
    {
      String[,] set = new String[3, 2];
      set[0, 0] = "id_order";
      set[0, 1] = id_order;
      set[1, 0] = "id_clothes";
      set[1, 1] = id_clothes;
      set[2, 0] = "count";
      set[2, 1] = count;
      return set;
    }
    public Boolean Insert(string id_order, String id_clothes, String count)
    {
      return Insert(MakeSet(id_order, id_clothes, count));
    }
    public Boolean Update(String id, string id_order, String id_clothes, String count)
    {
      return Update(MakeSet(id_order, id_clothes, count), "id = "+id);
    }
    public OleDbDataReader GetList() {
      return QueryResult("select ord.*,clothes.name from `" + tableName + "` as `ord`, " + tableClothes + " as `clothes` where clothes.id=ord.id_clothes order by clothes.name DESC");
    }
    //Список доступной одежды
    public Dictionary<string, OrderClothesItem> GetClothesList(string idOrder) {
      var res = new Dictionary<string, OrderClothesItem>();
      var items = QueryResult(
        "select tn.id, tn.price, tn.name, tn.id_clothes," +
      "tn.count, ( select sum(oi.count) from order_items as oi  where oi.id_clothes=tn.id_clothes and oi.id_order<>" + idOrder + " ) as `count_use`" +
      "from `tovar_nakladnaya_ed` as tn");
     while (items.Read())
      {
        var count = items["count"].ToString();
        if (items["count_use"].ToString() != "") {
          count = (Int32.Parse(items["count"].ToString()) - Int32.Parse(items["count_use"].ToString())).ToString();
        }
        res.Add(
          items["id_clothes"].ToString(),
          new OrderClothesItem()
          {
            Id = items["id_clothes"].ToString(),
            Name = items["name"].ToString(),
            Price = items["price"].ToString(),
            Count = count.ToString()
          }
          );
      }
      return res;
    }
    public OrderItemsItem GetItem(string idOrderItem) {
      OleDbDataReader item = this.GetById(idOrderItem);
      if(item == null){
        return new OrderItemsItem() { };
      }
      else
      {
        item.Read();
        return new OrderItemsItem()
        {
          Id = item["id"].ToString(),
          IdOrder = item["id_order"].ToString(),
          IdClothes = item["id_clothes"].ToString(),
          Count = item["count"].ToString(),
          Date = item["date"].ToString(),
        };
      }
      
    }
  }
}
