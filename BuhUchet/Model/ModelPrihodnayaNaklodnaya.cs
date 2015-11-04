using System;
using System.Collections.Generic;
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
      return Update(MakeSet(nomer, date_add), id);
    }
  }
}
