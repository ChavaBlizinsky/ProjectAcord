using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class EndStudentService : IEndStudent
    {
        DbManager dbManager;
        public EndStudentService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(EndStudent item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.EndStudents.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the EndStudent is not add");
                }
            }

        }

        public void Delete(EndStudent item)
        {
            throw new NotImplementedException();
        }

        public List<EndStudent> Read() => dbManager.EndStudents.ToList();

        public void Update(EndStudent item)
        {
            throw new NotImplementedException();
        }
    }
}
