using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_GUI_Project_DataBase.Tempory
{
    class Product
    {
        public string Name { get; set; }

        public double Value { get; set; }

        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
