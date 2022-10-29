using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_GUI_Project_DataBase.FacilityUserControls.HotelandFood;

namespace Testing_GUI_Project_DataBase.Database
{
    public class ModelHotelandFoodData
    {
        public static List<HotelandFoodItem> HotelandFoodItems { get; set; }

        public void InsertModelHotelandFoodData()
        {
            MyEntireDataRepository context = new MyEntireDataRepository();

            List<HotelandFoodItem> hotelandFoodItemslist = new List<HotelandFoodItem>();

            var FacilityItems = context.FacilitiesData.ToList();

            foreach(var item in FacilityItems)
            {
                if (item.TypeofFacility == "HotelandFood")
                {
                    HotelandFoodItem hotelandFoodItem = new HotelandFoodItem(item.Name, "f:/1.jpg", item.Description, item.WebSite, item.ContactInformation, item.Address);
                    hotelandFoodItemslist.Add(hotelandFoodItem);
                }
            }

            HotelandFoodItems = hotelandFoodItemslist;
        
        }
    
        public void setHotelandFoodItems(List<HotelandFoodItem> hotelandFoodItemslist)
        {
            HotelandFoodItems = hotelandFoodItemslist;
        }
    
    
    }
}
