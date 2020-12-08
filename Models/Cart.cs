using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public int menuItemId { get; set; }
        public string MenuItemName { get; set; }
    }
}
