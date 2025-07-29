using System;
using System.Collections.Generic;

namespace SchoolDAL.Models;

public class TeacherOfSubjectInClass
{
    public int? IdTeacher { get; set; }

    public int? IdSubject { get; set; }

    public string? Class { get; set; }
}
