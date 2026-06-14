using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TeachersOfCourse
{
    public int CodeTc { get; set; }

    public int CodeOfTeacherTc { get; set; }

    public int CodeOfCourseTc { get; set; }

    public virtual Course CodeOfCourseTcNavigation { get; set; } = null!;

    public virtual Teacher CodeOfTeacherTcNavigation { get; set; } = null!;
}
