using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class StudentIsAbsent
{
    public int StudentIsAbsentCode { get; set; }

    public int StudentCode { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? ReasonAbsentS { get; set; }

    public int? CodeReasonAbsentS { get; set; }
}
