using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public static class InputManager
    {
        public static int[] GetIntArrayFromInput()
        {
            try
            {
                return RecursionInputGet();
           
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        private static int[] RecursionInputGet()
        {
            List<int> listToReturn = new List<int>();
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input.Trim())) { return null; }
            string[] piecesOfOrder = input.Split(' ', ',', '.', '/', ';', '-');
            foreach (string piece in piecesOfOrder)
            {
                if (string.IsNullOrEmpty(piece)) continue;
                if (int.TryParse(piece, out int menuNumber))
                { 
                    if(menuNumber < 0) 
                    {
                        InvalidExpressionSignal(menuNumber.ToString());
                        continue;
                    }
                    listToReturn.Add(menuNumber);
                }
                else
                {
                    InvalidExpressionSignal(piece);
                }
            }
            return listToReturn.ToArray();
        }
        private static void InvalidExpressionSignal(string expression)
        {
            Console.WriteLine($"Incorrect value {expression} \n Order will be formed without it");

        }
    }
}
