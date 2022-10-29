using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_GUI_Project_DataBase.TheForum
{
    public class ForumModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Idea { get; set; }

        public ForumModel(string firstName, string lastName, string idea)
        {
            FirstName = firstName;
            LastName = lastName;
            Idea = idea;
        }
    }
}
