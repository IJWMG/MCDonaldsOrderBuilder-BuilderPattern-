using System;
using System.Collections.Generic;
using System.Text;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public interface IOrderable
    {
        public int Price { get; }
        public string Name { get; }
        public string GetMenuString()
        {
            return StringFormater.FormatNameToOrder(Name) + Price.ToString();
        }
        public string GetOrderString()
        {
            return StringFormater.FormatNameToFinalOrderBill(Name) + Price.ToString();
        }
    }
}
