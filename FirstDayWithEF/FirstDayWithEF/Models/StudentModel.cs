using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayWithEF.Models
{
    public class StudentModel
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string StreetAddress { get; set; }


        public string ImageUrl { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
    }
}
