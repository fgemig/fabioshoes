using FabioShoes.Core.Interfaces;
using FabioShoes.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FabioShoes.Core.Repository
{
    public class ShoeRepository : IShoeRepository
    {
        private readonly IList<Shoe> _shoes;

        public ShoeRepository() 
            => _shoes = new List<Shoe>();
      
        public void Add(Shoe shoe)
             => _shoes.Add(shoe);

        public IEnumerable<Shoe> GetShoes() =>
            _shoes.ToList();

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_shoes != null)
                    _shoes.Clear();
            }
        }

        #endregion
    }
}
