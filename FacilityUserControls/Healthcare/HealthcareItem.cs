using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_GUI_Project_DataBase.FacilityUserControls.Healthcare
{
    public class HealthcareItem
    {
        public string Name { get; set; }

        public string Photoaddress { get; set; }

        public string Description { get; set; }

        public string Website { get; set; }

        public string ContactInfo { get; set; }

        public string Address { get; set; }

        public HealthcareItem(string name, string photoaddress, string description, string website, string contactInfo, string address)
        {
            Name = name;
            Photoaddress = photoaddress;
            Description = description;
            Website = website;
            ContactInfo = contactInfo;
            Address = address;
        }
    }
}
