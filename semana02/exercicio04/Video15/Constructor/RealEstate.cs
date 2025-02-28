using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructor
{
    public class RealEstate
    {
        private string address;

        public RealEstate(string _address){
            Console.WriteLine("First Run");
            address = _address;
        }

        public string Address { get { return address; } set { address = value; } }


    }
}