using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationEntities.Products;

namespace ApplicationEntities.Mobiles
{
    public class Mobile
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int ram;

        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        private int rom;

        public int Rom
        {
            get { return rom; }
            set { rom = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private string operatingSystem;

        public string OperatingSystem
        {
            get { return operatingSystem; }
            set { operatingSystem = value; }
        }
        private Product product;

        public virtual Product Product
        {
            get { return product; }
            set { product = value; }
        }

    }
}
