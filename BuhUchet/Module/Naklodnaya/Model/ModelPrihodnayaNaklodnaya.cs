using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuhUchet
{
  class ModelPrihodnayaNaklodnaya : Model
  {
    protected static ModelPrihodnayaNaklodnaya Instanse;
    public static ModelPrihodnayaNaklodnaya I() 
    {
      if (Instanse == null)
      {
        Instanse = new ModelPrihodnayaNaklodnaya();
      }
      return Instanse;
    }
    protected ModelPrihodnayaNaklodnaya() : base("tovar_nakladnaya")
    {
      
    }
    protected String[,] MakeSet(string nomer, String date_add) {
      String[,] set = new String[2, 2];
      set[0, 0] = "nomer";
      set[0, 1] = nomer;
      set[1, 0] = "date_add";
      set[1, 1] = date_add;
      return set;
    }
    public Boolean Insert(string nomer, String date_add)
    {
      return Insert(MakeSet(nomer, date_add));
    }
    public Boolean Update(String id,string nomer, String date_add)
    {
      return Update(MakeSet(nomer, date_add), "id = " + id);
    }
    public void DeleteById(String id) {
      ModelPrihodnayaNakladnayaIt.I().DeleteWhere("id_naklad="+id);
      DeleteWhere("id="+id);
    }
    public NaklodnayaItem GetItem(int id)
    {
      OleDbDataReader item = GetById(id.ToString());
      if (item != null)
      {

        item.Read();
        var rez = new NaklodnayaItem()
        {
          Id = id.ToString(),
          DateAdd= item["date_add"].ToString(),
          Nomer  = item["nomer"].ToString()
        };
        return rez;
      }
      return null;
    }
    public Dictionary<string, NaklodnayaItem> GetItems()
    {
      var rez = new Dictionary<string, NaklodnayaItem>();
      OleDbDataReader items = GetItems("1 order by id");
      if (items != null)
      {

        if (items.Read()) {
          rez.Add(items["id"].ToString(),
           new NaklodnayaItem()
           {
             Id = items["id"].ToString(),
             DateAdd = items["date_add"].ToString(),
             Nomer = items["nomer"].ToString()
           });
        
          return rez;
        }
      }
      return null;
    }
  }
}
