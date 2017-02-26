using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class CourseTeacher
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TeacherId { get; set; }

        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
