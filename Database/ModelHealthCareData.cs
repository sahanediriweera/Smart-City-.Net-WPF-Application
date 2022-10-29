using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_GUI_Project_DataBase.FacilityUserControls.Healthcare;

namespace Testing_GUI_Project_DataBase.Database
{
    public class ModelHealthCareData
    {
       public static List<HealthcareItem> healthcareItems { get; set; }

        public void InsertModelHealthCareData()
        {
            MyEntireDataRepository context = new MyEntireDataRepository();

            List<HealthcareItem> healthcareItemslist = new List<HealthcareItem>();

            var FacilityItems = context.FacilitiesData.ToList();

            foreach(var item in FacilityItems)
            {
                if (item.TypeofFacility == "Healthcare")
                {
                    HealthcareItem healthcareItem = new HealthcareItem(item.Name, "f:1.jpg", item.Description, item.WebSite, item.ContactInformation, item.Address);
                    healthcareItemslist.Add(healthcareItem);
                }
            }

            healthcareItems = healthcareItemslist;
        }

        public void setHealthcareItems(List<HealthcareItem> healthcareItemslist)
        {
            healthcareItems = healthcareItemslist;
        }
    
    
    }
}
