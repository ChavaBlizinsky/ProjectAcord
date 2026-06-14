
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IBLI
    {
         IBLAnnualHoursSystem AnnualHoursSystem { get; }
         IBLCourse course { get; }
        IBLEndStudent endStudent { get; }
        IBLEndTeacher endTeacher { get; }
        IBLFamily Family { get; }
        IBLReason Reason { get; }
        IBLStudentIsAbsent studentIsAbsent { get; }
        IBLStudents students { get; }
        IBLStudentsOfCourses StudentsOfCourses { get; }
        IBLStudentWaiting studentWaiting { get; }
        IBLteacherIsAbsent iteacherIsAbsent { get; }
        IBLTeachers teachers { get; }
        IBLTeachersOfCourses teachersOfCourses { get; }

    }
}
