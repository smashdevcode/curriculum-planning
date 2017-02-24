using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class Course
    {
        public Course()
        {
            Instructors = new List<CourseInstructor>();
            Skills = new List<CourseSkill>();
        }

        public int Id { get; set; }
        public int TopicId { get; set; }
        public int LevelId { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }

        public Topic Topic { get; set; }
        public Level Level { get; set; }
        public IList<CourseInstructor> Instructors { get; set; }
        public IList<CourseSkill> Skills { get; set; }
    }
}
    