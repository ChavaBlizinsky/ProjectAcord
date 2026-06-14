using BL.Api;
using BL.Servies;
using ConsoleApp1.Models;


//using BL.Servies;
using DAL;
using DAL.Api;
using DAL.Servies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{

    public class BLManager 
    {
        public IBLStudents Students { get; }
        public IBLFamily Family { get; }
        public IBLTeachers Teachers { get; }
        public IBLAnnualHoursSystem AnnualHoursSystem { get; }
        public IBLCourse Course { get; }
        public IBLEndStudent EndStudent { get; }
        public IBLEndTeacher EndTeacher { get; }
        public IBLReason Reason { get; }
        public IBLStudentIsAbsent StudentIsAbsent { get; }
        public IBLStudentsOfCourses StudentsOfCourses { get; }
        public IBLStudentWaiting StudentWaiting { get; }
        public IBLteacherIsAbsent teacherIsAbsent { get; }
        public IBLTeachersOfCourses TeachersOfCourses { get; }

        public BLManager()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<IDal, DalManager>();
            services.AddSingleton<IBLStudents,BLStudentServies>();
            services.AddSingleton<IBLFamily, BLFamilyService>();
            services.AddSingleton<IBLAnnualHoursSystem, BLAnnualHoursSystemService>();
            services.AddSingleton<IBLCourse, BLCourseService>();
            services.AddSingleton<IBLEndStudent, BLEndStudentService>();
            services.AddSingleton<IBLEndTeacher, BLEndTeacherService>();
            services.AddSingleton<IBLReason, BLReasonService>();
            services.AddSingleton<IBLStudentIsAbsent, BLStudentIsAbsentService>();
            services.AddSingleton<IBLStudentsOfCourses, BLStudentsOfCourseService>();
            services.AddSingleton<IBLStudentWaiting, BLStudentWqaitingService>();
            services.AddSingleton<IBLteacherIsAbsent, BLTeacherIsAbsentService>();
            services.AddSingleton<IBLTeachersOfCourses, BLTeachersOfCourseService>();
    

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            // הזרקה אוטמטית באמצעות מנגנון ההזרקה של C#
            Students = serviceProvider.GetRequiredService<IBLStudents>();
            Family = serviceProvider.GetRequiredService<IBLFamily>();
            //Teachers = serviceProvider.GetRequiredService<IBLTeachers>();
            AnnualHoursSystem = serviceProvider.GetRequiredService<IBLAnnualHoursSystem>();
            Course = serviceProvider.GetRequiredService<IBLCourse>();
            EndStudent = serviceProvider.GetRequiredService<IBLEndStudent>();
            EndTeacher = serviceProvider.GetRequiredService<IBLEndTeacher>();
            Reason = serviceProvider.GetRequiredService<IBLReason>();
            StudentIsAbsent = serviceProvider.GetRequiredService<IBLStudentIsAbsent>();
            StudentsOfCourses = serviceProvider.GetRequiredService<IBLStudentsOfCourses>();
            StudentWaiting = serviceProvider.GetRequiredService<IBLStudentWaiting>();
            teacherIsAbsent = serviceProvider.GetRequiredService<IBLteacherIsAbsent>();
            TeachersOfCourses = serviceProvider.GetRequiredService<IBLTeachersOfCourses>();

        }
    }
}

