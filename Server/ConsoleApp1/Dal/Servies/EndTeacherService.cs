using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class EndTeacherService : IEndTeacher
    {
        DbManager dbManager;
        public EndTeacherService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(EndTeacher item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.EndTeachers.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the EndTeacher is not add");
                }
            }

        }

        public void Delete(EndTeacher item)
        {
            throw new NotImplementedException();
        }

        public List<EndTeacher> Read() => dbManager.EndTeachers.ToList();


        public void Update(EndTeacher item)
        {
            throw new NotImplementedException();
        }
    }
}
