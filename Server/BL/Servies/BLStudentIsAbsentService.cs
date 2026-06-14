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
    public class BLStudentIsAbsentService : IBLStudentIsAbsent
    {
        IStudentIsAbsent studentIsAbsent;
        public BLStudentIsAbsentService(IDal dal)

        { studentIsAbsent = dal.studentIsAbsent; }
        public BLStudentIsAbsent ConvertToBl(StudentIsAbsent studentIsAbsent)
        {
            BLStudentIsAbsent bLStudentIsAbsent = new BLStudentIsAbsent()
            {
                StudentIsAbsentCode = studentIsAbsent.StudentIsAbsentCode,
                StudentCode = studentIsAbsent.StudentCode,
                FromDate = studentIsAbsent.FromDate,
                ToDate = studentIsAbsent.ToDate,
                ReasonAbsentS=studentIsAbsent.ReasonAbsentS,
                CodeReasonAbsentS=studentIsAbsent.CodeReasonAbsentS
            };

            return bLStudentIsAbsent;
        }
        public StudentIsAbsent ConvertToDal(BLStudentIsAbsent blstudentIsAbsent)
        {
            StudentIsAbsent studentIsAbsent = new StudentIsAbsent()
            {
                StudentIsAbsentCode = blstudentIsAbsent.StudentIsAbsentCode,
                StudentCode = blstudentIsAbsent.StudentCode,
                FromDate = blstudentIsAbsent.FromDate,
                ToDate = blstudentIsAbsent.ToDate,
                ReasonAbsentS = blstudentIsAbsent.ReasonAbsentS,
                CodeReasonAbsentS = blstudentIsAbsent.CodeReasonAbsentS
            };

            return studentIsAbsent;
        }
        public void Create(BLStudentIsAbsent item)
        {
            studentIsAbsent.Create(ConvertToDal(item));
        }

        public void Delete(BLStudentIsAbsent item)
        {
            throw new NotImplementedException();
        }

        public List<BLStudentIsAbsent> Read()
        {
            List<BLStudentIsAbsent> list = new List<BLStudentIsAbsent>();
            foreach (var item in studentIsAbsent.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLStudentIsAbsent item)
        {
            throw new NotImplementedException();
        }
    }
}
