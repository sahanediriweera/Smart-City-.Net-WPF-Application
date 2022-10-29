using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_GUI_Project_DataBase
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PassWord { get; set; }

        public DateTime DOB { get; set; }

        public DateTime Age { get; set; }

        public int Grade { get; set; }

        public string Address { get; set; }

        public virtual School School { get; set; }

        public Student(string firstName, string lastName, string passWord, DateTime dOB, DateTime age, int grade, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            PassWord = passWord;
            DOB = dOB;
            Age = age;
            Grade = grade;
            Address = address;
        }

        public Student()
        {
        }
    }
}
