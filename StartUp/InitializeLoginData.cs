using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_GUI_Project_DataBase.Database;

namespace Testing_GUI_Project_DataBase.StartUp
{
    public class InitializeLoginData
    {

        public static List<Citizen> citizens { get; set; }
        public static List<Student> students { get; set; }

        public static bool Isloaded { get; set; }



    
        public static void initializedata()
        {
            if (Isloaded) { } else {
                using (MyEntireDataRepository context = new MyEntireDataRepository())
                {
                    citizens = context.CitizensData.ToList();
                    students = context.StudentsData.ToList();
                    Isloaded = true;
                }
            }

            
        }
    
    }
}
