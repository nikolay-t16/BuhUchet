using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace BuhUchet
{
  class ModelClothes
  {
    protected static OleDbConnection conn;
    const String TABLE_NAME = "clothes";
    public ModelClothes()
    {
        conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BuhUchet.mdb");//это строка соединения с БД
        conn.Open();   
      }
    public Boolean Insert(Int16 id, String name, String parent)
    {
      String set = "name, p_id";
      String val = "@name, @p_id";
      if (id > 0) {
        set = "id, "+set;
        val = "@id, "+val;
      }
        OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
        try
          {
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT into "+TABLE_NAME+" ("+set+") VALUES ("+val+")";
            command.Connection = conn;
            if (id > 0) 
            {
              command.Parameters.AddWithValue("@id", id);
            }
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@p_id", parent);
            int i = command.ExecuteNonQuery();//Выполняем запрос, в данном случе на чтение
            if (i > 0) 
            {
              return true;
            }   
          }
          catch (Exception)
          {                
            throw;
          }
          
        return false;
      }
    public Boolean Update(Int16 id, String name, String p_id)
    {
      String set = "";
      set += " name = '" + name + "',";
      set += " p_id = '" + p_id.ToString() + "'";
      
       
      OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
      //try
      //{
        command.CommandType = CommandType.Text;
        command.CommandText = "UPDATE " + TABLE_NAME + " set " + set + " where id = " + id.ToString();
        command.Connection = conn;
        
      
        int i = command.ExecuteNonQuery();//Выполняем запрос, в данном случе на чтение
        if (i > 0)
        {
          return true;
        }
        else
        {
          return false;
        }
      //}
      //catch (Exception)
      //{
      //  return false;
      //  throw;
      //}
      
    }

    public void DeleteWhere(String where) {
      OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
      try
      {
        command.CommandType = CommandType.Text;
        command.CommandText = "delete FROM " + TABLE_NAME + " WHERE " + where + ";";
        command.Connection = conn;
        
        int i = command.ExecuteNonQuery();//Выполняем запрос, в данном случе на чтение
      }
      catch (Exception)
      {
       throw;
      }


     
    }

    public void DeleteByIdSet(String id_set) 
    {
      DeleteWhere("id in ( " + id_set + " )");
    }

    public OleDbDataReader GetById(String id)
    {
      return GetItems("id = " + id);      
    }

    public OleDbDataReader Search(String search,String p_id)
    {
      return GetItems("name like '%" + search + "%' and p_id="+p_id+" order by name ASC");     
      
    }
    public OleDbDataReader GetItems(String where) {
      OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
      command.CommandType = CommandType.Text;
      command.CommandText = "SELECT * FROM " + TABLE_NAME + " WHERE " + where;
      command.Connection = conn;

      try
      {
        OleDbDataReader reader = command.ExecuteReader();//Выполняем запрос, в данном случе на чтение
        return reader;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public int GetCount(String where)
    {
      OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
      command.CommandType = CommandType.Text;
      command.CommandText = "SELECT count(*) as RowCount FROM " + TABLE_NAME + " WHERE " + where;
      command.Connection = conn;

      try
      {
        OleDbDataReader reader = command.ExecuteReader();//Выполняем запрос, в данном случе на чтение
        reader.Read();
        int rowCount = (int)reader["RowCount"];
        return rowCount;
      }
      catch (Exception)
      {
        throw;
      }
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
        Console.Write(reader["name"].ToString());
        i++;
      }
      return rubs;
    }
  }
}
