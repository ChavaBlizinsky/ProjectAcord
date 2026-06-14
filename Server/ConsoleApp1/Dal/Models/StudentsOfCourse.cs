using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class StudentsOfCourse
{
    public int CodeSc { get; set; }

    public int CodeOfStudentSc { get; set; }

    public int CodeOfCourseSc { get; set; }

    public int? CodeOfTeacherSc { get; set; }

    public virtual Course CodeOfCourseScNavigation { get; set; } = null!;

    public virtual Student CodeOfStudentScNavigation { get; set; } = null!;

    public virtual Teacher? CodeOfTeacherScNavigation { get; set; }
}
