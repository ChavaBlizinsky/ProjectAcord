using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLStudentsOfCourse
{
    public int CodeSc { get; set; }

    public int CodeOfStudentSc { get; set; }

    public int CodeOfCourseSc { get; set; }

    public int? CodeOfTeacherSc { get; set; }

    public virtual BLCourse CodeOfCourseScNavigation { get; set; } = null!;

    public virtual BLStudent CodeOfStudentScNavigation { get; set; } = null!;

    public virtual BLTeacher? CodeOfTeacherScNavigation { get; set; }
}
