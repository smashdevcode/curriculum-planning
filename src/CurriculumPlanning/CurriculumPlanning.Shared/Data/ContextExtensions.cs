using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CurriculumPlanning.Shared.Models;

namespace CurriculumPlanning.Shared.Data
{
    public static class ContextExtensions
    {
        // TODO Setup a more sophisticated seed data routine.
        // See the aspnet/MusicStore sample app for inspiration:
        // https://raw.githubusercontent.com/aspnet/MusicStore/dev/samples/MusicStore/Models/SampleData.cs
        public static void EnsureSeedData(this Context context)
        {
            if (!context.AllMigrationsApplied())
                return;

            if (!context.Coverages.Any())
            {
                context.Coverages.AddRange(
                    new Coverage() { Name = "Partial" },
                    new Coverage() { Name = "Complete" }
                );
                context.SaveChanges();
            }
        }
    }
}
