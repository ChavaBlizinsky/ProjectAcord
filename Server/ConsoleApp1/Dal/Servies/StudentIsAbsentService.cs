using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class StudentIsAbsentService : IStudentIsAbsent
    {
        DbManager dbManager;
        public StudentIsAbsentService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(StudentIsAbsent item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.StudentIsAbsents.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the StudentIsAbsent is not add");
                }
            }
        }
        public void Delete(StudentIsAbsent item)
        {
            throw new NotImplementedException();
        }

        public List<StudentIsAbsent> Read() => dbManager.StudentIsAbsents.ToList();


        public void Update(StudentIsAbsent item)
        {
            throw new NotImplementedException();
        }
    }
}
