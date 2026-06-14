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
    public class BLReasonService : IBLReason
    {
        IReason reason;
        public BLReasonService(IDal dal)

        { reason = dal.Reason; }

        public BLReason ConvertToBl(Reason reason)
        {
            BLReason blReason = new BLReason()
            {
                CodeReason = reason.CodeReason,
                DiscribeReason = reason.DiscribeReason,
            };

            return blReason;
        }
        public Reason ConvertToDal(BLReason blreason)
        {
            Reason reason = new Reason()
            {
                CodeReason = blreason.CodeReason,
                DiscribeReason = blreason.DiscribeReason,
            };

            return reason;
        }

        public void Create(BLReason item)
        {
            reason.Create(ConvertToDal(item));
        }

        public void Delete(BLReason item)
        {
            throw new NotImplementedException();
        }

        public List<BLReason> Read()
        {
            List<BLReason> list = new List<BLReason>();
            foreach (var item in reason.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLReason item)
        {
            throw new NotImplementedException();
        }
    }
}
