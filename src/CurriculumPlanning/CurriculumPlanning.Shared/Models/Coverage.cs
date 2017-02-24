using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class Coverage
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
    }
}
