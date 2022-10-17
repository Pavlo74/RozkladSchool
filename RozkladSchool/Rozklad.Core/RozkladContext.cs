using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class RozkladContext : IdentityDbContext<User>
    {
        public RozkladContext(DbContextOptions<RozkladContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
    }
}
