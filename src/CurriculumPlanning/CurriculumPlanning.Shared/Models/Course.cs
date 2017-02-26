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
            Teachers = new List<CourseTeacher>();
            Skills = new List<CourseSkill>();
        }

        public int Id { get; set; }
        public int TopicId { get; set; }
        public int LevelId { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }

        public Topic Topic { get; set; }
        public Level Level { get; set; }
        public IList<CourseTeacher> Teachers { get; set; }
        public IList<CourseSkill> Skills { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(new CourseTeacher()
            {
                Teacher = teacher
            });
        }

        public Skill AddSkill(Subject subject, string Name, Level level, Coverage coverage, 
            string comments = null)
        {
            var skill = new Skill()
            {
                Subject = subject,
                Name = Name,
                Level = level,
                Comments = comments
            };

            AddSkill(skill, coverage);

            return skill;
        }

        public void AddSkill(Skill skill, Coverage coverage)
        {
            Skills.Add(new CourseSkill()
            {
                Skill = skill,
                Coverage = coverage
            });
        }
    }
}
    