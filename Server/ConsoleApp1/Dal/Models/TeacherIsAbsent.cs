using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TeacherIsAbsent
{
    public int TeacherIsAbsentCode { get; set; }

    public int CodeOfTeacher { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? CodeReasonAbsentT { get; set; }

    public string? ReasonAbsentT { get; set; }

    public virtual Teacher CodeOfTeacherNavigation { get; set; } = null!;

    public virtual Reason? CodeReasonAbsentTNavigation { get; set; }
}
