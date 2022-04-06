using System;
using Microsoft.EntityFrameworkCore;
using dotnet.Models.Educations;
using dotnet.Models.Personas;
using dotnet.Models.TechnicalSkills;
using dotnet.Models.SoftSkills;
using dotnet.Models.Jobs;
using dotnet.Models.Responsibilities;
using Microsoft.Data.Sqlite;

namespace dotnet.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Education> Education { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<TechnicalSkill> TechnicalSkill { get; set; }
        public DbSet<SoftSkill> SoftSkill { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Responsibility> Responsibility { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=lite.db");
    }
}
