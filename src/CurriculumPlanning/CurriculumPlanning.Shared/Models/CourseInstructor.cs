using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class CourseInstructor
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
