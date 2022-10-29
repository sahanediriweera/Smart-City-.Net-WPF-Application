using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_GUI_Project_DataBase.FacilityUserControls.Business;

namespace Testing_GUI_Project_DataBase.Database
{
    public class ModelBusinessData
    {
        public static List<BusinessItem> businessItems { get; set; }

        public void  InsertModelBusinessData()
        {
            MyEntireDataRepository context = new MyEntireDataRepository();

            businessItems = new List<BusinessItem>();

            List<BusinessItem> businessItemsList = new List<BusinessItem>();

            var facilities = context.FacilitiesData.ToList();

            foreach(var item in facilities)
            {
                if (item.TypeofFacility == "BUSINESS")
                {
                    BusinessItem businessItem = new BusinessItem(item.Name, "f:/1.jpg", item.Description, item.WebSite, item.ContactInformation, item.Address);
                    businessItemsList.Add(businessItem);
                }
            }

            businessItems = businessItemsList;
        }

        public List<BusinessItem> GetBusinessItems()
        {
            return businessItems;
        }

        public void setBusinessItems(List<BusinessItem> businessItemsList)
        {
            businessItems = businessItemsList;
        }
    }
}
