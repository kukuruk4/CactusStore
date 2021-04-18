using System.Collections.Generic;
using CactusStore.BLL.DTO;

namespace CactusStore.BLL.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(OrderDTO orderDto);
        CactusDTO GetCactus(int? id);
        IEnumerable<CactusDTO> GetCactuses();
        void Dispose();
    }
}