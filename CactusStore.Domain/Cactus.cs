using System;
using System.Collections.Generic;

namespace CactusStore.Domain
{
    public class Cactus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
