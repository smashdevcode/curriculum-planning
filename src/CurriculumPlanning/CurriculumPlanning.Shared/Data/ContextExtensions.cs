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

            if (!context.Courses.Any())
            {
                var coveragePartial = context.Coverages.Add(new Coverage() { Name = "Partial" }).Entity;
                var coverageComplete = context.Coverages.Add(new Coverage() { Name = "Complete" }).Entity;

                var levelBeginner = context.Levels.Add(new Level() { Name = "Beginner" }).Entity;
                var levelIntermediate = context.Levels.Add(new Level() { Name = "Intermediate" }).Entity;
                var levelAdvanced = context.Levels.Add(new Level() { Name = "Advanced" }).Entity;

                var teacherJamesChurchill = context.Teachers.Add(new Teacher() { FirstName = "James", LastName = "Churchill" }).Entity;

                var topicAndroid = context.Topics.Add(new Topic() { Name = "Android" }).Entity;
                var topicBusiness = context.Topics.Add(new Topic() { Name = "Business" }).Entity;
                var topicCSharp = context.Topics.Add(new Topic() { Name = "C#" }).Entity;
                var topicCss = context.Topics.Add(new Topic() { Name = "CSS" }).Entity;
                var topicDataAnalysis = context.Topics.Add(new Topic() { Name = "Data Analysis" }).Entity;
                var topicDatabases = context.Topics.Add(new Topic() { Name = "Databases" }).Entity;
                var topicDesign = context.Topics.Add(new Topic() { Name = "Design" }).Entity;
                var topicDevelopmentTools = context.Topics.Add(new Topic() { Name = "Development Tools" }).Entity;
                var topicDigitalLiteracy = context.Topics.Add(new Topic() { Name = "Digital Literacy" }).Entity;
                var topicGameDevelopment = context.Topics.Add(new Topic() { Name = "Game Development" }).Entity;
                var topicHtml = context.Topics.Add(new Topic() { Name = "HTML" }).Entity;
                var topicIos = context.Topics.Add(new Topic() { Name = "iOS" }).Entity;
                var topicJava = context.Topics.Add(new Topic() { Name = "Java" }).Entity;
                var topicJavaScript = context.Topics.Add(new Topic() { Name = "JavaScript" }).Entity;
                var topicPhp = context.Topics.Add(new Topic() { Name = "PHP" }).Entity;
                var topicPython = context.Topics.Add(new Topic() { Name = "Python" }).Entity;
                var topicRuby = context.Topics.Add(new Topic() { Name = "Ruby" }).Entity;
                var topicVirtualReality = context.Topics.Add(new Topic() { Name = "Virtual Reality" }).Entity;
                var topicWordPress = context.Topics.Add(new Topic() { Name = "WordPress" }).Entity;

                var subjectApi = context.Subjects.Add(new Subject() { Name = "API", Topic = topicCSharp }).Entity;
                var subjectControllers = context.Subjects.Add(new Subject() { Name = "Controllers", Topic = topicCSharp }).Entity;
                var subjectDataAccess = context.Subjects.Add(new Subject() { Name = "Data Access", Topic = topicCSharp }).Entity;
                var subjectDeployment = context.Subjects.Add(new Subject() { Name = "Deployment", Topic = topicCSharp }).Entity;
                var subjectGeneral = context.Subjects.Add(new Subject() { Name = "General", Topic = topicCSharp }).Entity;
                var subjectRouting = context.Subjects.Add(new Subject() { Name = "Routing", Topic = topicCSharp }).Entity;
                var subjectSecurity = context.Subjects.Add(new Subject() { Name = "Security", Topic = topicCSharp }).Entity;
                var subjectTesting = context.Subjects.Add(new Subject() { Name = "Testing", Topic = topicCSharp }).Entity;
                var subjectTooling = context.Subjects.Add(new Subject() { Name = "Tooling", Topic = topicCSharp }).Entity;
                var subjectUserAuthentication = context.Subjects.Add(new Subject() { Name = "User Authentication", Topic = topicCSharp }).Entity;
                var subjectValidation = context.Subjects.Add(new Subject() { Name = "Validation", Topic = topicCSharp }).Entity;
                var subjectViews = context.Subjects.Add(new Subject() { Name = "Views", Topic = topicCSharp }).Entity;

                var courseAspNetMvcWebApiSecurity = new Course()
                {
                    Level = levelIntermediate,
                    Topic = topicCSharp,
                    Title = "ASP.NET MVC and Web API Security"
                };

                courseAspNetMvcWebApiSecurity.AddTeacher(teacherJamesChurchill);

                courseAspNetMvcWebApiSecurity.AddSkill(
                    subjectControllers, "Action Filters", levelBeginner, coverageComplete);
                courseAspNetMvcWebApiSecurity.AddSkill(
                    subjectSecurity, "Open Redirection Prevention", levelBeginner, coverageComplete);
                courseAspNetMvcWebApiSecurity.AddSkill(
                    subjectSecurity, "Preventing Common Attacks", levelBeginner, coverageComplete);
                courseAspNetMvcWebApiSecurity.AddSkill(
                    subjectSecurity, "Preventing SQL Injection", levelBeginner, coverageComplete);
                courseAspNetMvcWebApiSecurity.AddSkill(
                    subjectSecurity, "XSRF/CSRF Prevention", levelBeginner, coverageComplete);

                var courseAspNetMvcBasics = new Course()
                {
                    Level = levelBeginner,
                    Topic = topicCSharp,
                    Title = "ASP.NET MVC Basics"
                };

                courseAspNetMvcBasics.AddTeacher(teacherJamesChurchill);

                courseAspNetMvcBasics.AddSkill(
                    subjectControllers, "Action Methods", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectControllers, "Adding Controllers", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectControllers, "Returning Redirect Result", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectControllers, "Returning View Result", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectDataAccess, "Repository Pattern", levelBeginner, coveragePartial);
                var skillModels = courseAspNetMvcBasics.AddSkill(
                    subjectDataAccess, "Models", levelBeginner, coveragePartial);
                courseAspNetMvcBasics.AddSkill(
                    subjectGeneral, "Adding a Detail View", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectGeneral, "Adding a List View", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectGeneral, "Convention Over Configuration (COC)", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectGeneral, "Don't Repeat Yourself (DRY)", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectGeneral, "MVC Naming Conventions", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectGeneral, "MVC Pattern", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectGeneral, "MVC Project Structure", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectGeneral, "ViewBag", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectRouting, "Default Route", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectRouting, "Routing Overview", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectTesting, "Debugging a Controller Action Method", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectTooling, "Running Your App", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectViews, "Creating Links", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectViews, "Shared Views", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectViews, "Strongly Typed Views", levelBeginner, coverageComplete);
                courseAspNetMvcBasics.AddSkill(
                    subjectViews, "HTML Helper Methods", levelBeginner, coveragePartial);
                courseAspNetMvcBasics.AddSkill(
                    subjectViews, "Razor Overview", levelBeginner, coveragePartial);
                courseAspNetMvcBasics.AddSkill(
                    subjectViews, "Twitter Bootstrap Overview", levelBeginner, coveragePartial);
                courseAspNetMvcBasics.AddSkill(
                    subjectViews, "Using Twitter Bootstrap Grid System", levelBeginner, coveragePartial);

                var courseAspNetMvcForms = new Course()
                {
                    Level = levelBeginner,
                    Topic = topicCSharp,
                    Title = "ASP.NET MVC Forms"
                };

                courseAspNetMvcForms.AddTeacher(teacherJamesChurchill);

                courseAspNetMvcForms.AddSkill(
                    subjectControllers, "Action Verbs", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectControllers, "Model Binding", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectControllers, "Over and Under Posting Data", levelIntermediate, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectGeneral, "Adding an Edit View", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectGeneral, "Handling Deletes", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectGeneral, "TempData", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectValidation, "Client Side Validation", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectValidation, "ModelState", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectValidation, "Server Side Validation", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectValidation, "Using Model Data Annotations", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectViews, "Creating Form Elements", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectViews, "Creating Forms", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectViews, "Partial Views", levelBeginner, coverageComplete);
                courseAspNetMvcForms.AddSkill(
                    subjectViews, "Using Twitter Bootstrap to Style Forms", levelBeginner, coveragePartial);
                courseAspNetMvcForms.AddSkill(
                    subjectViews, "Using Twitter Bootstrap to Style Simple Data Grids", levelBeginner, coveragePartial);

                var courseEntityFrameworkBasics = new Course()
                {
                    Level = levelIntermediate,
                    Topic = topicCSharp,
                    Title = "Entity Framework Basics"
                };

                courseEntityFrameworkBasics.AddTeacher(teacherJamesChurchill);

                courseEntityFrameworkBasics.AddSkill(skillModels, coverageComplete);

                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Adding Data", levelBeginner, coverageComplete);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Code First Workflow", levelBeginner, coverageComplete);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Collection Properties", levelBeginner, coverageComplete);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Context", levelBeginner, coverageComplete);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Deleting Data", levelBeginner, coverageComplete);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "LINQ Detail Queries", levelBeginner, coverageComplete, "First(), FirstOrDefault()");
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "LINQ Including Related Data", levelBeginner, coverageComplete, "Include()");
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "LINQ List Queries", levelBeginner, coverageComplete, "ToList(), Where(), OrderBy(), OrderByDescending()");
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Navigation Properties", levelBeginner, coverageComplete);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "ORM Overview", levelBeginner, coverageComplete);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Updating Data", levelBeginner, coverageComplete);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Monitoring Generated SQL Statements", levelIntermediate, coverageComplete, "DbContext.Database.Log property");
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Code First WorkFlow with Existing Database", levelIntermediate, coveragePartial);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Complex Types", levelIntermediate, coveragePartial);
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Saving Detached Object Graphs", levelIntermediate, coveragePartial, "See https://github.com/refactorthis/GraphDiff");
                courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Using the Fluent API", levelIntermediate, coveragePartial);
                var skillSeedData = courseEntityFrameworkBasics.AddSkill(
                    subjectDataAccess, "Populating Your Database with Seed Data", levelIntermediate, coverageComplete);

                var courseEntityFrameworkMigrations = new Course()
                {
                    Level = levelIntermediate,
                    Topic = topicCSharp,
                    Title = "Entity Framework Migrations"
                };

                courseEntityFrameworkMigrations.AddTeacher(teacherJamesChurchill);

                courseEntityFrameworkMigrations.AddSkill(skillSeedData, coverageComplete);

                courseEntityFrameworkMigrations.AddSkill(
                    subjectDataAccess, "Adding a New Migration", levelBeginner, coverageComplete);
                courseEntityFrameworkMigrations.AddSkill(
                    subjectDataAccess, "Creating Your Initial Migration", levelBeginner, coverageComplete);
                courseEntityFrameworkMigrations.AddSkill(
                    subjectDataAccess, "Database Migrations Overview", levelBeginner, coverageComplete);
                courseEntityFrameworkMigrations.AddSkill(
                    subjectDataAccess, "Enabling Database Migrations", levelBeginner, coverageComplete);
                courseEntityFrameworkMigrations.AddSkill(
                    subjectDataAccess, "Updating Your Database", levelBeginner, coverageComplete);
                courseEntityFrameworkMigrations.AddSkill(
                    subjectDataAccess, "Customizing Database Migrations", levelIntermediate, coverageComplete);
                courseEntityFrameworkMigrations.AddSkill(
                    subjectDataAccess, "Generating SQL Script from Your Migrations", levelIntermediate, coverageComplete);

                context.Courses.AddRange(
                    courseAspNetMvcBasics,
                    courseAspNetMvcForms,
                    courseAspNetMvcWebApiSecurity,
                    courseEntityFrameworkBasics,
                    courseEntityFrameworkMigrations
                );

                // TODO Finish setting up test data.

                //API Adding API Controllers  Basic Building Services with ASP.NET Web API
                //API Adding Web API to a Project Basic Building Services with ASP.NET Web API
                //API API Routing Basic Building Services with ASP.NET Web API
                //API Calling an API Using JavaScript Basic   Building Services with ASP.NET Web API
                //API Interactive Testing with Postman    Basic Building Services with ASP.NET Web API
                //API Web API Overview Basic   Building Services with ASP.NET Web API

                //General Adding Dependency Injection Container   Basic Dependency Injection Workshop
                //General Configuring Dependency Injection Container Basic   Dependency Injection Workshop
                //General Inversion of Control(IoC) Pattern Basic   Dependency Injection Workshop
                //General Using Dependency Injection Basic   Dependency Injection Workshop

                //General App Configuration(web.config appSettings)  Basic Full-Stack Web App with ASP.NET MVC
                //General Bundling    Basic Full-Stack Web App with ASP.NET MVC
                //General Custom Error Views  Basic Full-Stack Web App with ASP.NET MVC
                //General Error Handling Basic   Full - Stack Web App with ASP.NET MVC
                //General Minification    Basic Full-Stack Web App with ASP.NET MVC
                //General Integrating Gulp / Grunt Into the Build Process   Intermediate Full-Stack Web App with ASP.NET MVC This would just cover how to integrate these tools into your project's build, not how to write Gulp/Grunt build scripts
                //General Using JavaScript or CSS Libraries   Intermediate Full-Stack Web App with ASP.NET MVC
                //Views Adding Twitter Bootstrap    Basic Full-Stack Web App with ASP.NET MVC
                //Views Layout Page Sections    Basic Full-Stack Web App with ASP.NET MVC
                //Views Using View Models   Basic Full-Stack Web App with ASP.NET MVC

                //Tooling Adding Packages Basic   Package Management Workshop
                //Tooling Removing Packages   Basic Package Management Workshop
                //Tooling Updating Packages Basic   Package Management Workshop

                //API Unit Testing an API Controller Intermediate    Unit Testing ASP.NET MVC Applications
                //Testing Debugging a View Basic   Unit Testing ASP.NET MVC Applications
                //Testing How to Mock Your Repository Basic   Unit Testing ASP.NET MVC Applications
                //Testing Unit Testing a Controller   Basic Unit Testing ASP.NET MVC Applications
                //Testing Adding a Unit Test Project Basic   Unit Testing in Visual Studio

                //User Authentication Adding a Login View Basic User Authentication with ASP.NET Identity
                //User Authentication Adding a Registration View  Basic User Authentication with ASP.NET Identity
                //User Authentication ASP.NET Identity Overview Basic   User Authentication with ASP.NET Identity
                //User Authentication Authorize Attribute Basic User Authentication with ASP.NET Identity

                //Data Access Controller.UpdateModel Method   Basic Using Entity Framework with ASP.NET MVC Compare using UpdateModel vs manually updating individual properties
                //Data Access Handling Concurrency    Intermediate Using Entity Framework with ASP.NET MVC See http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/handling-concurrency-with-the-entity-framework-in-an-asp-net-mvc-application
                //General Adding a Class Library Project  Intermediate Using Entity Framework with ASP.NET MVC

                //Testing Installing Glimpse Basic   WS: Debugging ASP.NET MVC Applications
                //Testing Logging Basic   WS: Debugging ASP.NET MVC Applications
                //Testing Using Browser Link Basic   WS: Debugging ASP.NET MVC Applications
                //Testing Using Glimpse   Basic WS: Debugging ASP.NET MVC Applications
                //Testing Debugging Into MVC Source Code Intermediate    WS: Debugging ASP.NET MVC Applications Possibly a Workshop?

                context.Skills.AddRange(
                    new Skill() { Subject = subjectViews, Level = levelBeginner, Name = "Passing Data to a View Using ViewData" },
                    new Skill() { Subject = subjectGeneral, Level = levelBeginner, Name = "ViewData" },
                    new Skill() { Subject = subjectApi, Level = levelIntermediate, Name = "API Attribute Routing" },
                    new Skill() { Subject = subjectApi, Level = levelIntermediate, Name = "Content Negotiation" },
                    new Skill() { Subject = subjectApi, Level = levelIntermediate, Name = "Media Formatters" },
                    new Skill() { Subject = subjectControllers, Level = levelIntermediate, Name = "Async Action Methods" },
                    new Skill() { Subject = subjectControllers, Level = levelIntermediate, Name = "Child Actions" },
                    new Skill() { Subject = subjectControllers, Level = levelIntermediate, Name = "Custom Action Filters" },
                    new Skill() { Subject = subjectControllers, Level = levelIntermediate, Name = "Handle Error Filter" },
                    new Skill() { Subject = subjectControllers, Level = levelIntermediate, Name = "Output Cache Filter" },
                    new Skill() { Subject = subjectControllers, Level = levelIntermediate, Name = "Returning Binary Data Result" },
                    new Skill() { Subject = subjectControllers, Level = levelIntermediate, Name = "Working With Binary Data" },
                    new Skill() { Subject = subjectDataAccess, Level = levelIntermediate, Name = "Calling Stored Procedures" },
                    new Skill() { Subject = subjectDataAccess, Level = levelIntermediate, Name = "LINQ Group Queries" },
                    new Skill() { Subject = subjectDataAccess, Level = levelIntermediate, Name = "Running SQL Statements" },
                    new Skill() { Subject = subjectDataAccess, Level = levelIntermediate, Name = "Transactions" },
                    new Skill() { Subject = subjectDeployment, Level = levelIntermediate, Name = "Publish to AWS", Comments = "Possibly a Workshop?" },
                    new Skill() { Subject = subjectDeployment, Level = levelIntermediate, Name = "Publish to Azure", Comments = "Possibly a Workshop?" },
                    new Skill() { Subject = subjectDeployment, Level = levelIntermediate, Name = "Publish to IIS", Comments = "Possibly a Workshop?" },
                    new Skill() { Subject = subjectGeneral, Level = levelIntermediate, Name = "Adding Pagination to a List View" },
                    new Skill() { Subject = subjectGeneral, Level = levelIntermediate, Name = "Application Lifecycle" },
                    new Skill() { Subject = subjectGeneral, Level = levelIntermediate, Name = "Customizing MVC Scaffolding Templates", Comments = "Possibly a Workshop?" },
                    new Skill() { Subject = subjectGeneral, Level = levelIntermediate, Name = "Hosting in IIS", Comments = "Discuss how ASP.NET works in tandem with IIS to process requests" },
                    new Skill() { Subject = subjectGeneral, Level = levelIntermediate, Name = "Image Uploads" },
                    new Skill() { Subject = subjectGeneral, Level = levelIntermediate, Name = "Web Essentials Overview" },
                    new Skill() { Subject = subjectGeneral, Level = levelIntermediate, Name = "ListBox and ListBoxFor" },
                    new Skill() { Subject = subjectGeneral, Level = levelIntermediate, Name = "Cascading Drop Down Lists", Comments = "Maybe a workshop to cover using AJAX for this?" },
                    new Skill() { Subject = subjectRouting, Level = levelIntermediate, Name = "Custom Routes" },
                    new Skill() { Subject = subjectUserAuthentication, Level = levelIntermediate, Name = "Adding Third Party OAuth Providers" },
                    new Skill() { Subject = subjectUserAuthentication, Level = levelIntermediate, Name = "Custom Authorize Attribute" },
                    new Skill() { Subject = subjectUserAuthentication, Level = levelIntermediate, Name = "OAuth Overview" },
                    new Skill() { Subject = subjectUserAuthentication, Level = levelIntermediate, Name = "Restricting Access by User Role" },
                    new Skill() { Subject = subjectViews, Level = levelIntermediate, Name = "Inline Custom HTML Helper Methods (@helper)" },
                    new Skill() { Subject = subjectViews, Level = levelIntermediate, Name = "RenderAction" },
                    new Skill() { Subject = subjectApi, Level = levelAdvanced, Name = "Customizing Media Formatters", OutOfScope = true },
                    new Skill() { Subject = subjectControllers, Level = levelAdvanced, Name = "Custom Model Binding", OutOfScope = true },
                    new Skill() { Subject = subjectControllers, Level = levelAdvanced, Name = "Using Attribute Routing with MVC", OutOfScope = true },
                    new Skill() { Subject = subjectGeneral, Level = levelAdvanced, Name = "Globalization", OutOfScope = true, Comments = "See http://www.hanselman.com/blog/GlobalizationInternationalizationAndLocalizationInASPNETMVC3JavaScriptAndJQueryPart1.aspx" },
                    new Skill() { Subject = subjectGeneral, Level = levelAdvanced, Name = "Organizing with Areas", OutOfScope = true },
                    new Skill() { Subject = subjectGeneral, Level = levelAdvanced, Name = "Sharing Code Between Sites", OutOfScope = true },
                    new Skill() { Subject = subjectViews, Level = levelAdvanced, Name = "Custom HTML Helper Methods Using Composition", OutOfScope = true },
                    new Skill() { Subject = subjectViews, Level = levelAdvanced, Name = "Custom HTML Helper Methods with Inner Content", OutOfScope = true },
                    new Skill() { Subject = subjectViews, Level = levelAdvanced, Name = "MVC View Engines", OutOfScope = true },
                    new Skill() { Subject = subjectViews, Level = levelAdvanced, Name = "Templated HTML Helper Methods", OutOfScope = true, Comments = "Html.Editor, Html.EditorFor, Html.EditorForModel methods" }
                );

                context.SaveChanges();
            }
        }
    }
}
