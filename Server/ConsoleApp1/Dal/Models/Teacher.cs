using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Teacher
{
    public int CodeOfTeacher { get; set; }

    public string IdOfTeacher { get; set; } = null!;

    public string FirstNameOfTeacher { get; set; } = null!;

    public string LastNameOfTeacher { get; set; } = null!;

    public string PhoneOfTeacher { get; set; } = null!;

    public string? Mail { get; set; }

    public string? ActOrNot { get; set; }

    public string? SexOfTeacher { get; set; }

    public string? ComentTeacher { get; set; }

    public virtual ICollection<AnnualHoursSystem> AnnualHoursSystems { get; set; } = new List<AnnualHoursSystem>();

    public virtual ICollection<EndTeacher> EndTeachers { get; set; } = new List<EndTeacher>();

    public virtual ICollection<StudentsOfCourse> StudentsOfCourses { get; set; } = new List<StudentsOfCourse>();

    public virtual ICollection<TeacherIsAbsent> TeacherIsAbsents { get; set; } = new List<TeacherIsAbsent>();

    public virtual ICollection<TeachersOfCourse> TeachersOfCourses { get; set; } = new List<TeachersOfCourse>();
}
