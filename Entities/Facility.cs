using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_GUI_Project_DataBase
{
    public class Facility
    {
        public int FacilityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string WebSite { get; set; }

        public string Email { get; set; }

        public string ContactInformation { get; set; }

        public string Address { get; set; }

        public string TypeofFacility { get; set; }

        public virtual Citizen citizen { get; set; }

        public Facility( string name, string description, string webSite, string email, string contactInformation, string address)
        {
            Name = name;
            Description = description;
            WebSite = webSite;
            Email = email;
            ContactInformation = contactInformation;
            Address = address;
        }

        public Facility()
        {
        }
    }
}
