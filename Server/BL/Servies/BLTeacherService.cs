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
    public class BLTeacherService : IBLTeachers
    {
        ITeachers teacher;
        public BLTeacherService(IDal dal)

        { teacher = dal.teachers; }
        public BLTeacher ConvertToBl(Teacher teacher)
        {
            BLTeacher blTeacher = new BLTeacher()
            {
                CodeOfTeacher = teacher.CodeOfTeacher,
                IdOfTeacher=teacher.IdOfTeacher,
                FirstNameOfTeacher=teacher.FirstNameOfTeacher,
                LastNameOfTeacher=teacher.LastNameOfTeacher,
                PhoneOfTeacher=teacher.PhoneOfTeacher,
                Mail=teacher.Mail,
                ActOrNot=teacher.ActOrNot,
                SexOfTeacher=teacher.SexOfTeacher,
                ComentTeacher=teacher.ComentTeacher
            };
            return blTeacher;
        }

        public Teacher ConvertToDal(BLTeacher blteacher)
        {
            Teacher teacher = new Teacher()
            {
                CodeOfTeacher = blteacher.CodeOfTeacher,
                IdOfTeacher = blteacher.IdOfTeacher,
                FirstNameOfTeacher = blteacher.FirstNameOfTeacher,
                LastNameOfTeacher = blteacher.LastNameOfTeacher,
                PhoneOfTeacher = blteacher.PhoneOfTeacher,
                Mail = blteacher.Mail,
                ActOrNot = blteacher.ActOrNot,
                SexOfTeacher = blteacher.SexOfTeacher,
                ComentTeacher = blteacher.ComentTeacher
            };
            return teacher;
        }
        public void Create(BLTeacher item)
        {
            teacher.Create(ConvertToDal(item));
        }

        public void Delete(BLTeacher item)
        {
            throw new NotImplementedException();
        }

        public List<BLTeacher> Read()
        {
            List<BLTeacher> list = new List<BLTeacher>();
            foreach (var item in teacher.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLTeacher item)
        {
            throw new NotImplementedException();
        }
    }
}
