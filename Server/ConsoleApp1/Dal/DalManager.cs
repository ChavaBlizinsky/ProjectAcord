using DAL.Api;
using System;



using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.Extensions.DependencyInjection;
using DAL.Models;
using DAL.Servies;
//using DAL.Servies;
//using ConsoleApp1.Models;

namespace DAL
{
    public class DalManager : IDal
    {
        public IAnnualHoursSystem AnnualHoursSystem { get; }

        public ICourse course { get; }

        public IEndStudent endStudent { get; }

        public IEndTeacher endTeacher { get; }

        public IFamily Family { get; }
        public IReason Reason { get; }

        public IStudentIsAbsent studentIsAbsent { get; }

        public IStudents students { get; }

        public IStudentsOfCourses StudentsOfCourses { get; }

        public IStudentWaiting studentWaiting { get; }

        public IteacherIsAbsent iteacherIsAbsent { get; }

        public ITeachers teachers { get; }

        public ITeachersOfCourses teachersOfCourses { get; }


        public DalManager()
        {
            // הגדרת אוסף של אוביקטי שרות
            
            ServiceCollection service = new ServiceCollection();
            service.AddDbContext<DbManager>();
            // מילוי האוסף
            service.AddSingleton<IStudents,StudentsService>();
            service.AddSingleton<IFamily, FamilyService>();
            service.AddSingleton<ITeachers, teachersService>();
            service.AddSingleton<ICourse, CourseService>();
            service.AddSingleton<IAnnualHoursSystem, AnnualHoursSystemServiec>();
            service.AddSingleton<IEndStudent, EndStudentService>();
            service.AddSingleton<IReason, ReasonService>();
            service.AddSingleton<IStudentIsAbsent, StudentIsAbsentService>();
            service.AddSingleton<ITeachersOfCourses, TeachersOfCoursesService>();
            service.AddSingleton<IteacherIsAbsent, TeacherIsAbsentService>();
            service.AddSingleton<IStudentWaiting, StudentWaitingService>();
            service.AddSingleton<IStudentsOfCourses, StudentOfCoursesService>();
            service.AddSingleton<IEndTeacher, EndTeacherService>();


            // הגדרת ספק אוביקטים
            ServiceProvider serviceProvider = service.BuildServiceProvider();
            students = serviceProvider.GetService<IStudents>();
            Family = serviceProvider.GetService<IFamily>();
            teachers = serviceProvider.GetService<ITeachers>();
            course = serviceProvider.GetService<ICourse>();
            AnnualHoursSystem= serviceProvider.GetService<IAnnualHoursSystem>();
            teachersOfCourses = serviceProvider.GetService<ITeachersOfCourses>();
            iteacherIsAbsent = serviceProvider.GetService<IteacherIsAbsent>();
            studentWaiting = serviceProvider.GetService<IStudentWaiting>();
            StudentsOfCourses = serviceProvider.GetService<IStudentsOfCourses>();
            studentIsAbsent = serviceProvider.GetService<IStudentIsAbsent>();
            endTeacher = serviceProvider.GetService<IEndTeacher>();
        }

    }
}
