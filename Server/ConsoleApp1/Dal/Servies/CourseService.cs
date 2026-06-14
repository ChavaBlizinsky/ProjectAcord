using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class CourseService : ICourse
    {
         DbManager dbManager;
        public CourseService(DbManager dbManager) { 
           this.dbManager = new DbManager();
             this.dbManager = dbManager;
        }
       
        public void Create(Course item)
        {
            if (item != null)
            { 
            try
            {
              dbManager.Courses.Add(item);
                    try { 
                dbManager.SaveChanges();
                    }
                    catch(Exception e)
                    {
                        dbManager.Courses.Local.Remove(item);
                        throw new Exception("cant add cours!!!" +e.Message);
                    }
            }
            catch (Exception e) {
    
                throw new Exception(e.Message);
            }
            }
            
        }

        public void Delete(Course item)
        {
            throw new NotImplementedException();
        }

        public List<Course> Read() => dbManager.Courses.ToList();

        public void Update(Course item)
        {
            throw new NotImplementedException();
        }
    }
}
