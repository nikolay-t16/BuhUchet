using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace BuhUchet
{
  class ModelClothes : Model
  {
    protected static ModelClothes Instanse;
    public static ModelClothes I()
    {
      if (Instanse == null)
      {
        Instanse = new ModelClothes();
      }
      return Instanse;
    }

    protected static OleDbConnection conn;
    const String TABLE_NAME = "clothes";
    public ModelClothes() : base("clothes")
    {
    }
    protected String[,] MakeSet(String name, String parent)
    {
      String[,] set = new String[2, 2];      
      set[0, 0] = "name";
      set[0, 1] = name;
      set[1, 0] = "p_id";
      set[1, 1] = parent;      
      return set;
    }
    public Boolean Insert(String name, String parent)
    {
      return Insert(MakeSet(name, parent));
    }
    public Boolean Update(String id, String name, String parent)
    {
      return Update(MakeSet(name, parent), id);
    }
  
    public void DeleteByIdSet(String id_set) 
    {
      DeleteWhere("id in ( " + id_set + " )");
    }

    public OleDbDataReader Search(String search,String p_id)
    {
      return GetItems("name like '%" + search + "%' and p_id="+p_id+" order by name ASC");     
      
    }
   
    
    public String[,] GetRubs()
    {
      String where = "p_id = 0";
      int count = GetCount(where);
      OleDbDataReader reader = GetItems(where +" order by name ASC");
      String[,] rubs = new String[count+1, 2];
      rubs[0, 0] = "0";
      rubs[0, 1] = "Пусто";      
      int i = 1;
      while (reader.Read()) {
        rubs[i, 0] = reader["id"].ToString();
        rubs[i, 1] = reader["name"].ToString();
        i++;
      }
      return rubs;
    }
    public String[,] GetSubRubs()
    {
      String where = "p_id > 0";
      int count = GetCount(where);
      OleDbDataReader reader = GetItems(where + " order by name ASC");
      String[,] rubs = new String[count + 1, 3];
      rubs[0, 0] = "0";
      rubs[0, 1] = "0";
      rubs[0, 2] = "Пусто";
      int i = 1;
      while (reader.Read())
      {
        rubs[i, 0] = reader["id"].ToString();
        rubs[i, 1] = reader["p_id"].ToString();
        rubs[i, 2] = reader["name"].ToString();
        i++;
      }
      return rubs;
    }
  
  }
}
