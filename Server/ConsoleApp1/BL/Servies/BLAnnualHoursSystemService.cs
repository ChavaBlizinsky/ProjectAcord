using BL.Api;
using ConsoleApp1.Models;
using DAL.Api;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Servies
{
    public class BLAnnualHoursSystemService : IBLAnnualHoursSystem
    {
        IAnnualHoursSystem annualHoursSystem;
        public BLAnnualHoursSystemService(IDal dal)

        { annualHoursSystem = dal.AnnualHoursSystem; }
        public BLAnnualHoursSystem ConvertToBl(AnnualHoursSystem annualHoursSystem)
        {
            BLAnnualHoursSystem blAnnualHoursSystem = new BLAnnualHoursSystem()
            {
                AnnualHoursSystemCode=annualHoursSystem.AnnualHoursSystemCode,
                TeacherCode=annualHoursSystem.TeacherCode,
                StudentCode=annualHoursSystem.StudentCode,
                Date=annualHoursSystem.Date,
                DayInWeek=annualHoursSystem.DayInWeek,
                Hour=annualHoursSystem.Hour,
                Status=annualHoursSystem.Status
            };

            return blAnnualHoursSystem;
        }

        public AnnualHoursSystem ConvertToDal(BLAnnualHoursSystem blannualHoursSystem)
        {
            AnnualHoursSystem annualHoursSystem = new AnnualHoursSystem()
            {
                AnnualHoursSystemCode = blannualHoursSystem.AnnualHoursSystemCode,
                TeacherCode = blannualHoursSystem.TeacherCode,
                StudentCode = blannualHoursSystem.StudentCode,
                Date = blannualHoursSystem.Date,
                DayInWeek = blannualHoursSystem.DayInWeek,
                Hour = blannualHoursSystem.Hour,
                Status = blannualHoursSystem.Status
            };

            return annualHoursSystem;
        }
        public void Create(BLAnnualHoursSystem item)
        {
            annualHoursSystem.Create(ConvertToDal(item));
        }

        public void Delete(BLAnnualHoursSystem item)
        {
            throw new NotImplementedException();
        }

        public List<BLAnnualHoursSystem> Read()
        {
            List<BLAnnualHoursSystem> list = new List<BLAnnualHoursSystem>();
            foreach (var item in annualHoursSystem.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLAnnualHoursSystem item)
        {
            throw new NotImplementedException();
        }
    }
}
