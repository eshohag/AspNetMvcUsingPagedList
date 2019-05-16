using System.Collections.Generic;
using AspNetMvcUsingPagedList.Models;

namespace AspNetMvcUsingPagedList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMvcUsingPagedList.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetMvcUsingPagedList.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            List<Student> students = new List<Student>()
            {
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},
                new Student(){Name = "Jon Doe",Email = "jon@gmail.com",Department = "CSE"},

            };

            context.Students.AddRange(students);
            base.Seed(context);
        }
    }
}
