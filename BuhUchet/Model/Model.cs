using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace BuhUchet
{
  class Model
  { 
      protected static OleDbConnection conn;
      protected String tableName = "";
      public Model(String table_name)
      {
        tableName = table_name;
        conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BuhUchet.mdb");//это строка соединения с БД
        conn.Open();
      }
      public Boolean Insert(String[,] param)
      {
        OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
        try
        {
          String set = "";
          String val = "";
          for (int i = 0; i < param.Length / 2; i++)
          {
            if (set != "") 
            {
              set = set + ",";
              val = val + ",";
            }
            set = set + "`"+param[i, 0]+"`";
            val = val + "@" + param[i, 0];
          }
          command.CommandType = CommandType.Text;
          command.CommandText = "INSERT into `" + tableName + "` (" + set + ") VALUES (" + val + ")";
          Console.WriteLine("INSERT into `" + tableName + "` (" + set + ") VALUES (" + val + ");");
          
          command.Connection = conn;
          for (int i = 0; i < param.Length / 2; i++)
          {
            command.Parameters.AddWithValue("@" + param[i, 0], param[i, 1]);
          }
          int res = command.ExecuteNonQuery();//Выполняем запрос, в данном случе на чтение
          if (res > 0)
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
      public Boolean Update(String[,] param, String where)
      {
        try
        {
          String set = "";
          for (int i = 0; i < param.Length / 2; i++)
          {
            if (set != "")
            {
              set = set + ",";
            }
            set = set + "`" + param[i, 0] + "`='" + param[i, 1] + "'";
          }
          String comand_text = "UPDATE " + tableName + " set " + set;
          if (where != "")
          {
            comand_text = comand_text + " where " + where;
          }
          OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
          command.CommandType = CommandType.Text;
          command.CommandText = comand_text;
          Console.WriteLine(comand_text);
          command.Connection = conn;
          int res = command.ExecuteNonQuery();//Выполняем запрос, в данном случе на чтение
          if (res > 0)
          {
            return true;
          }
          else
          {
            return false;
          }
          }
          catch (Exception)
          {
            
            throw;
          }
          return false;
        
      }
      public void DeleteWhere(String where)
      {
        OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
        try
        {
          command.CommandType = CommandType.Text;
          command.CommandText = "delete FROM "+ tableName +" WHERE " + where + ";";
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
        command.CommandText = "SELECT * FROM " + tableName + " WHERE id = " + id;
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
      public OleDbDataReader GetItems(String where)
      {
        OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
        String sql_text = "SELECT * FROM `" + tableName + "`";
        if (where != "") 
        {
          sql_text += "where " + where;
        }
        command.CommandType = CommandType.Text;
        command.CommandText = sql_text;
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
      public int GetLustId()
      {
        int id = 0;
        OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
        command.CommandType = CommandType.Text;
        command.CommandText = "Select @@Identity";
        command.Connection = conn;
        try
        {
          id = (int)command.ExecuteScalar();
        }
        catch (Exception)
        {
          throw;
        }
        return id;

      }
      public int GetCount(String where)
      {
        OleDbCommand command = new OleDbCommand();//Создаём SQL-запрос
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT count(*) as RowCount FROM " + tableName + " WHERE " + where;
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

  }
}
