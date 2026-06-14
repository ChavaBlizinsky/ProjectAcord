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
    public class BLTeacherIsAbsentService : IBLteacherIsAbsent
    {
                
        IteacherIsAbsent teacherIsAbsent;
        public BLTeacherIsAbsentService(IDal dal)

        { teacherIsAbsent = dal.iteacherIsAbsent; }

        public BLTeacherIsAbsent ConvertToBl(TeacherIsAbsent teacherIsAbsent)
        {
            BLTeacherIsAbsent blTeacherIsAbsent = new BLTeacherIsAbsent()
            {
                TeacherIsAbsentCode = teacherIsAbsent.TeacherIsAbsentCode,
                CodeOfTeacher = teacherIsAbsent.CodeOfTeacher,
                FromDate = teacherIsAbsent.FromDate,
                ToDate = teacherIsAbsent.ToDate,
                CodeReasonAbsentT = teacherIsAbsent.CodeReasonAbsentT,
                ReasonAbsentT = teacherIsAbsent.ReasonAbsentT
            };

            return blTeacherIsAbsent;
        }
        public TeacherIsAbsent ConvertToDal(BLTeacherIsAbsent blteacherIsAbsent)
        {
            TeacherIsAbsent teacherIsAbsent = new TeacherIsAbsent()
            {
                TeacherIsAbsentCode = blteacherIsAbsent.TeacherIsAbsentCode,
                CodeOfTeacher = blteacherIsAbsent.CodeOfTeacher,
                FromDate = blteacherIsAbsent.FromDate,
                ToDate = blteacherIsAbsent.ToDate,
                CodeReasonAbsentT = blteacherIsAbsent.CodeReasonAbsentT,
                ReasonAbsentT = blteacherIsAbsent.ReasonAbsentT
            };

            return teacherIsAbsent;
        }
        public void Create(BLTeacherIsAbsent item)
        {
            teacherIsAbsent.Create(ConvertToDal(item));
        }

        public void Delete(BLTeacherIsAbsent item)
        {
            throw new NotImplementedException();
        }

        public List<BLTeacherIsAbsent> Read()
        {
            List<BLTeacherIsAbsent> list = new List<BLTeacherIsAbsent>();
            foreach (var item in teacherIsAbsent.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLTeacherIsAbsent item)
        {
            throw new NotImplementedException();
        }
    }
}
