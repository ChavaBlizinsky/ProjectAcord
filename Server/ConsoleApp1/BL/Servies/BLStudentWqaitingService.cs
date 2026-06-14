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
    public class BLStudentWqaitingService : IBLStudentWaiting
    {
        IStudentWaiting studentWaiting;
        public BLStudentWqaitingService(IDal dal)

        { studentWaiting = dal.studentWaiting; }
        public BLStudentWaiting ConvertToBl(StudentWaiting studentWaiting)
        {
            BLStudentWaiting blStudentWaiting = new BLStudentWaiting()
            {
                StudentWaitingCode=studentWaiting.StudentWaitingCode,
                StudentCode=studentWaiting.StudentCode,
                CourseCode=studentWaiting.CourseCode,
                WaitingDate=studentWaiting.WaitingDate,
                WaitingReasonCode=studentWaiting.WaitingReasonCode,
                WaitingReason=studentWaiting.WaitingReason
            };

            return blStudentWaiting;
        }

        public StudentWaiting ConvertToDal(BLStudentWaiting blstudentWaiting)
        {
            StudentWaiting studentWaiting = new StudentWaiting()
            {
                StudentWaitingCode = blstudentWaiting.StudentWaitingCode,
                StudentCode = blstudentWaiting.StudentCode,
                CourseCode = blstudentWaiting.CourseCode,
                WaitingDate = blstudentWaiting.WaitingDate,
                WaitingReasonCode = blstudentWaiting.WaitingReasonCode,
                WaitingReason = blstudentWaiting.WaitingReason
            };

            return studentWaiting;
        }
        public void Create(BLStudentWaiting item)
        {
            studentWaiting.Create(ConvertToDal(item));  
        }

        public void Delete(BLStudentWaiting item)
        {
            throw new NotImplementedException();
        }

        public List<BLStudentWaiting> Read()
        {
            List<BLStudentWaiting> list = new List<BLStudentWaiting>();
            foreach (var item in studentWaiting.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLStudentWaiting item)
        {
            throw new NotImplementedException();
        }
    }
}
