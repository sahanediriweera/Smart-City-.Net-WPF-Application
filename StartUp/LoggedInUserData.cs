using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_GUI_Project_DataBase.Database;

namespace Testing_GUI_Project_DataBase.StartUp
{
    public class LoggedInUserData
    {
        public static Citizen citizen { get; set; }

        public static Student student { get; set; }

        public static bool IsStudent { get; set; }

        public static bool IsCitizen { get; set; }


        public static void getCitizen(int Id)
        {
            using(MyEntireDataRepository context = new MyEntireDataRepository())
            {
                citizen = context.CitizensData.Find(Id);
                IsCitizen = true;
                IsStudent = false;
            }
        }

        public static void getStudent(int Id)
        {
            using(MyEntireDataRepository context = new MyEntireDataRepository())
            {
                student = context.StudentsData.Find(Id);
                IsCitizen = false;
                IsStudent = true;
            }
        }

    }
}
