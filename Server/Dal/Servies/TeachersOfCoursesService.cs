using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class TeachersOfCoursesService : ITeachersOfCourses
    {
        DbManager dbManager;
        public TeachersOfCoursesService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(TeachersOfCourse item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.TeachersOfCourses.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the TeachersOfCourses is not add");
                }
            }
        }
        public void Delete(TeachersOfCourse item)
        {
            throw new NotImplementedException();
        }

        public List<TeachersOfCourse> Read() => dbManager.TeachersOfCourses.ToList();


        public void Update(TeachersOfCourse item)
        {
            throw new NotImplementedException();
        }
    }
}
