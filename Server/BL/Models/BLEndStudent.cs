using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLEndStudent
{
    public int CodeEndStudent { get; set; }

    public int CodeSudent { get; set; }

    public int? CodeCours { get; set; }

    public int? CodeReasonEndS { get; set; }

    public string? ReasonEndS { get; set; }

   /* public virtual BLCourse? CodeCoursNavigation { get; set; }

    public virtual BLReason? CodeReasonEndSNavigation { get; set; }

    public virtual BLStudent CodeSudentNavigation { get; set; } = null!;*/
}
