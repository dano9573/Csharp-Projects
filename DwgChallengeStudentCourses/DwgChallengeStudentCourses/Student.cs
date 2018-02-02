﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DwgChallengeStudentCourses
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}