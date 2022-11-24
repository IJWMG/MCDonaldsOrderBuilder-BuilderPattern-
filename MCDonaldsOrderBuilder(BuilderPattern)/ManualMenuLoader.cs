using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public class ManualMenuLoader : IMenuLoader
    {
        public IReadOnlyDictionary<int, IOrderable> GetMenu()
        {
                int positionInMenu = 1;
                Dictionary<int, IOrderable> menuToReturn = new Dictionary<int, IOrderable>(){
                { positionInMenu++, new Burger(10, "MC Chicken")},
                { positionInMenu++, new Burger(15, "Big Tasty") },
                { positionInMenu++, new Burger(12, "Big MC") },
                { positionInMenu++, new Burger(8, "Cheeseburger") },
                { positionInMenu++, new FrenchFries(10, "Large French Fries")},
                { positionInMenu++, new FrenchFries(7, "Default French Fries")},
                { positionInMenu++, new FrenchFries(5, "Small French Fries")},
                { positionInMenu++, new SodaDrink(5, "Coce Cola")},
                { positionInMenu++, new SodaDrink(5, "Fanta")},
                { positionInMenu++, new SodaDrink(5, "Sprite")}
            };
                return menuToReturn;
        }
    }
}
