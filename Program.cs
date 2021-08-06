using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataSource.CreateData();

            foreach (Book b in DataSource.Books)
            { 
                Console.WriteLine(b.ItemTitle);
            }

            foreach (ItemType t in DataSource.ItemTypes)
            {
                Console.WriteLine(t.ItemTypeName);
            }

        }
    }
}
