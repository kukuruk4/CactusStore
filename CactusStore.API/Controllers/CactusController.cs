using System;
using System.Collections.Generic;
using CactusStore.BLL.DTO;
using CactusStore.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CactusStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CactusController : ControllerBase
    {
        IOrderService orderService;
        public CactusController(IOrderService serv)
        {
            orderService = serv;
        }

        [HttpGet]
        public IEnumerable<CactusDTO> Get()
        {
            return orderService.GetCactuses();
        }

        [HttpGet("{id}")]
        public CactusDTO Get(int id)
        {
            return orderService.GetCactus(id);
        }
    }
    
}
