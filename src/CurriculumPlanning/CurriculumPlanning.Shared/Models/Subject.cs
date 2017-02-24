using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class Subject
    {
        public Subject()
        {
            Skills = new List<Skill>();
        }

        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }

        public IList<Skill> Skills { get; set; }
    }
}
