using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class Skill
    {
        public Skill()
        {
            Courses = new List<CourseSkill>();
        }

        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int LevelId { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        public string Comments { get; set; }
        public bool OutOfScope { get; set; }

        public Subject Subject { get; set; }
        public Level Level { get; set; }

        [JsonIgnore]
        public IList<CourseSkill> Courses { get; set; }
    }
}
