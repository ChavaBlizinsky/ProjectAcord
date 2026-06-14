using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLTeachersOfCourse
{
    public int CodeTc { get; set; }

    public int CodeOfTeacherTc { get; set; }

    public int CodeOfCourseTc { get; set; }

    public virtual BLCourse CodeOfCourseTcNavigation { get; set; } = null!;

    public virtual BLTeacher CodeOfTeacherTcNavigation { get; set; } = null!;
}
