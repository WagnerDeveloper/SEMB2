using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Methods
{
    public class RealState
    {
        public string Address { get; set; }
        public int Price { get; set; }
        public int SquareFootage { get; set; }
        // public int CalculatePricePerSquareFoot() => Price / SquareFootage;
        public int CalculatePricePerSquareFoot(){
            return Price / SquareFootage;
        }
    }
}