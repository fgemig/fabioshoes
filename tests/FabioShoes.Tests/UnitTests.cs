using Microsoft.VisualStudio.TestTools.UnitTesting;
using FabioShoes.Core.Enums;
using FabioShoes.Core.Models;
using System.Linq;
using FabioShoes.Core.Repository;
using FabioShoes.Core.Services;
using FabioShoes.Core.Interfaces;

namespace FabioShoes.Tests
{
    [TestClass]
    public class ShoesTests
    {       
        private readonly IShoeService _service;

        public ShoesTests()
        {
            _service = new ShoeService();
        }

        [TestMethod]
        public void ShouldReturnANonePairOfShoes()
        {
            using (IShoeRepository _stock = new ShoeRepository())
            {               
                var result = _service.SortOut(_stock.GetShoes());
                Assert.AreEqual(0, result.Count());
            }         
        }      

        [TestMethod]
        public void ShouldReturnTwoPairOfShoes()
        {
            using (IShoeRepository _stock = new ShoeRepository())
            {
                _stock.Add(Shoe.Create(38, ShoeSide.RIGHT));
                _stock.Add(Shoe.Create(38, ShoeSide.LEFT));
                _stock.Add(Shoe.Create(39, ShoeSide.LEFT));
                _stock.Add(Shoe.Create(40, ShoeSide.RIGHT));
                _stock.Add(Shoe.Create(40, ShoeSide.LEFT));

                var result = _service.SortOut(_stock.GetShoes());

                Assert.AreEqual(2, result.Count());
            }
        }
    }
}