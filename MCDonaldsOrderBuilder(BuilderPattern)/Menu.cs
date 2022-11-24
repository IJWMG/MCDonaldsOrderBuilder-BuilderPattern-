using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public class Menu
    {
        private IMenuLoader _menuLoader;
        public IReadOnlyDictionary<int, IOrderable> MenuList { get; set; } = new Dictionary<int, IOrderable>();

        public Menu(IMenuLoader menuLoader)
        {
            _menuLoader = menuLoader;
            MenuList = _menuLoader.GetMenu();
        }
        public void PrintMenu()
        {
            Console.WriteLine("\t Today's Menu: ");
            foreach (var point in MenuList) {
                Console.WriteLine($"= {point.Key}{point.Value.GetMenuString()} \t =");
            }
        }
    }
}
