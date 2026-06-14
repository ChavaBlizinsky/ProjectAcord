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
    public class BLStudentsOfCourseService : IBLStudentsOfCourses
    {
        IStudentsOfCourses studentsOfCourse;
        public BLStudentsOfCourseService(IDal dal)

        { studentsOfCourse = dal.StudentsOfCourses; }

        public BLStudentsOfCourse ConvertToBl(StudentsOfCourse studentsOfCourse)
        {
            BLStudentsOfCourse blStudentsOfCourse = new BLStudentsOfCourse()
            {
                CodeSc= studentsOfCourse.CodeSc,
                CodeOfStudentSc=studentsOfCourse.CodeOfStudentSc,
                CodeOfCourseSc=studentsOfCourse.CodeOfCourseSc,
                CodeOfTeacherSc= studentsOfCourse.CodeOfTeacherSc
            };

            return blStudentsOfCourse;
        }
        public StudentsOfCourse ConvertToDal(BLStudentsOfCourse blstudentsOfCourse)
        {
            StudentsOfCourse studentsOfCourse = new StudentsOfCourse()
            {
                CodeSc = blstudentsOfCourse.CodeSc,
                CodeOfStudentSc = blstudentsOfCourse.CodeOfStudentSc,
                CodeOfCourseSc = blstudentsOfCourse.CodeOfCourseSc,
                CodeOfTeacherSc = blstudentsOfCourse.CodeOfTeacherSc
            };

            return studentsOfCourse;
        }
        public void Create(BLStudentsOfCourse item)
        {
            studentsOfCourse.Create(ConvertToDal(item));    
        }

        public void Delete(BLStudentsOfCourse item)
        {
            throw new NotImplementedException();
        }

        public List<BLStudentsOfCourse> Read()
        {
            List<BLStudentsOfCourse> list = new List<BLStudentsOfCourse>();
            foreach (var item in studentsOfCourse.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLStudentsOfCourse item)
        {
            throw new NotImplementedException();
        }
    }
}
