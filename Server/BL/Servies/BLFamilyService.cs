using BL.Api;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Api;
using DAL.Models;

namespace BL.Servies
{
    public class BLFamilyService : IBLFamily
    {
        IFamily family;
              public BLFamilyService(IDal dal)

               { family = dal.Family; }

        public BLFamily ConvertToBl(Family family)
        {
            BLFamily blFamily = new BLFamily()
            {
                CodeFamily = family.CodeFamily,
                LastName = family.LastName,
                Address = family.Address,
                Phone = family.Phone,
                Mail = family.Mail,
                Paiy = family.Paiy
            };

            return blFamily;
        }

        public Family ConvertToDal(BLFamily blfamily)
        {
            Family family = new Family()
            {
                CodeFamily = blfamily.CodeFamily,
                LastName = blfamily.LastName,
                Address = blfamily.Address,
                Phone = blfamily.Phone,
                Mail = blfamily.Mail,
                Paiy = blfamily.Paiy
            };

            return family;
        }
        public void Create(BLFamily item)
        {
            family.Create(ConvertToDal(item));  
        }

        public void Delete(BLFamily item)
        {
            throw new NotImplementedException();
        }

        public List<BLFamily> Read()
        {
            List<BLFamily> list = new List<BLFamily>();
            foreach (var item in family.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLFamily item)
        {
            throw new NotImplementedException();
        }
    }
}
