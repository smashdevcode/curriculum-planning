using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurriculumPlanning.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Username { get; set; }
        [Required, StringLength(255)]
        public string Email { get; set; }
    }
}
