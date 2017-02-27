using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Courses = new List<CourseTeacher>();
        }

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }

        [JsonIgnore]
        public IList<CourseTeacher> Courses { get; set; }
    }
}
