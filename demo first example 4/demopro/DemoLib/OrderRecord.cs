using Google.Protobuf.WellKnownTypes;
using System;
using System.ComponentModel;

namespace DemoLib
{
    public class OrderRecord
    {
        [DisplayName("Товар")]
        public string NameProduct { get; set; }

        [DisplayName("Дата заказа")]
        public DateTime SaleDate { get; set; }

        [DisplayName("Цена")]
        public double Price { get; set; }

        [DisplayName("Количество")]
        public int Count { get; set; }


        private double _manualCost;

        [DisplayName("Стоимость")]
        public double Cost
        {
            get 
            { 
                if(NameProduct == "Итого")
                {
                    return _manualCost;
                } 
                
                return Price * Count; 
            }
            set
            {
                if (NameProduct == "Итого")
                {
                    _manualCost = value; // Сохраняем значение для итоговой строки
                }
            }

        }
    }
}
