using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    public abstract class OrderCommand
    {
        public abstract void Execute(List<ItemModel> orders, ItemModel newItem);
    }
    public class NewOrderCommand : OrderCommand
    {
        public override void Execute(List<ItemModel> orders, ItemModel newItem)
        {
            orders.Add(newItem);
        }
    }

    public class CancelOrderCommand : OrderCommand
    {
        public override void Execute(List<ItemModel> orders, ItemModel newItem)
        {
            orders.Remove(orders.Where(x => x.Name == newItem.Name).First());
        }
    }

    public class ModifyOrderCommand : OrderCommand
    {
        public override void Execute(List<ItemModel> orders, ItemModel newItem)
        {
            var item = orders.Where(x => x.Name == newItem.Name).First();
            item.Quantity = newItem.Quantity;
            item.Name = newItem.Name;
            item.Color = newItem.Color;
        }
    }
}
