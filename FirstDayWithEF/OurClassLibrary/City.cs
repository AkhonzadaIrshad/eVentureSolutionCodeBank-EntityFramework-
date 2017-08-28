using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClassLibrary
{
    public class City
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        private Country coutry;

        public Country Country
        {
            get { return coutry; }
            set { coutry = value; }
        }

    }
}
