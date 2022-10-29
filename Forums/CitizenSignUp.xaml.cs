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
using Testing_GUI_Project_DataBase.StartUp;
using Testing_GUI_Project_DataBase.Database;

namespace Testing_GUI_Project_DataBase.Forums
{
    /// <summary>
    /// Interaction logic for CitizenSignUp.xaml
    /// </summary>
    public partial class CitizenSignUp : Window
    {
        private string FirstName { get; set; }

        private string LastName { get; set; }

        private string Address { get; set; }

        private string Email { get; set; }

        private string ContactInfo { get; set; }

        private string Password1 { get; set; }

        private string Password2 { get; set; }


        public CitizenSignUp()
        {
            InitializeComponent();
        }

        private void CreateCitizen(object sender, RoutedEventArgs e)
        {
            FirstName = FirstNameBox.Text;

            LastName = LastNameBox.Text;

            Address = AddressBox.Text;

            Email = EmailBox.Text;

            ContactInfo = ContactBox.Text;

            Password1 = Pass1Box.Password;

            Password2 = Pass2Box.Password;


            if (checkExistance())
            {
                MessageBox.Show("This user Already Exist");
                FirstNameBox.Text = "";
                LastNameBox.Text = "";
                AddressBox.Text = "";
                EmailBox.Text = "";
                ContactBox.Text = "";
                Pass1Box.Password = "";
                Pass2Box.Password = "";
            }
            else
            {
                if (equalPasswords())
                {
                    newCitizan();
                    BackToLogin();
                }
                else
                {
                    MessageBox.Show("The Passwords are Not equal");
                    Pass1Box.Password = "";
                    Pass2Box.Password = "";
                }
            }

        }


        private bool checkExistance()
        {
            bool value = false;

            foreach (var item in InitializeLoginData.citizens)
            {
                if (item.FirstName == FirstName)
                {
                    if (item.LastName == LastName)
                    {
                        value = true;
                    }
                }
            }

            return value;
        }


        private bool equalPasswords()
        {
            if (Password1 == Password2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void newCitizan()
        {
            using (MyEntireDataRepository context = new MyEntireDataRepository())
            {
                Citizen citizen = new Citizen(FirstName, LastName, Password1, Email, ContactInfo, Address);

                context.CitizensData.Add(citizen);
                context.SaveChanges();

                InitializeLoginData.citizens.Add(citizen);
            }
        }

        private void BackToLogin()
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void CreateStudent(object sender, RoutedEventArgs e)
        {
            CreateStudent createStudent = new CreateStudent();

            createStudent.Show();

            this.Close();

        }
    }
}
