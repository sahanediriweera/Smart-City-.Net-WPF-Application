using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_GUI_Project_DataBase.Database;
using Testing_GUI_Project_DataBase.FacilityUserControls.Business;
using Testing_GUI_Project_DataBase.FacilityUserControls.Healthcare;
using Testing_GUI_Project_DataBase.FacilityUserControls.HotelandFood;
using Testing_GUI_Project_DataBase.FacilityUserControls.Transportation;
using Testing_GUI_Project_DataBase.TheForum;

namespace Testing_GUI_Project_DataBase.StartUp
{
    public class InitializeProgramme
    {
        public void enableFacilities()
        {
            MyEntireDataRepository context = new MyEntireDataRepository();

            var facilities = context.FacilitiesData.ToList();

            List<BusinessItem> businessItems = new List<BusinessItem>();

            List<HealthcareItem> healthcareItems = new List<HealthcareItem>();

            List<HotelandFoodItem> hotelandFoodItems = new List<HotelandFoodItem>();

            List<TransportationItem> transportationItems = new List<TransportationItem>();

            foreach(var item in facilities)
            {
                if (item.TypeofFacility == "BUSINESS") {
                    BusinessItem businessItem = new BusinessItem(item.Name, "f:/1.jpg", item.Description, item.WebSite, item.ContactInformation, item.Address);
                    businessItems.Add(businessItem);
                }

                if(item.TypeofFacility == "HEALTHCARE") {
                    HealthcareItem healthcareItem = new HealthcareItem(item.Name, "f:/1.jpg", item.Description, item.WebSite, item.ContactInformation, item.Address);
                    healthcareItems.Add(healthcareItem);
                }

                if(item.TypeofFacility == "HOTELANDFOOD") {
                    HotelandFoodItem hotelandFoodItem = new HotelandFoodItem(item.Name, "f:/1.jpg", item.Description, item.WebSite, item.ContactInformation, item.Address);
                    hotelandFoodItems.Add(hotelandFoodItem);
                }

                if(item.TypeofFacility == "TRANSPORTATION") {
                    TransportationItem transportationItem = new TransportationItem(item.Name, "f:/1.jpg", item.Description, item.WebSite, item.ContactInformation, item.Address);
                    transportationItems.Add(transportationItem);
                }
            }


            ModelBusinessData.businessItems = businessItems;

            ModelHealthCareData.healthcareItems = healthcareItems;

            ModelHotelandFoodData.HotelandFoodItems = hotelandFoodItems;

            ModelTransportationData.trasportationItems = transportationItems;
        }
    
        public void enableForumData()
        {
            List<ForumModel> ForumItem = new List<ForumModel>();

            MyEntireDataRepository context = new MyEntireDataRepository();

            var ForumItemsData = context.ForumsData.ToList();

            List<ForumModel> forumItems = new List<ForumModel>();

            foreach (var item in ForumItemsData)
            {
                ForumModel forumItem = new ForumModel(item.citizen.FirstName, item.citizen.LastName, item.Idea);

                forumItems.Add(forumItem);

            }

            ModelForumData.ForumItems = ForumItem;
        }
    
    }
}
