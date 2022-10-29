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

namespace Testing_GUI_Project_DataBase.Forums
{
    /// <summary>
    /// Interaction logic for CreateStudent.xaml
    /// </summary>
    public partial class CreateStudent : Window
    {

        private String FirstName;

        private String LastName;

        private String Address;

        private String SchoolName;

        private int Grade;

        private String Password;

        private DateTime dateTime;


        public CreateStudent()
        { 
            InitializeComponent();
        }



       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstName = NameBox.Text;

            LastName = LastNameBox.Text;

            Address = AddressBox.Text;

            Password = PassBox.Password;

            Grade = Int16.Parse(GradeBox.Text);

            SchoolName = SchoolBox.Text;

            dateTime = Convert.ToDateTime(DPicker.ToString());

            if (StudebtCheck()>0)
            {
                MessageBox.Show("This Student Already Exist");
                clearData();
            }
            else
            {
                createStudent();
                backtoLogin();
            }

        }


        private void createStudent()
        {
            Student student = new Student();

            student.FirstName = FirstName;

            student.LastName = LastName;

            student.Address = Address;

            student.Grade = Grade;

            student.PassWord = Password;

            using (MyEntireDataRepository context = new MyEntireDataRepository())
            {
                context.StudentsData.Add(student);

                context.SaveChanges();
            }

            
        }

        private void backtoLogin()
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }


        private int StudebtCheck()
        {
            int val = -1;

            using(MyEntireDataRepository content = new MyEntireDataRepository())
            {
                List<Student> students = content.StudentsData.ToList();

                foreach(var student in students)
                {
                    if(FirstName == student.FirstName && LastName == student.LastName)
                    {
                        val = student.StudentId;
                    }
                }
            }

            return val;
        }

        


       

        private void clearData()
        {
            NameBox.Text = "";

            LastNameBox.Text = "";

            AddressBox.Text = "";

            SchoolBox.Text = "";

            GradeBox.Text = "";

            PassBox.Password = "";
            
        }
    }
}
