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
    

    const String TABLE_NAME = "clothes";
    public ModelClothes() : base("clothes")
    {
    }
    protected String[,] MakeSet(String name, String parent, String ed_izm, String srok_noski, string norma_vidachi)
    {
      String[,] set = new String[5, 2];      
      set[0, 0] = "name";
      set[0, 1] = name;
      set[1, 0] = "p_id";
      set[1, 1] = parent;
      set[2, 0] = "ed_izm";
      set[2, 1] = ed_izm;
      set[3, 0] = "srok_noski";
      set[3, 1] = srok_noski;
      set[4, 0] = "norma_vidachi";
      set[4, 1] = norma_vidachi;
      return set;
    }
    public Boolean Insert(String name, String parent, String ed_izm, String srok_noski,String norma_vidachi)
    {
      return Insert(MakeSet(name, parent, ed_izm, srok_noski, norma_vidachi));
    }
    public Boolean Update(String id, String name, String parent, String ed_izm, String srok_noski, string norma_vidachi)
    {
      return Update(MakeSet(name, parent, ed_izm, srok_noski, norma_vidachi), "id = " + id);
    }
  
    public List<ClothesItem> Search(String search,String p_id)
    {
      var rez = new List<ClothesItem>();
      var sql = " order by c.name ASC";
      if (p_id != "0")
      {
        sql = "c.p_id= " + p_id + sql;
      }
      else {
        sql = "c.p_id=0 " + sql;
      }
      if (search != "")
      {
        sql = "c.name like '%" + search + "%' and " + sql;
      }
      var sqlRez = GetItemsForOrder(sql);
      if (sqlRez != null) {
        while (sqlRez.Read()) {
          Console.WriteLine(sqlRez["parent_name"].ToString()+ " sqlRez[parent_name].ToString(),");
          rez.Add(new ClothesItem() {
            Id = sqlRez["id"].ToString(),
            PId = sqlRez["p_id"].ToString(), 
            Name = sqlRez["name"].ToString(),
            EdIzm = sqlRez["ed_izm"].ToString(),
            SrokNoski = sqlRez["srok_noski"].ToString(),
            ParentName = sqlRez["parent_name"].ToString(),
            NormaVidachi = sqlRez["norma_vidachi"].ToString(),
          });
        }
      }
      return rez;    
    }

    public Dictionary<string, Dictionary<string, ClothesTreeItem>> ClothesTree
    {
      get
      {
        var rez = GetTree();
        return rez;
      }
      set 
      {
        ClothesTree = value;
      }
    }

    private Dictionary<string, Dictionary<string,ClothesTreeItem>> GetTree()
    {
      var res = new Dictionary<string, Dictionary<string, ClothesTreeItem>>();
      OleDbDataReader reader = GetItems("id>0 order by name ASC");
      ClothesTreeItem row;
      while (reader.Read())
      {
        row = new ClothesTreeItem() { 
          Id = reader["id"].ToString(), 
          PId = reader["p_id"].ToString(),
          Name = reader["name"].ToString()
        };
        if (res.ContainsKey(row.PId) == false)
        {
          res.Add(
            row.PId,
            new Dictionary<string, ClothesTreeItem>() { { row.Id, row } }
          );
        }
        else 
        {
          res[row.PId].Add(row.Id, row);
        }
        
      }
      return res;
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

    public String[,] GetSubRubs(String id_rub)
    {
      String where = "p_id = " + id_rub;
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

    public ClothesItem GetItem(string id) {
      OleDbDataReader item = ModelClothes.I().GetById(id.ToString());
      if (item != null)
      {

        item.Read();
        var rez = new ClothesItem()
        {
          Id = id.ToString(),
          PId = item["p_id"].ToString(),
          Name = item["name"].ToString(),
          EdIzm = item["ed_izm"].ToString(),
          SrokNoski = item["srok_noski"].ToString(),
          NormaVidachi = item["norma_vidachi"].ToString()
        };
        return rez;
      }
      return null;
    }
    public OleDbDataReader GetItemsForOrder( string sql){
      sql = "SELECT c.id,c.p_id,c.name,pc.name as parent_name,pc.ed_izm,pc.srok_noski,pc.norma_vidachi" +
        " from clothes as c left join clothes as pc on pc.id = c.p_id   where " + sql;
     return QueryResult(sql);
    }
    public ClothesItem GetItemForOrder(string id) {
      var sql = "c.id = " + id;
      var sqlRez = GetItemsForOrder(sql);
      if (sqlRez != null)
      {
        sqlRez.Read();
          Console.WriteLine(sqlRez["parent_name"].ToString() + " sqlRez[parent_name].ToString(),");
          var rez = new ClothesItem()
          {
            Id = sqlRez["id"].ToString(),
            PId = sqlRez["p_id"].ToString(),
            Name = sqlRez["name"].ToString(),
            EdIzm = sqlRez["ed_izm"].ToString(),
            SrokNoski = sqlRez["srok_noski"].ToString(),
            ParentName = sqlRez["parent_name"].ToString(),
            NormaVidachi = sqlRez["norma_vidachi"].ToString(),
          };
          return rez;  
        
      }
      return null;
        
    }
  }
}
