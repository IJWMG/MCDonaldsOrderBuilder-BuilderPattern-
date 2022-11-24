using System;
using System.Collections.Generic;
using System.Text;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public interface IOrderBuilder
    {
        public IOrderBuilder AddToOrder(IOrderable orderable);
        public string GetFinalOrder();
    }
}
