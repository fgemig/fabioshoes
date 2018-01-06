using FabioShoes.Core.Models;
using System;
using System.Collections.Generic;

namespace FabioShoes.Core.Interfaces
{
    public interface IShoeRepository : IDisposable
    {
        IEnumerable<Shoe> GetShoes();
        void Add(Shoe shoe);
    }
}
