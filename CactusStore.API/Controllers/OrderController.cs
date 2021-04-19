using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CactusStore.BLL.DTO;
using CactusStore.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;



namespace CactusStore.API.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        IOrderService orderService;
        public OrderController(IOrderService serv)
        {
            orderService = serv;
        }

        // POST api/order
        [HttpPost]
        public void Post([FromBody] OrderDTO newOrder)
        {
            orderService.MakeOrder(newOrder);
        }
    }
}
