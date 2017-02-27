using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class Topic
    {
        public Topic()
        {
            Courses = new List<Course>();
        }

        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }

        [JsonIgnore]
        public IList<Course> Courses { get; set; }
    }
}
