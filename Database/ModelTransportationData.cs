using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_GUI_Project_DataBase.FacilityUserControls.Transportation;

namespace Testing_GUI_Project_DataBase.Database
{
    public class ModelTransportationData
    {
        public static List<TransportationItem> trasportationItems { get; set; }

        public void InsertModelTransportationData()
        {
            MyEntireDataRepository context = new MyEntireDataRepository();

            List<TransportationItem> transportationItemslist = new List<TransportationItem>(); 

            var FacilityItems = context.FacilitiesData.ToList();

            foreach(var item in FacilityItems)
            {
                if (item.TypeofFacility == "Transportation")
                {
                    TransportationItem transportationItem = new TransportationItem(item.Name, "f:/1.jpg", item.Description, item.WebSite, item.ContactInformation, item.Address);

                    transportationItemslist.Add(transportationItem);
                }
            }
            trasportationItems = transportationItemslist;
        }
    
        public void setTransportationItems(List<TransportationItem> transportationItemslist)
        {
            trasportationItems = transportationItemslist;
        }
    
    }
}
