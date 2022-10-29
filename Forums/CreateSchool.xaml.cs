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
    /// Interaction logic for CreateSchool.xaml
    /// </summary>
    public partial class CreateSchool : Window
    {

        private String SchoolName;

        private String Address;

        private String contactNo;

        private String email;


        public CreateSchool()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SchoolName = NameBox.Text;

            Address = AddressBox.Text;

            contactNo = ContactBox.Text;

            email = EmailBox.Text;

            int id =  checkExistance();

            if (id < 0)
            {
                createtheSchool();
            }
            else
            {
                MessageBox.Show("The school already exists");
            }


        }

        private void createtheSchool()
        {
            using(MyEntireDataRepository context = new MyEntireDataRepository())
            {
                School school = new School();

                school.Name = SchoolName;

                school.Address = Address;

                school.ContactNo = contactNo;

                school.Email = email;


                context.SchoolsData.Add(school);

                context.SaveChanges();
            }
        }

        private int checkExistance()
        {
            int IdNum = -1;

            using (MyEntireDataRepository context = new MyEntireDataRepository())
            {
                List<School> schools = context.SchoolsData.ToList();

                foreach(School school in schools)
                {
                    if(school.Name == SchoolName)
                    {
                        IdNum = school.SchoolId;
                        break;
                    }
                }
            }

            return IdNum;

        }
    }
}
