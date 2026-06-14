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
    public class BLEndTeacherService : IBLEndTeacher
    {
        IEndTeacher endTeacher;
        public BLEndTeacherService(IDal dal)

        { endTeacher = dal.endTeacher; }
        public BLEndTeacher ConvertToBl(EndTeacher endTeacher)
        {
            BLEndTeacher blEndTeacher = new BLEndTeacher()
            {
                CodeEndTeacher = endTeacher.CodeEndTeacher,
                CodeOfTeacher = endTeacher.CodeOfTeacher,
                CodeOfCourse = endTeacher.CodeOfCourse,              
                ReasonEnd = endTeacher.ReasonEnd,
                CodeReasonEndT = endTeacher.CodeReasonEndT,
                BeginDate=endTeacher.BeginDate
            };

            return blEndTeacher;
        }
        public EndTeacher ConvertToDal(BLEndTeacher blendTeacher)
        {
            EndTeacher endTeacher = new EndTeacher()
            {
                CodeEndTeacher = blendTeacher.CodeEndTeacher,
                CodeOfTeacher = blendTeacher.CodeOfTeacher,
                CodeOfCourse = blendTeacher.CodeOfCourse,
                ReasonEnd = blendTeacher.ReasonEnd,
                CodeReasonEndT = blendTeacher.CodeReasonEndT,
                BeginDate = blendTeacher.BeginDate
            };

            return endTeacher;
        }
        public void Create(BLEndTeacher item)
        {
            endTeacher.Create(ConvertToDal(item));
        }

        public void Delete(BLEndTeacher item)
        {
            throw new NotImplementedException();
        }

        public List<BLEndTeacher> Read()
        {
            List<BLEndTeacher> list = new List<BLEndTeacher>();
            foreach (var item in endTeacher.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLEndTeacher item)
        {
            throw new NotImplementedException();
        }
    }
}
