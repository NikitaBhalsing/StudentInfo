﻿namespace StudentInformation.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}