using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car : IEntitiy
    {
        public int Id{ get; set; }
        public int BrandId{ get; set; }
        public int ColorId{ get; set; }
        public string CarName{ get; set; }
        public int ModelYear{ get; set; }
        public int DailyPrice{ get; set; }
        public string Description{ get; set; }

    }
}
