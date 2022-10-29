using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_GUI_Project_DataBase.Database
{
    public class MyEntireDataRepository:DbContext
    {
        public  DbSet<Admin> AdminsData { get; set; }

        public  DbSet<Citizen> CitizensData { get; set; }

        public DbSet<Facility> FacilitiesData { get; set; }

        public  DbSet<Forum> ForumsData { get; set; }

        public  DbSet<School> SchoolsData { get; set; }

        public  DbSet<Student> StudentsData { get; set; }
    }
}
