using System;

namespace CactusStore.BLL.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CactusId { get; set; }
        public DateTime? Date { get; set; }
    }
}