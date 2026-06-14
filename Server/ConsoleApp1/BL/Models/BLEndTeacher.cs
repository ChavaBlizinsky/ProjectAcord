using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLEndTeacher
{
    public int CodeEndTeacher { get; set; }

    public int CodeOfTeacher { get; set; }

    public int? CodeOfCourse { get; set; }

    public string? ReasonEnd { get; set; }

    public int? CodeReasonEndT { get; set; }

    public DateOnly? BeginDate { get; set; }

    /*public virtual BLCourse? CodeOfCourseNavigation { get; set; }

    public virtual BLTeacher CodeOfTeacherNavigation { get; set; } = null!;

    public virtual BLReason? CodeReasonEndTNavigation { get; set; }*/
}
