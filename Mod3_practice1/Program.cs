using System;
using System.Globalization;

namespace Mod3_practice1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter s = new ();
            s.Display();
            var c = new Culture();
            var contact = new Contact();
            var cultureRu = new CultureInfo("ru_RU");
            string r = cultureRu.DisplayName;
            var cultureEn = new CultureInfo("en_US");
            string e = cultureEn.DisplayName;
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
