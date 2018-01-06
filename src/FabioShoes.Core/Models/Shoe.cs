using FabioShoes.Core.Enums;

namespace FabioShoes.Core.Models
{
    public class Shoe
    {        
        public Shoe(int size, ShoeSide side)
        {
            this.Size = size;
            this.Side = side;
        }

        public int Size { get; private set; }

        public ShoeSide Side { get; private set; }        

        public static Shoe Create(int size, ShoeSide side) 
            => new Shoe(size, side);       
    }
}
