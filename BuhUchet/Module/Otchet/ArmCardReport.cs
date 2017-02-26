using BuhUchet;
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
            UpdateCell("", 12, "C");
            UpdateCell(armCardItem.Fio, 13, "C");

            
        }

        public void AddItems() {
            for (int i = 0; i < armCardItem.Items.Count; i++) {
                var j = 2*i + 17;

                UpdateCell(armCardItem.Fio, 13, "C");
            }
        }

    }
}
