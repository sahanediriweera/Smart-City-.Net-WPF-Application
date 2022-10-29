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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Testing_GUI_Project_DataBase.Database;
using Testing_GUI_Project_DataBase.FacilityUserControls;
using Testing_GUI_Project_DataBase.FacilityUserControls.Business;
using Testing_GUI_Project_DataBase.StartUp;
using Testing_GUI_Project_DataBase.Tempory;
using Testing_GUI_Project_DataBase.FacilityUserControls.Healthcare;
using Testing_GUI_Project_DataBase.FacilityUserControls.HotelandFood;
using Testing_GUI_Project_DataBase.FacilityUserControls.Transportation;

namespace Testing_GUI_Project_DataBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeProgramme initializeProgramme = new InitializeProgramme();
            initializeProgramme.enableFacilities();
            InitializeComponent();
          //  set_Display_Name();

        }

      /*  private void set_Display_Name()
        {
            Name_Plate.Text = "Welcome " + LoggedInUserData.citizen.FirstName +" !";
        }*/

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            lefttopimage.Visibility = Visibility.Visible;
            ColorAnimation ca = new ColorAnimation(Colors.Red, Colors.Blue, new Duration(TimeSpan.FromSeconds(4)));
            Storyboard.SetTarget(ca, GridMenu);
            Storyboard.SetTargetProperty(ca, new PropertyPath("Background.Color"));

            Storyboard stb = new Storyboard();
            stb.Children.Add(ca);
            stb.Begin();
            myFrame.Visibility = Visibility.Collapsed;
            EmptyDisplay.Visibility = Visibility.Visible;

        }

        private void ButtonPopupLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            lefttopimage.Visibility = Visibility.Collapsed;
            myFrame.Visibility = Visibility.Visible;
        }

        private void ClickedBusiness_Button(object sender, RoutedEventArgs e)
        {
            ColorAnimation ca = new ColorAnimation(Colors.Red, Colors.Blue, new Duration(TimeSpan.FromSeconds(4)));
            Storyboard.SetTarget(ca, GridMenu);
            Storyboard.SetTargetProperty(ca, new PropertyPath("Background.Color"));

            Storyboard stb = new Storyboard();
            stb.Children.Add(ca);
            stb.Begin();

            myFrame.Content = new Business();
            showAddFacilityButton();

        }

        private void Clicked_Add_Facility(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void CreateCitizan()
        {
            MyEntireDataRepository context = new MyEntireDataRepository();

            Citizen citizen1 = new Citizen("John","Watson","writer","johnwatson@gmail.com","+31-789-321-456","221B Baker Street");
            Facility facility1 = new Facility("Adventure Story Store", "Got all sorts of adventure and detective stories in books and digital media", "famousblog@lodon.com", "johnwatson@gmail.com", "+31-789-321-456", "Doyle Printers London");
            facility1.citizen = citizen1;
            citizen1.Facilities.Add(facility1);
            context.FacilitiesData.Add(facility1);
            context.CitizensData.Add(citizen1);


            context.SaveChanges();
        }  
        

        private void Update()
        {
            MyEntireDataRepository context = new MyEntireDataRepository();

            var item = context.FacilitiesData.Find(1);


            item.TypeofFacility = "BUSINESS";

            context.Entry(item).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }

        private void ClickedHealthcare_Button(object sender, MouseButtonEventArgs e)
        {
            myFrame.Content = new Healthcare();
        }


        private void ClickedHotelandFood_Button(object sender, MouseButtonEventArgs e)
        {
            myFrame.Content = new HotelandFood();
        }

        private void ClickedTransportation_Button(object sender, MouseButtonEventArgs e)
        {
            myFrame.Content = new Transportation();
        }


        private void ClickedForum_Button(object sender, MouseButtonEventArgs e)
        {
            myFrame.Content = new Forum();
        }

        private void showAddFacilityButton()
        {
            Add_Facility_Button.Visibility = Visibility.Visible;
        }

        private void HideAddFacilityButton()
        {
            Add_Facility_Button.Visibility = Visibility.Hidden;
        }
    
    }

}
