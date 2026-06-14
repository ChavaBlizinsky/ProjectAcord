using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Reason
{
    public int CodeReason { get; set; }

    public string? DiscribeReason { get; set; }

    public virtual ICollection<EndStudent> EndStudents { get; set; } = new List<EndStudent>();

    public virtual ICollection<EndTeacher> EndTeachers { get; set; } = new List<EndTeacher>();

    public virtual ICollection<StudentWaiting> StudentWaitings { get; set; } = new List<StudentWaiting>();

    public virtual ICollection<TeacherIsAbsent> TeacherIsAbsents { get; set; } = new List<TeacherIsAbsent>();
}
