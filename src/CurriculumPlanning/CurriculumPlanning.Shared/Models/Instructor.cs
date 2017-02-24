using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class Instructor
    {
        public Instructor()
        {
            Courses = new List<CourseInstructor>();
        }

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }

        public IList<CourseInstructor> Courses { get; set; }
    }
}
