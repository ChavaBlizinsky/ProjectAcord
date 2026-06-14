using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class FamilyService : IFamily
    {
        DbManager dbManager;
        public FamilyService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(Family item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.Families.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the Families is not add");
                }
            }
        }

        public void Delete(Family item)
        {
            throw new NotImplementedException();
        }

        public List<Family> Read() => dbManager.Families.ToList();

        public void Update(Family item)
        {
            throw new NotImplementedException();
        }
    }
}
