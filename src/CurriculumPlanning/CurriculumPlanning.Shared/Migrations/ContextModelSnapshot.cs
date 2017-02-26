using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CurriculumPlanning.Shared.Data;

namespace CurriculumPlanning.Shared.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LevelId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("TopicId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.CourseSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int>("CoverageId");

                    b.Property<int>("SkillId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("CoverageId");

                    b.HasIndex("SkillId");

                    b.ToTable("CourseSkills");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.CourseTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("CourseTeachers");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Coverage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Coverages");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<int>("LevelId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("OutOfScope");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Course", b =>
                {
                    b.HasOne("CurriculumPlanning.Shared.Models.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId");

                    b.HasOne("CurriculumPlanning.Shared.Models.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.CourseSkill", b =>
                {
                    b.HasOne("CurriculumPlanning.Shared.Models.Course", "Course")
                        .WithMany("Skills")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculumPlanning.Shared.Models.Coverage", "Coverage")
                        .WithMany()
                        .HasForeignKey("CoverageId");

                    b.HasOne("CurriculumPlanning.Shared.Models.Skill", "Skill")
                        .WithMany("Courses")
                        .HasForeignKey("SkillId");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.CourseTeacher", b =>
                {
                    b.HasOne("CurriculumPlanning.Shared.Models.Course", "Course")
                        .WithMany("Teachers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculumPlanning.Shared.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Skill", b =>
                {
                    b.HasOne("CurriculumPlanning.Shared.Models.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId");

                    b.HasOne("CurriculumPlanning.Shared.Models.Subject", "Subject")
                        .WithMany("Skills")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("CurriculumPlanning.Shared.Models.Subject", b =>
                {
                    b.HasOne("CurriculumPlanning.Shared.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
