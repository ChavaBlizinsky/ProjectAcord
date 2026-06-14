using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class StudentOfCoursesService : IStudentsOfCourses
    {
        DbManager dbManager;
        public StudentOfCoursesService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(StudentsOfCourse item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.StudentsOfCourses.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the StudentsOfCourses is not add");
                }
            }
        }

        public void Delete(StudentsOfCourse item)
        {
            throw new NotImplementedException();
        }

        public List<StudentsOfCourse> Read() => dbManager.StudentsOfCourses.ToList();


        public void Update(StudentsOfCourse item)
        {
            throw new NotImplementedException();
        }
    }
}
