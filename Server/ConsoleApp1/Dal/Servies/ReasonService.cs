using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class ReasonService : IReason
    {
        DbManager dbManager;
      
        public ReasonService(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }
        public void Create(Reason item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.Reasons.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the Reason is not add");
                }
            }
        }

        public void Delete(Reason item)
        {
            throw new NotImplementedException();
        }

        public List<Reason> Read() => dbManager.Reasons.ToList();

        public void Update(Reason item)
        {
            throw new NotImplementedException();
        }
    }
}
