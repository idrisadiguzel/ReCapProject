using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand : IEntitiy
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
    }
}
