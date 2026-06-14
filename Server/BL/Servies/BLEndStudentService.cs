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
    public class BLEndStudentService : IBLEndStudent
    {
        IEndStudent endStudent;
        public BLEndStudentService(IDal dal)

        { endStudent = dal.endStudent; }
        public BLEndStudent ConvertToBl(EndStudent endStudent)
        {
            BLEndStudent blEndStudent = new BLEndStudent()
            {
               CodeEndStudent= endStudent.CodeEndStudent,
               CodeSudent=endStudent.CodeSudent,
               CodeCours=endStudent.CodeCours,
               CodeReasonEndS=endStudent.CodeReasonEndS,
               ReasonEndS=endStudent.ReasonEndS
            };

            return blEndStudent;
        }
        public EndStudent ConvertToDal(BLEndStudent blendStudent)
        {
            EndStudent endStudent = new EndStudent()
            {
                CodeEndStudent = blendStudent.CodeEndStudent,
                CodeSudent = blendStudent.CodeSudent,
                CodeCours = blendStudent.CodeCours,
                CodeReasonEndS = blendStudent.CodeReasonEndS,
                ReasonEndS = blendStudent.ReasonEndS
            };

            return endStudent;
        }
        public void Create(BLEndStudent item)
        {
            endStudent.Create(ConvertToDal(item));
        }

        public void Delete(BLEndStudent item)
        {
            throw new NotImplementedException();
        }

        public List<BLEndStudent> Read()
        {
            List<BLEndStudent> list = new List<BLEndStudent>();
            foreach (var item in endStudent.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLEndStudent item)
        {
            throw new NotImplementedException();
        }
    }
}
