using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClassLibrary
{
    public class Student
    {


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        private string imageUrl;

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }




        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string fatherName;

        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }

        private int rollNumber;

        public int RollNumber
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }




    }
}
