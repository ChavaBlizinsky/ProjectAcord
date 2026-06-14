using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class StudentWaitingService : IStudentWaiting
    {
        DbManager dbManager;
        public StudentWaitingService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(StudentWaiting item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.StudentWaitings.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the StudentWaitings is not add");
                }
            }
        }
        public void Delete(StudentWaiting item)
        {
            throw new NotImplementedException();
        }

        public List<StudentWaiting> Read() => dbManager.StudentWaitings.ToList();


        public void Update(StudentWaiting item)
        {
            throw new NotImplementedException();
        }
    }
}
