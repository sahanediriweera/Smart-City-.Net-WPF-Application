using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_GUI_Project_DataBase
{
    public class Citizen
    {
        public int CitizenId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PassWord { get; set; }

        public string Email { get; set; }

        public string ContactInfo { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Forum> Forums { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }

        public Citizen(string firstName, string lastName, string passWord, string email, string contactInfo, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            PassWord = passWord;
            Email = email;
            ContactInfo = contactInfo;
            Address = address;
            this.Forums = new List<Forum>();
            this.Facilities = new List<Facility>();
        }

        public Citizen()
        {
        }
    }
}
