using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderService.Models;

namespace OrderService.Repository
{
    public interface IOrderRepository
    {
        public IEnumerable<Cart> GetById(int user_id);
        List<Cart> Order(Cart entity);
    }
}
