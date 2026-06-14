using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class teachersService : ITeachers
    {
        DbManager dbManager;

       
        public teachersService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(Teacher item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.Teachers.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the Teacher is not add");
                }
            }
        }

        public void Delete(Teacher item)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> Read() => dbManager.Teachers.ToList();
        public void Update(Teacher item)
        {
            throw new NotImplementedException();
        }
        
    }
}
