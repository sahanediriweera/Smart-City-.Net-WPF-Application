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

namespace Testing_GUI_Project_DataBase.Forums
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        private string FirstName { get; set; }

        private string SecondName { get; set; }

        private string Password { get; set; }

        private bool IsCitizan { get; set; }


        public Login()
        {
            InitializeLoginData.initializedata();   
            InitializeComponent();
        }

        private int getAccountId()
        {
            int value = -1;

            foreach (var item in InitializeLoginData.citizens)
            {
                if (item.FirstName == FirstName)
                {
                    if (item.LastName == SecondName)
                    {
                        if (item.PassWord == Password)
                        {
                            value = item.CitizenId;
                            IsCitizan = true;
                            break;
                        }
                    }
                }
            }

            foreach (var item in InitializeLoginData.students)
            {
                if (item.FirstName == FirstName)
                {
                    if (item.LastName == SecondName)
                    {
                        if (item.PassWord == Password)
                        {
                            value = item.StudentId;
                            IsCitizan = false;
                            break;
                        }
                    }
                }
            }


            return value;
        }


        private void LoginAsCitizen(int Id)
        {
            LoggedInUserData.IsCitizen = true;
            LoggedInUserData.getCitizen(Id);
            LogIntoMainWindow();
        }

        private void LoginAsStudent(int Id)
        {
            LoggedInUserData.IsStudent = true;
            LoggedInUserData.getStudent(Id);
            LogIntoMainWindow();
        }

        private void LogIntoMainWindow()
        {
            NewMainWindow newMainWindow = new NewMainWindow(); 
            this.Close();
            newMainWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstName = FirstNameTextbox.Text;
            SecondName = SecondNameTextbox.Text;
            Password = PasswordBox.Password;

            int id = getAccountId();

            if (id > 0)
            {
                if (IsCitizan)
                {
                    LoginAsCitizen(id);
                }
                else
                {
                    LoginAsStudent(id);
                }
            }
            else
            {
                MessageBox.Show("Error incorrect Name or Password Try again");
                FirstNameTextbox.Text = "";
                SecondNameTextbox.Text = "";
                PasswordBox.Password = "";
            }
        }

        private void Button_Click_SignIn(object sender, RoutedEventArgs e)
        {
            CitizenSignUp citizenSignUp = new CitizenSignUp();
            this.Close();
            citizenSignUp.Show();
        }


    }
}
