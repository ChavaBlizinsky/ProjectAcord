using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLStudentIsAbsent
{
    public int StudentIsAbsentCode { get; set; }

    public int StudentCode { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? ReasonAbsentS { get; set; }

    public int? CodeReasonAbsentS { get; set; }
}
