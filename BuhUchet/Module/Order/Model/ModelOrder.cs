using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace BuhUchet
{
  class ModelOrder : Model
  {

    protected static String tableChildName = "deti";
    protected static ModelOrder Instanse;
    public Dictionary<string, OrderItem> OrderList
    {
      get
      {
        var rez = new Dictionary<string, OrderItem>();
        var items = this.GetList();
        if (items != null)
        {
          var i = 0;
          while (items.Read())
          {
            rez.Add(
              items["id"].ToString(),
              new OrderItem()
              {
                Id = items["id"].ToString(),
                Date = items["date"].ToString(),
                IdChild = items["id_child"].ToString(),
                Fio = items["fio"].ToString()
              }
            );
          }
        }
        return rez;
      }
      set
      {
        OrderList = value;
      }
    }
    public static ModelOrder I()
    {
      if (Instanse == null)
      {
        Instanse = new ModelOrder();
      }
      return Instanse;
    }
    protected ModelOrder()
      : base("order")
    {
    }
    protected String[,] MakeSet(string date, String id_child)
    {
      String[,] set = new String[2, 2];
      set[0, 0] = "date";
      set[0, 1] = date;
      set[1, 0] = "id_child";
      set[1, 1] = id_child;
      return set;
    }
    public Boolean Insert(string date, String id_child)
    {
      return Insert(MakeSet(date, id_child));
    }
    public Boolean Update(String id, string date, String id_child)
    {
      return Update(MakeSet(date, id_child), "id = " + id);
    }
    public OleDbDataReader GetList()
    {
      return QueryResult("select ord.*,d.fio from `" + tableName + "` as `ord`, " + tableChildName + " as `d` where d.id=ord.id_child order by date DESC");
    }
    public OrderItem GetItem(string id)
    {
      var data = GetById(id);
      if (data != null)
      {
        data.Read();
        var item = new OrderItem()
        {
          Id = data["id"].ToString(),
          IdChild = data["id_child"].ToString(),
          Date = data["date"].ToString()
        };
        return item;
      }
      return null;
    }
    public OleDbDataReader Search(String search)
    {
      return QueryResult("select ord.*,d.fio from `" + tableName + "` as `ord`, " + tableChildName + " as `d` WHERE (d.fio like '%" + search + "%' or ord.id like '%" + search + "%') and d.id=ord.id_child order by date DESC");
    }

    public OrderItem GetItemForOtchet(string id)
    {
      {
        var data = GetById(id);
        if (data != null)
        {
          data.Read();
          var item = new OrderItem()
          {
            Id = data["id"].ToString(),
            IdChild = data["id_child"].ToString(),
            Date = data["date"].ToString()
          };
          item.Child = ModelChildren.I().GetItem(item.IdChild);
          item.Fio = item.Child.Fio;
          item.Items = ModelOrderItems.I().GetClothesList(id).Values.ToList();
          return item;
        }
        return null;
      }
    }
  }
  }
