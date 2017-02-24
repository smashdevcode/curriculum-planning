using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class CourseSkill
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int SkillId { get; set; }
        public int CoverageId { get; set; }

        public Course Course { get; set; }
        public Skill Skill { get; set; }
        public Coverage Coverage { get; set; }
    }
}
