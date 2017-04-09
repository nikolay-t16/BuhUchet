using BuhUchet;
using BuhUchet.Module.Order.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ArmCard {
    class ArmCardReport : MakeExcelReport {
        protected string ExampleFile = @"armCard.xlsx";

        public OrderItem armCardItem;
        public ArmCardReport(OrderItem armCard)
        {
            armCardItem = armCard;
        }

        public void CreateArmCard() {
            OpenFile(ExampleFile);
            UpdateCell("АРМАТУРНАЯ КАРТОЧКА № " + armCardItem.Id, 4, "C");
            UpdateCell(armCardItem.Date, 8, "A");
            UpdateCell(armCardItem.Fio, 12, "C");
            UpdateCell(armCardItem.Child.RazmerOdegdy, 11, "G");
            UpdateCell(armCardItem.Child.RazmerObuvy, 11, "I");
            UpdateCell(armCardItem.Child.RazmerGolavy, 11, "K");
            AddItems();
            
        }

        public void AddItems() {
          for (var i = 0; i < armCardItem.Items.Count; i++)
          {
            var it = armCardItem.Items[i];
            UpdateCell((i+1).ToString(), (UInt32)(17 + 2 * i + 1), "A");
            
            UpdateCell(it.Clothes.ParentName, (UInt32)(17 + 2 * i), "B");
            UpdateCell(it.Clothes.Name, (UInt32)(17 + 2 * i + 1), "B");
            UpdateCell(it.Clothes.SrokNoski, (UInt32)(17 + 2 * i), "C");
            UpdateCell(it.Clothes.NormaVidachi, (UInt32)(17 + 2 * i), "D");
            ;
            UpdateCell(RuDateAndMoneyConverter.NumeralsToTxt((long)Convert.ToInt32(it.Count), TextCase.Accusative, false, false), (UInt32)(17 + 2 * i + 1), "E");
          }
        }

    }
}
