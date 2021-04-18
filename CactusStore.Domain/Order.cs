using System;
namespace CactusStore.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public int CactusId { get; set; }
        public Cactus Cactus { get; set; }

        public DateTime Date { get; set; }
    }
}
