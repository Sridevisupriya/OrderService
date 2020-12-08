using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderService.Models;

namespace OrderService.Repository
{
    public class OrderRepository : IOrderRepository
    {
        List<Cart> item_list = new List<Cart>();
        public OrderRepository()
        {
            item_list.Add(new Cart { Id = 1, userId = 1, menuItemId = 1, MenuItemName = "FrenchFries" });
            item_list.Add(new Cart { Id = 2, userId = 2, menuItemId = 2, MenuItemName = "Biryani" });
            item_list.Add(new Cart { Id = 3, userId = 1, menuItemId = 3, MenuItemName = "Salad" });
            item_list.Add(new Cart { Id = 4, userId = 2, menuItemId = 4, MenuItemName = "Chicken" });

        }
        public List<Cart> Order(Cart entity)
        {
            item_list.Add(entity);
            return item_list;
        }

        public IEnumerable<Cart> GetById(int user_id)
        {
            List<Cart> bl = new List<Cart>();
            foreach (var item in item_list)
            {
                if (item.userId == user_id)
                {
                    bl.Add(item);
                }
            }
            return bl;
        }
    }
}
