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
    public class BLCourseService : IBLCourse
    {

        ICourse course;
        public BLCourseService(IDal dal)

        { course = dal.course; }

        public BLCourse ConvertToBl(Course course)
        {
            BLCourse blCourse = new BLCourse()
            {
               CodeOfCourse = course.CodeOfCourse,
               NameOfCourse = course.NameOfCourse,
               SexOfCourse = course.SexOfCourse,
               PriceOfCourse = course.PriceOfCourse,
               DescriptionOfCourse = course.DescriptionOfCourse,
               DuretionTimeOfCourse = course.DuretionTimeOfCourse,
               FromAge = course.FromAge,
               ToAge = course.ToAge
            };

            return blCourse;
        }

        public Course ConvertToDal(BLCourse blcourse)
        {
            Course course = new Course()
            {
                CodeOfCourse = blcourse.CodeOfCourse,
                NameOfCourse = blcourse.NameOfCourse,
                SexOfCourse = blcourse.SexOfCourse,
                PriceOfCourse = blcourse.PriceOfCourse,
                DescriptionOfCourse = blcourse.DescriptionOfCourse,
                DuretionTimeOfCourse = blcourse.DuretionTimeOfCourse,
                FromAge = blcourse.FromAge,
                ToAge = blcourse.ToAge
            };

            return course;
        }
        public void Create(BLCourse item)
        {
            course.Create(ConvertToDal(item));
        }

        public void Delete(BLCourse item)
        {
            throw new NotImplementedException();
        }


        public List<BLCourse> Read()
        {
            List<BLCourse> list = new List<BLCourse>();
            foreach (var item in course.Read())
            {
                list.Add(ConvertToBl(item));
            }
            return list;
        }

        public void Update(BLCourse item)
        {
            throw new NotImplementedException();
        }
    }
}





















