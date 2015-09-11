using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace BuhUchet
{
  class ModelChildren
  {
    protected static OleDbConnection conn;
      public ModelChildren() {
        conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BuhUchet.mdb");//это строка соединения с БД
        conn.Open();   
      }
    public Boolean Insert(Int32 id, String data_otkritiya_karty, String fio, String razmer_odegdy, String razmer_obuvy, String razmer_golavy) {
      String set = "data_otkritiya_karty, fio, razmer_odegdy,razmer_obuvy,razmer_golavy";
      String val = "@data_otkritiya_karty, @fio, @razmer_odegdy,@razmer_obuvy,@razmer_golavy";
      if (id > 0) {
        set = "id, "+set;
        val = "@id, "+val;
      }
        OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
        try
          {
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT into deti ("+set+") VALUES ("+val+")";
            command.Connection = conn;
            if (id > 0) 
            {
              command.Parameters.AddWithValue("@id", id);
            }
            command.Parameters.AddWithValue("@data_otkritiya_karty", data_otkritiya_karty);
            command.Parameters.AddWithValue("@fio", fio);
            command.Parameters.AddWithValue("@razmer_odegdy", razmer_odegdy);
            command.Parameters.AddWithValue("@razmer_obuvy", razmer_obuvy);
            command.Parameters.AddWithValue("@razmer_golavy", razmer_golavy);
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
    public Boolean Update(String id, String data_otkritiya_karty, String fio, String razmer_odegdy, String razmer_obuvy, String razmer_golavy)
    {
      String set = "";
      set += " data_otkritiya_karty = '" + data_otkritiya_karty + "',";
      set += " fio = '" + fio + "',";
      set += " razmer_odegdy = '" + razmer_odegdy + "',";
      set += " razmer_obuvy = '" + razmer_obuvy + "',";
      set += " razmer_golavy = '" + razmer_golavy + "'";
       
      OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
      //try
      //{
        command.CommandType = CommandType.Text;
        command.CommandText = "UPDATE deti set "+ set+" where id = "+id;
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
        command.CommandText = "delete FROM deti WHERE "+ where+";";
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
      OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
      command.CommandType = CommandType.Text;
      command.CommandText = "SELECT * FROM deti WHERE id = " + id;
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
      return null;
    }

    public OleDbDataReader Search(String search)
    {
      OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
      command.CommandType = CommandType.Text;
      command.CommandText = "SELECT * FROM deti WHERE fio like '%" + search + "%' or id like '%" + search + "%'";
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
  }
  

}
