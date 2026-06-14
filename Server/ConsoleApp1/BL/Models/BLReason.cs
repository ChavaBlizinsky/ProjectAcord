using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public class BLReason
{
    public int CodeReason { get; set; }

    public string? DiscribeReason { get; set; }

   /* public virtual ICollection<BLEndStudent> EndStudents { get; set; } = new List<BLEndStudent>();

    public virtual ICollection<BLEndTeacher> EndTeachers { get; set; } = new List<BLEndTeacher>();

    public virtual ICollection<BLStudentWaiting> StudentWaitings { get; set; } = new List<BLStudentWaiting>();

    public virtual ICollection<BLTeacherIsAbsent> TeacherIsAbsents { get; set; } = new List<BLTeacherIsAbsent>();*/
}
