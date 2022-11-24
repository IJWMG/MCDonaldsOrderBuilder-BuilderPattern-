using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public class BaseOrderDirector
    {
        private IOrderBuilder _builder;
        private Menu _menu;

        public BaseOrderDirector(IOrderBuilder builder, Menu menu) 
        {
            _builder = builder;
            _menu = menu;
        }
        public void MakeOrderWithArray(int[] menuNumbers)
        {
            foreach(var orderable in menuNumbers)
            {
                if (_menu.MenuList.ContainsKey(orderable)) {
                    _builder.AddToOrder(_menu.MenuList[orderable]);
                }
                else
                {
                    Console.WriteLine($"Invalid number in order: {orderable}, order will be formed without it");
                    continue;
                }
            }
        }
        public string GetFinalOrder()
        {
           return _builder.GetFinalOrder();
        }
    }
}
