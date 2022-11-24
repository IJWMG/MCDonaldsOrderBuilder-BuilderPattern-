using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDonaldsOrderBuilder_BuilderPattern_
{
    public static class StringFormater
    {
        private static int _lastLineTabs;
        public static string FormatNameToOrder(string stringToFormat) 
        { 
            StringBuilder stringToReturn = new StringBuilder(stringToFormat);
            int linesCounter = stringToReturn.Length / 12;
            _lastLineTabs = (stringToReturn.Length % 12) / 4;
            FormatLowerLine(ref stringToReturn);
            if (linesCounter == 1 && (stringToReturn.Length % 12) == 0)
            {
                stringToReturn.Append("\t");
                FinalFormatToOrder(ref stringToReturn);
                return stringToReturn.ToString();
            }
            else  
            {               
                for (int i = linesCounter; i >= 1 ; i--)
                {
                    stringToReturn.Insert((i * 12), "\t\t\t = \n= \t");
                }
            }
            FinalFormatToOrder(ref stringToReturn);
            return stringToReturn.ToString();
        }
        public static string FormatNameToFinalOrderBill(string stringToFormat)
        {
            StringBuilder stringToReturn = new StringBuilder(FormatNameToOrder(stringToFormat));
            stringToReturn.Replace("=", "==");
            return stringToReturn.ToString();
        }
        private static void FinalFormatToOrder(ref StringBuilder s) => s.Insert(0, "\t").Append("\t");
        private static void FormatLowerLine(ref StringBuilder s) 
        {
            if (s.Length % 12 != 0)
            {
                for (int i = _lastLineTabs; i < 3; i++)
                {
                    s.Append("\t");
                }
            }
        }
    }
}
