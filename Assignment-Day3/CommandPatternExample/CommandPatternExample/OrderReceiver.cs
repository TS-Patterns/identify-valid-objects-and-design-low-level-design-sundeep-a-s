using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    class OrderReceiver
    {
        public List<ItemModel> Orders { get; set; }

        public OrderReceiver()
        {
            Orders = new List<ItemModel>();
        }

        public void ExecuteCommand(OrderCommand command, ItemModel item)
        {
            command.Execute(this.Orders, item);
        }

        public void ShowOrders()
        {
            foreach (var item in Orders)
            {
                item.DisplayItem();
            }
        }
    }
}
