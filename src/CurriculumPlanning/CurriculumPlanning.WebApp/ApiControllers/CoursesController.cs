using CurriculumPlanning.Shared.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculumPlanning.WebApp.ApiControllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private Context _context;

        public CoursesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var courses = _context.Courses
                .Include(c => c.Topic)
                .Include(c => c.Level)
                .Include(c => c.Teachers)
                    .ThenInclude(ct => ct.Teacher)
                //.Include(c => c.Skills)
                //    .ThenInclude(cs => cs.Skill)
                //        .ThenInclude(s => s.Subject)
                //.Include(c => c.Skills)
                //    .ThenInclude(cs => cs.Skill)
                //        .ThenInclude(s => s.Level)
                //.Include(c => c.Skills)
                //    .ThenInclude(cs => cs.Coverage)
                .OrderBy(c => c.Title)
                .ToList();

            return Ok(courses);
        }
    }
}
