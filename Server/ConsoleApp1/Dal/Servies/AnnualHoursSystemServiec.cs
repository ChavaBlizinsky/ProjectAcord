using DAL.Models;
using DAL.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servies
{
    public class AnnualHoursSystemServiec : IAnnualHoursSystem
    {
        DbManager dbManager;
        public AnnualHoursSystemServiec(DbManager dbManager)
        {
            this.dbManager = new DbManager();
            this.dbManager = dbManager;
        }

        public void Create(AnnualHoursSystem item)
        {
            if (item != null)
            {
                try
                {
                    dbManager.AnnualHoursSystems.Add(item);
                    dbManager.SaveChanges();
                }
                catch
                {
                    throw new Exception("the AnnualHoursSystem is not add");
                }
            }

        }


        public void Delete(AnnualHoursSystem item)
        {
            throw new NotImplementedException();
        }

        public List<AnnualHoursSystem> Read() => dbManager.AnnualHoursSystems.ToList();

        public void Update(AnnualHoursSystem item)
        {
            throw new NotImplementedException();
        }
    }
}
