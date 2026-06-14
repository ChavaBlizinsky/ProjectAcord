using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EndStudent
{
    public int CodeEndStudent { get; set; }

    public int CodeSudent { get; set; }

    public int? CodeCours { get; set; }

    public int? CodeReasonEndS { get; set; }

    public string? ReasonEndS { get; set; }

    public virtual Course? CodeCoursNavigation { get; set; }

    public virtual Reason? CodeReasonEndSNavigation { get; set; }

    public virtual Student CodeSudentNavigation { get; set; } = null!;
}
