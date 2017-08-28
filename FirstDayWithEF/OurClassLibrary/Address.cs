using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClassLibrary
{
    public class Address
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string streetAddress;

        public string StreeAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }
        private City city;

        public City City
        {
            get { return city; }
            set { city = value; }
        }


    }
}
