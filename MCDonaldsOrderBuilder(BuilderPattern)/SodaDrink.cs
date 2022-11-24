using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public class SodaDrink : IOrderable
    {
    public int Price { get; init; }

    public string Name { get; init; }
        public SodaDrink(int price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
