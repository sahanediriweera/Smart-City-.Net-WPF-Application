using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Testing_GUI_Project_DataBase.Database;
using Testing_GUI_Project_DataBase.FacilityUserControls;
using Testing_GUI_Project_DataBase.FacilityUserControls.Business;
using Testing_GUI_Project_DataBase.StartUp;
using Testing_GUI_Project_DataBase.FacilityUserControls.Healthcare;
using Testing_GUI_Project_DataBase.FacilityUserControls.HotelandFood;
using Testing_GUI_Project_DataBase.FacilityUserControls.Transportation;
using Testing_GUI_Project_DataBase.TheForum;
using Testing_GUI_Project_DataBase.Forums;

namespace Testing_GUI_Project_DataBase
{
    /// <summary>
    /// Interaction logic for NewMainWindow.xaml
    /// </summary>
    public partial class NewMainWindow : Window

    {


        public NewMainWindow()
        {
            InitializeProgramme initializeProgramme = new InitializeProgramme();
            initializeProgramme.enableFacilities();
            initializeProgramme.enableForumData();
            InitializeComponent();

            adjusttoUser();
        }

        private void adjusttoUser()
        {
            if (LoggedInUserData.IsCitizen)
            {
                CitizenloggedIn();
            }
            else
            {
                StudentLoggedIn();
            }
        }

        private void StudentLoggedIn()
        {
            AddSchool.Visibility = Visibility.Hidden;
            AddFacilityBtn.Visibility = Visibility.Hidden;
        }

        private void CitizenloggedIn()
        {
            SchoolBtn.Visibility = Visibility.Hidden;
        }

        private void Business_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = BusinessBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Business";
        }

        private void Business_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Food_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = FoodBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Hotels & Food";
        }

        private void Food_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }


        private void HealthCare_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = HealthCareBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "HealthCare";
        }

        private void HealthCare_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }


        private void Transportation_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = TransportationBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Transportation";
        }

        private void Transportation_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Forum_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = ForumBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Forum";
        }

        private void Forum_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void School_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = SchoolBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "School";
        }

        private void School_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }


        private void Business_Button_Click(object sender, RoutedEventArgs e)
        {
            TheFrame.Content = new Business();
        }

        private void Food_Button_Click(object sender, RoutedEventArgs e)
        {
            TheFrame.Content = new HotelandFood();
        }

        private void HealthCare_Button_Click(object sender, RoutedEventArgs e)
        {
            TheFrame.Content = new Healthcare();
        }

        private void Transportation_Button_Click(object sender, RoutedEventArgs e)
        {
            TheFrame.Content = new Transportation();
        }

        private void Forum_Button_Click(object sender, RoutedEventArgs e)
        {
            TheFrame.Content = new NewForum();
        }

        private void School_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateSchoolButton_Click(object sender,RoutedEventArgs e)
        {
            CreateSchool createSchool = new CreateSchool();

            createSchool.Show();

            this.Close();
        }

        private void CreateFacilityBtn_Click(object sender,RoutedEventArgs e)
        {
            CreateFacility createFacility = new CreateFacility();

            createFacility.Show();

            this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
