using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace BuhUchet
{
  class ModelChildren:Model
  {
    protected static ModelChildren Instanse;
    public static ModelChildren I()
    {
      if (Instanse == null)
      {
        Instanse = new ModelChildren();
      }
      return Instanse;
    }

    protected static OleDbConnection conn;
    const String TABLE_NAME = "deti";
    public ModelChildren() : base(TABLE_NAME)
    { 
    }
    protected String[,] MakeSet(int id,String data_otkritiya_karty, String fio, String razmer_odegdy, String razmer_obuvy, String razmer_golavy)
    {
      String[,] set;
      if (id > 0)
      {
        set = new String[6, 2];
      }
      else
      {
        set = new String[5, 2];
      }
      set[0, 0] = "data_otkritiya_karty";
      set[0, 1] = data_otkritiya_karty;
      set[1, 0] = "fio";
      set[1, 1] = fio;
      set[2, 0] = "razmer_odegdy";
      set[2, 1] = razmer_odegdy;
      set[3, 0] = "razmer_obuvy";
      set[3, 1] = razmer_obuvy;
      set[4, 0] = "razmer_golavy";
      set[4, 1] = razmer_golavy;
      if (id > 0)
      {
        set[5, 0] = "id";
        set[5, 1] = id.ToString();
      }
      return set;
    }
    
    public Boolean Insert(Int32 id, String data_otkritiya_karty, String fio, String razmer_odegdy, String razmer_obuvy, String razmer_golavy) {
      return Insert(MakeSet(id, data_otkritiya_karty, fio, razmer_odegdy, razmer_obuvy, razmer_golavy));
      }
    public Boolean Update(String id, String data_otkritiya_karty, String fio, String razmer_odegdy, String razmer_obuvy, String razmer_golavy)
    {
      return Update(MakeSet(0, data_otkritiya_karty, fio, razmer_odegdy, razmer_obuvy, razmer_golavy), "id="+id);
    }

    public ChildItem GetItem(string id) {
      var data = GetById(id);
      if (data != null)
      {
        data.Read();
        var item = new ChildItem()
        {
          Id = data["id"].ToString(),
          Fio = data["fio"].ToString(),
          RazmerGolavy = data["razmer_golavy"].ToString(),
          RazmerObuvy = data["razmer_obuvy"].ToString(),
          RazmerOdegdy = data["razmer_odegdy"].ToString()
        };
        return item;
      }
      return null;
    }

    public List<ChildItem> Search(String search)
    {
      var res = new List<ChildItem>();
      var reader = GetItems("fio like '%" + search + "%' or id like '%" + search + "%'");
      if (reader != null)
      {
        while (reader.Read())//а здесь собственно записи полей
        {
          res.Add(new ChildItem
          {
            Id = reader["id"].ToString(),
            Fio = reader["fio"].ToString(),
            DataOtkritiyaKarty = reader["data_otkritiya_karty"].ToString(),
            RazmerGolavy = reader["razmer_golavy"].ToString(),
            RazmerObuvy = reader["razmer_obuvy"].ToString(),
            RazmerOdegdy = reader["razmer_golavy"].ToString()
          });

        }
      }
      return res;
    }

    public Dictionary<string, ChildItem> GetChildList() {
      var list = new Dictionary<string, ChildItem>();
      var items = ModelChildren.I().GetItems("1 order by `fio` ASC");
      if (items != null)
      {
        while (items.Read())
        {
          list.Add(
            items["id"].ToString(),
            new ChildItem() 
            {
              Id = items["id"].ToString(),
              Fio = items["fio"].ToString(),
              DataOtkritiyaKarty = items["data_otkritiya_karty"].ToString(),
              RazmerOdegdy = items["razmer_odegdy"].ToString(),
              RazmerObuvy = items["razmer_obuvy"].ToString(),
              RazmerGolavy = items["razmer_golavy"].ToString()
            }
            );
        }
      }
      return list;
    }
    
  }
 
  

}
