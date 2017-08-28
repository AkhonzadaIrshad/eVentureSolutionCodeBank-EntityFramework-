using System;
using System.ComponentModel.DataAnnotations;
namespace FirstDayWithEntityFramework
{
    class Student
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;


       // [Range(8,30)]
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

        private double fee;

        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        private int? rollNumber;
       // [Key]
        public int? RollNumber
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

    }
}