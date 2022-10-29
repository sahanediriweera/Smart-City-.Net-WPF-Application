using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_GUI_Project_DataBase
{
    public class School
    {
        public int SchoolId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string ContactNo { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public School( string name, string email, string address, string contactNo)
        {
            Name = name;
            Email = email;
            Address = address;
            ContactNo = contactNo;
            this.Students = new List<Student>();
        }

        public School()
        {
        }
    }
}
