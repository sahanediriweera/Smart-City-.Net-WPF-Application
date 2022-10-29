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
using System.Windows.Shapes;
using Testing_GUI_Project_DataBase.Database;
using Testing_GUI_Project_DataBase.StartUp;

namespace Testing_GUI_Project_DataBase.Forums
{
    /// <summary>
    /// Interaction logic for CreateFacility.xaml
    /// </summary>
    public partial class CreateFacility : Window
    {

        private string NameofFacility { get; set; }

        private string Address { get; set; }

        private string TypeofFacility { get; set; }

        private string Description { get; set; }

        private string Email { get; set; }

        private string Website { get; set; }

        private string ContactInfo { get; set; }


        public CreateFacility()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameofFacility = NameBox.Text;

            Address = AddressBox.Text;

            TypeofFacility = ListBoxer.Text;

            ContactInfo = ContactBox.Text;

            Website = WebBox.Text;

            Email = EmailBox.Text;

            Description = DescriptionBox.Text;

            createNewFacility();
            backtoMain();
        }
        private void createNewFacility()
        {
            using (MyEntireDataRepository context = new MyEntireDataRepository())
            {
                Facility facility = new Facility(Name, Description, Website, Email, ContactInfo, Address);
                facility.TypeofFacility = TypeofFacility;
                Citizen citizen = context.CitizensData.Find(LoggedInUserData.citizen.CitizenId);
                citizen.Facilities.Add(facility);
                context.FacilitiesData.Add(facility);
                context.Entry(citizen).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        private void backtoMain()
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
