using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class TeacherIsAbsentService : IteacherIsAbsent
    {
        DbManager dbManager;
        public TeacherIsAbsentService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }

        public void Create(TeacherIsAbsent teacherIsAbsent)
        {
            if (teacherIsAbsent != null)
            {
                try
                {
                    dbManager.TeacherIsAbsents.Add(teacherIsAbsent);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the TeacherIsAbsent is not add");
                }
            }
        }

        public void Delete(TeacherIsAbsent item)
        {
            throw new NotImplementedException();
        }

        public List<TeacherIsAbsent> Read() => dbManager.TeacherIsAbsents.ToList();

        public void Update(TeacherIsAbsent item)
        {
            throw new NotImplementedException();
        }
        
        
    }
}
