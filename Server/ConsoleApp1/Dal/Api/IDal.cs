
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Api
{
    public interface IDal
    {
         IAnnualHoursSystem AnnualHoursSystem { get; }
         ICourse course { get; }
        IEndStudent endStudent { get; }
        IEndTeacher endTeacher { get; }
        IFamily Family { get; }
        IReason Reason { get; }
        IStudentIsAbsent studentIsAbsent { get; }
        IStudents students { get; }
        IStudentsOfCourses StudentsOfCourses { get; }
        IStudentWaiting studentWaiting { get; }
        IteacherIsAbsent iteacherIsAbsent { get; }
        ITeachers teachers { get; }
        ITeachersOfCourses teachersOfCourses { get; }

    }
}
