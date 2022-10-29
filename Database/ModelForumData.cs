using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_GUI_Project_DataBase.TheForum;

namespace Testing_GUI_Project_DataBase.Database
{
    public class ModelForumData
    {
        
        public static List<ForumModel> ForumItems { get; set; }

        public void InsertModelForumData()
        {
            MyEntireDataRepository context = new MyEntireDataRepository();

            var ForumItemsData = context.ForumsData.ToList();

            List<ForumModel> forumItems = new List<ForumModel>();

            foreach(var item in ForumItemsData)
            {
                ForumModel forumModel = new ForumModel( item.citizen.FirstName, item.citizen.LastName, item.Idea);

                forumItems.Add(forumModel);

            }

            ForumItems = forumItems;
        }

        
    }
}
