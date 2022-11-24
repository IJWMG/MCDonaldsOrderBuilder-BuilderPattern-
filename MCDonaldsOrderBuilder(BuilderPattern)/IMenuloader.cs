using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public interface IMenuLoader
    {
        public IReadOnlyDictionary<int, IOrderable> GetMenu();
    }
}
