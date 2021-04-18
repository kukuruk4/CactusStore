using System;
using System.Collections.Generic;
using AutoMapper;
using CactusStore.BLL.BusinessModels;
using CactusStore.BLL.DTO;
using CactusStore.BLL.Infrastructure;
using CactusStore.BLL.Interfaces;
using CactusStore.DAL.Interfaces;
using CactusStore.DAL.Entities;

namespace CactusStore.BLL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void MakeOrder(OrderDTO orderDto)
        {
            Cactus cactus = Database.Cactuses.Get(orderDto.CactusId);

            if (cactus == null)
                throw new ValidationException("Растение не найдено", "");
            
            decimal sum = new Discount(0.1m).GetDiscountedPrice(cactus.Price);
            Order order = new Order
            {
                Date = DateTime.Now,
                Address = orderDto.Address,
                CactusId = cactus.Id,
                Sum = sum,
                PhoneNumber = orderDto.PhoneNumber
            };
            Database.Orders.Create(order);
            Database.Save();
        }

        public IEnumerable<CactusDTO> GetCactuses()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Cactus, CactusDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Cactus>, List<CactusDTO>>(Database.Cactuses.GetAll());
        }

        public CactusDTO GetCactus(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id растения", "");
            var cactus = Database.Cactuses.Get(id.Value);
            if (cactus == null)
                throw new ValidationException("Растение не найдено", "");

            return new CactusDTO { Country = cactus.Country, Id = cactus.Id, Name = cactus.Name, Price = cactus.Price };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}