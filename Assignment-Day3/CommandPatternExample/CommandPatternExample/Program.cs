using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderInvoker user = new OrderInvoker();
            ItemModel item1 = new ItemModel() { Name = "IPhone", Quantity = 1, Color = "Silver" };
            ItemModel item2 = new ItemModel() { Name = "WebCam", Quantity = 2, Color = "Black" };
            ItemModel item3 = new ItemModel() { Name = "IPhone", Quantity = 1, Color = "Red" };

            Console.WriteLine("place an order for "+item1.Name);
            user.ExecuteCommand(OrderCommandTypes.CreateCommand,item1);
            Console.WriteLine("place another order for " + item2.Name);
            user.ExecuteCommand(OrderCommandTypes.CreateCommand, item2);
            user.ShowCurrentOrder();


            Console.WriteLine("cancel  order for " + item2.Name);
            user.ExecuteCommand(OrderCommandTypes.CancelCommand, item2);
            user.ShowCurrentOrder();

            Console.WriteLine("Modify order for " + item1.Name);
            user.ExecuteCommand(OrderCommandTypes.ModifyCommand,item3);
            user.ShowCurrentOrder();
            Console.ReadKey();
        }
    }
}
