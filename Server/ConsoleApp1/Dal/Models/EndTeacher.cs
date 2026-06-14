using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EndTeacher
{
    public int CodeEndTeacher { get; set; }

    public int CodeOfTeacher { get; set; }

    public int? CodeOfCourse { get; set; }

    public string? ReasonEnd { get; set; }

    public int? CodeReasonEndT { get; set; }

    public DateOnly? BeginDate { get; set; }

    public virtual Course? CodeOfCourseNavigation { get; set; }

    public virtual Teacher CodeOfTeacherNavigation { get; set; } = null!;

    public virtual Reason? CodeReasonEndTNavigation { get; set; }
}
