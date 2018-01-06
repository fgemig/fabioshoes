using FabioShoes.Core.Models;
using System;
using System.Collections.Generic;

namespace FabioShoes.Core.Interfaces
{
    public interface IShoeService
    {
        IEnumerable<Tuple<Shoe, Shoe>> SortOut(IEnumerable<Shoe> shoes);
    }
}
