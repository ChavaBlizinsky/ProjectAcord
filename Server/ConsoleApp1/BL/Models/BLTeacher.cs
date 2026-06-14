using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public  class BLTeacher
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

    //public virtual ICollection<BLAnnualHoursSystem> AnnualHoursSystems { get; set; } = new List<BLAnnualHoursSystem>();

    //public virtual ICollection<BLEndTeacher> EndTeachers { get; set; } = new List<BLEndTeacher>();

    //public virtual ICollection<BLStudentsOfCourse> StudentsOfCourses { get; set; } = new List<BLStudentsOfCourse>();

    //public virtual ICollection<BLTeacherIsAbsent> TeacherIsAbsents { get; set; } = new List<BLTeacherIsAbsent>();

    //public virtual ICollection<BLTeachersOfCourse> TeachersOfCourses { get; set; } = new List<BLTeachersOfCourse>();
}
