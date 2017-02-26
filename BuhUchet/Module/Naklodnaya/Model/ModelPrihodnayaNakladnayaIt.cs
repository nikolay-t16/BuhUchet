using BuhUchet.Module.Naklodnaya.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuhUchet
{
  class ModelPrihodnayaNakladnayaIt : Model
  {
    protected static ModelPrihodnayaNakladnayaIt Instanse;
    public static ModelPrihodnayaNakladnayaIt I()
    {
      if (Instanse == null)
      {
        Instanse = new ModelPrihodnayaNakladnayaIt();
      }
      return Instanse;
    }
    protected ModelPrihodnayaNakladnayaIt() : base("tovar_nakladnaya_ed")
    {
      
    }
    protected String[,] MakeSet(string id_naklad, String id_clothes, String name, String count, String price)
    {
      String[,] set = new String[5, 2];
      set[0, 0] = "id_naklad";
      set[0, 1] = id_naklad;
      set[1, 0] = "id_clothes";
      set[1, 1] = id_clothes;
      set[2, 0] = "name";
      set[2, 1] = name;
      set[3, 0] = "count";
      set[3, 1] = count;
      set[4, 0] = "price";
      set[4, 1] = price;
      return set;
    }
    public Boolean Insert(string id_naklad, String id_clothes, String nazvanie, String kol_vo, String cena)
    {
      return Insert(MakeSet(id_naklad, id_clothes, nazvanie, kol_vo, cena));
    }
     
    public Boolean Update(String id, string id_naklad, String id_clothes, String nazvanie, String kol_vo, String cena)
    {
      return Update(MakeSet(id_naklad, id_clothes, nazvanie, kol_vo, cena), "id="+id);
    }

    public Dictionary<string, NaklodnayaClothesItem> GetItems(string nId) {

      var items = base.GetItems("id_naklad=" + nId);
      if (items != null)
      {
        var rez = new Dictionary<string, NaklodnayaClothesItem>();
        String[,] rubs_list = ModelClothes.I().GetRubs();
        String[,] sub_rubs_list = ModelClothes.I().GetSubRubs();
        int rowNumber;
        while (items.Read())
        {
          string group_name = "";
          if (items["id_clothes"].ToString() != "0")
          {
            for (int i = 0; i < sub_rubs_list.Length; i++)
            {
              if (sub_rubs_list[i, 0] == items["id_clothes"].ToString())
              {
                group_name = "/" + sub_rubs_list[i, 2];
                for (int j = 0; j < rubs_list.Length; j++)
                {
                  if (sub_rubs_list[i, 1] == rubs_list[j, 0])
                  {
                    group_name = rubs_list[j, 1] + group_name;
                    break;
                  }
                }
                break;
              }
            }
          }
          rez.Add(
            items["id"].ToString(),
            new NaklodnayaClothesItem(){
              Id = items["id"].ToString(),
              IdClothes = items["id_clothes"].ToString(),
              IdNaklad = items["id_naklad"].ToString(),
              Count = items["count"].ToString(),
              Name = items["name"].ToString(),
              GroupName = group_name,
              Price = items["price"].ToString(),
              
            }
            );
          
        }
        return rez;
      }
      return null;
    }
  }
}
