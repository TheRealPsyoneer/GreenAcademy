using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreIT11._6
{
    public class Item
    {
        public string Name { get; init; }
        public string Code { get; init; }
        int quantity;
        public int Quantity 
        {
            get => quantity;
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }
        int price;
        public int Price
        {
            get => price;
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
    }
}
