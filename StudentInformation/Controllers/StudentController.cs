using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInformation.Models;
using System.Data.Entity;

namespace StudentInformation.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext dbcontext;

        public StudentController(AppDbContext context)
        {
            dbcontext = context;
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] Student student)
        {
            try
            {
                Console.WriteLine("Add Student called.");
                dbcontext.Students.Add(student);
                dbcontext.SaveChanges();
                return Ok(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Student called. Exception occured ");
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost("AssignCourses")]
        public IActionResult AssignCourses(int studentId, [FromBody] List<int> courseIds)
        {
            try
            {
                var student = dbcontext.Students.Find(studentId);
                if (student == null)
                {
                    return NotFound("Student not found");
                }

                foreach (var courseId in courseIds)
                {
                    var course = dbcontext.Courses.Find(courseId);
                    if (course != null)
                    {
                        dbcontext.StudentCourses.Add(new StudentCourse { StudentId = studentId, CourseId = courseId });
                    }
                }

                dbcontext.SaveChanges();
                return Ok("Courses assigned successfully");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet("ListStudents")]
        public IActionResult ListStudents()
        {
            try
            {
                var students = dbcontext.Students
                    .Select(s => new
                    {
                        s.Name,
                        s.Email,
                        s.Phone,
                        Courses = string.Join(", ", dbcontext.StudentCourses
                            .Where(sc => sc.StudentId == s.Id)
                            .Join(dbcontext.Courses, sc => sc.CourseId, c => c.Id, (sc, c) => c.CourseName))
                    }).ToList();

                return Ok(students);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }
    }
}
