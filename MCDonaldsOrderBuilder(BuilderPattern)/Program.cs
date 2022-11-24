using System;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MCDonald's Order builder!");
            Menu menu = new Menu(new ManualMenuLoader());
            menu.PrintMenu();
            BaseOrderDirector director = new BaseOrderDirector( new OrderBuilder(), menu);
            Console.WriteLine("\n\nInsert numbers of goods to order them");
            int[] orderNumbers = InputManager.GetIntArrayFromInput();
            director.MakeOrderWithArray(orderNumbers);
            Console.WriteLine(director.GetFinalOrder());
        }
    }
}
