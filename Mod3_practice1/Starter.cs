using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod3_practice1
{
    public class Starter
    {
        public Starter()
        {
            ContList = new List<Contact>()
            {
                new Contact("Bill", "Black", "322-22-33"),
                new Contact("Ann", "Fowley", "233-22-33"),
                new Contact("Tom", "White", "433-44-33"),
                new Contact("Bob", "Marley", "544-44-33"),
                new Contact("Alice", "Cooper", "533-66-43"),
                new Contact("Tod", "Ghill", "539-32-45"),
            };
        }

        public List<Contact> ContList { get; set; }
        private List<Contact> Temp { get; set; }
        public void Display()
        {
            Temp = ContList;
            Console.WriteLine("Original List");
            foreach (var item in Temp)
            {
                Console.WriteLine(item.Display());
            }

            Console.WriteLine("\nSorted List");
            Temp.Sort();
            foreach (var item in Temp)
            {
                Console.WriteLine(item.Display());
            }

            Console.WriteLine("\nCategorized List");

            while (Temp.Count > 0)
            {
                string item = Temp[0].FirstName;
                string str = item.Substring(0, 1);
                Console.WriteLine(str);
                List<Contact> list = new List<Contact>();
                foreach (var it in Temp)
                {
                    string item2 = it.FirstName;
                    string str2 = item2.Substring(0, 1);
                    if (str == str2)
                    {
                        list.Add(it);
                    }
                }

                foreach (var i in list)
                {
                    Console.WriteLine(i.Display());
                    if (Temp.Contains(i))
                    {
                        Temp.Remove(i);
                    }
                }

                list.Clear();
                Console.WriteLine();
            }
        }
    }
}
