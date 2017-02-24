using CurriculumPlanning.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculumPlanning.Shared.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<CourseSkill> CourseSkills { get; set; }
        public DbSet<Coverage> Coverages { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TopicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Level)
                .WithMany()
                .HasForeignKey(c => c.LevelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseInstructor>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(ci => ci.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseSkill>()
                .HasOne(cs => cs.Skill)
                .WithMany(s => s.Courses)
                .HasForeignKey(cs => cs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseSkill>()
                .HasOne(cs => cs.Coverage)
                .WithMany()
                .HasForeignKey(cs => cs.CoverageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Skill>()
                .HasOne(s => s.Subject)
                .WithMany(s => s.Skills)
                .HasForeignKey(s => s.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Skill>()
                .HasOne(s => s.Level)
                .WithMany()
                .HasForeignKey(s => s.LevelId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
