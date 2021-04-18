using System;
using CactusStore.Domain.Contracts;

namespace CactusStore.Domain.Models
{
    public class CactusUpdateModel : ICactusIdentity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
    }
}
