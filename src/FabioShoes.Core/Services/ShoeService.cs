using FabioShoes.Core.Enums;
using FabioShoes.Core.Interfaces;
using FabioShoes.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FabioShoes.Core.Services
{
    public class ShoeService : IShoeService
    {
        public IEnumerable<Tuple<Shoe, Shoe>> SortOut(IEnumerable<Shoe> shoes)
        {
            return shoes
               .GroupBy(t => t.Size)
               .SelectMany(n =>
                   Enumerable.Zip(
                       n.Where(l => l.Side == ShoeSide.LEFT),
                       n.Where(l => l.Side == ShoeSide.RIGHT),
                       Tuple.Create
                   )
               );
        }
    }
}
