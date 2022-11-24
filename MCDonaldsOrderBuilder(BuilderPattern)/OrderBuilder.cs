using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public class OrderBuilder : IOrderBuilder
    {
        private StringBuilder _resultString = new StringBuilder();
        private int _totalPrice = 0;
        public OrderBuilder()
        {
            Random random= new Random();
            _resultString.Append($"\n\t Order #{random.Next()} \n Your Order: \n\n Name of good: \t\t prise:\n");
        }

        public IOrderBuilder AddToOrder(IOrderable orderable)
        {
            _resultString.Append("== " + orderable.GetOrderString() + "$\t == \n");
            _totalPrice += orderable.Price;
            return this;
        }

        public string GetFinalOrder()
        {
            _resultString.Append("------------------------------------------------------\n");
            _resultString.Append($"\nTotalPrice: \t\t {_totalPrice} $ \n\nThank you for choosing us!");
            StringBuilder temp = _resultString;
            _totalPrice = 0;
            _resultString = new();
            return temp.ToString();
        }
    }
}
