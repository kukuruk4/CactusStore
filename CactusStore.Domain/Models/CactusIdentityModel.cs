using System;
using CactusStore.Domain.Contracts;

namespace CactusStore.Domain.Models
{
    public class CactusIdentityModel : ICactusIdentity
    {
        public int Id { get; }

        public CactusIdentityModel(int id)
        {
            this.Id = Id;
        }
    }
}
