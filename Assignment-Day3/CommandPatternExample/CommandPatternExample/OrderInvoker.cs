using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    class OrderInvoker
    {
        private OrderReceiver receiver;
        private ItemModel item;

        public OrderInvoker()
        {
            receiver = new OrderReceiver();
        }

        public void ExecuteCommand(OrderCommandTypes type,ItemModel item)
        {
            receiver.ExecuteCommand(GetOrderCommand(type), item);
        }

        public void ShowCurrentOrder()
        {
            Console.WriteLine("----------Current Orderz----------------");
            receiver.ShowOrders();
            Console.WriteLine("----------------------------------------");
        }

        public OrderCommand GetOrderCommand(OrderCommandTypes type)
        {
            switch (type)
            {
                case OrderCommandTypes.CreateCommand:
                    return new NewOrderCommand();
                case OrderCommandTypes.ModifyCommand:
                    return new ModifyOrderCommand();
                case OrderCommandTypes.CancelCommand:
                    return new CancelOrderCommand();
                default:
                    return new NewOrderCommand();
            }
        }
    }
}
