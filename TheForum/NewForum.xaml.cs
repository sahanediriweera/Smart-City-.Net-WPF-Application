using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Testing_GUI_Project_DataBase.Database;

namespace Testing_GUI_Project_DataBase.TheForum
{
    /// <summary>
    /// Interaction logic for NewForum.xaml
    /// </summary>
    public partial class NewForum : UserControl
    {
        public NewForum()
        {
            InitializeComponent();


            listviewForum.ItemsSource = GetForumDetails();
        }

        private List<ForumModel> GetForumDetails()
        {
            return new List<ForumModel>() {
                new ForumModel("firstName","LasghggghghtName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas"),
                new ForumModel("firstName","LastName","SomeIdeas")
            };
        }
    }
}
