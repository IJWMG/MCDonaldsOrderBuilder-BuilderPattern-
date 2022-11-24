using System;
using System.Collections.Generic;
using System.Text;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public class Burger : IOrderable
    {
        public int Price { get; init; }

        public string Name { get; init; }
        public Burger(int price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
