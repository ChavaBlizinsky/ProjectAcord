using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class StudentsService : IStudents
    {
        DbManager dbManager;

        public StudentsService(DbManager dbManager)
        {

            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(Student item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.Students.Add(item);

                    try
                    {
                        dbManager.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        dbManager.Students.Local.Remove(item);
                        throw new Exception("cant add cours!!!" + e.Message);
                    }
                    
                }
                
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
        }

        public void Delete(Student item)
        {
            throw new NotImplementedException();
        }

        public List<Student> Read() => dbManager.Students.ToList();

        public void Update(Student item)
        {
            throw new NotImplementedException();
        }
    }
}
