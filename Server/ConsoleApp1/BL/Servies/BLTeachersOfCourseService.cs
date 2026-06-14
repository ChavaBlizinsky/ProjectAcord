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
    public class BLTeachersOfCourseService : IBLTeachersOfCourses
    {
        ITeachersOfCourses teachersOfCourse;
        public BLTeachersOfCourseService(IDal dal)

        { teachersOfCourse = dal.teachersOfCourses; }
        public BLTeachersOfCourse ConvertToBl(TeachersOfCourse teachersOfCourse)
        {
            BLTeachersOfCourse blTeachersOfCourse = new BLTeachersOfCourse()
            {
                CodeTc=teachersOfCourse.CodeTc,
                CodeOfTeacherTc=teachersOfCourse.CodeOfTeacherTc,
                CodeOfCourseTc=teachersOfCourse.CodeOfCourseTc
            };
            return blTeachersOfCourse;
        }

        public TeachersOfCourse ConvertToDal(BLTeachersOfCourse blteachersOfCourse)
        {
            TeachersOfCourse teachersOfCourse = new TeachersOfCourse()
            {
                CodeTc = blteachersOfCourse.CodeTc,
                CodeOfTeacherTc = blteachersOfCourse.CodeOfTeacherTc,
                CodeOfCourseTc = blteachersOfCourse.CodeOfCourseTc
            };
            return teachersOfCourse;
        }
        public void Create(BLTeachersOfCourse item)
        {
            teachersOfCourse.Create(ConvertToDal(item));
        }

        public void Delete(BLTeachersOfCourse item)
        {
            throw new NotImplementedException();
        }

        public List<BLTeachersOfCourse> Read()
        {
            List<BLTeachersOfCourse> list = new List<BLTeachersOfCourse>();
            foreach (var item in teachersOfCourse.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLTeachersOfCourse item)
        {
            throw new NotImplementedException();
        }
    }
}
