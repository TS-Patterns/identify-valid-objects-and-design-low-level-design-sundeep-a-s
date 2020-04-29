using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    public class ItemModel
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public String Color { get; set; }

        public void DisplayItem()
        {
            Console.WriteLine("Item->");
            Console.WriteLine("\tName:" + Name);
            Console.WriteLine("\tQuantity:" + Quantity);
            Console.WriteLine("\tColor:" + Color);
        }
    }
}
