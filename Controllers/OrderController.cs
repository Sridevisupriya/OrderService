using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Repository;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _IOrderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this._IOrderRepository = orderRepository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var bookinglist = _IOrderRepository.GetById(id);
                return new OkObjectResult(bookinglist);

            }
            catch
            {
                return new NoContentResult();
            }
        }

        [HttpPost]
        public IActionResult PostOrderItem(Cart model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                     _IOrderRepository.Order(model);
                      return CreatedAtAction(nameof(PostOrderItem), new { id = model.Id}, model);

                   
                }
                return BadRequest();

            }
            catch
            {
                return new NoContentResult();
            }

        }

    }
}