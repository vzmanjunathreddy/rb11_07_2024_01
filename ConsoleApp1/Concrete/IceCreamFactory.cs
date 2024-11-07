using ConsoleApp1.Interface;
using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    public class IceCreamFactory : IIceCreamFactory
    {
        public IceCreamModel GetObject()
        {
            return new();
        }

        public IceCreamModel GetObject(IceCreamModel iceCreamData)
        {
            return new()
            {
                Id  = iceCreamData.Id,
                Name = iceCreamData.Name,
                TypeIceCream = iceCreamData.TypeIceCream
            };
        }
    }
}
