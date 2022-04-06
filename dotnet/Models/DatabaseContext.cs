using System;
using Microsoft.EntityFrameworkCore;
using dotnet.Models.Educations;
using dotnet.Models.Personas;
using dotnet.Models.TechnicalSkills;
using dotnet.Models.SoftSkills;
using dotnet.Models.Jobs;
using Microsoft.Extensions.Configuration;

namespace dotnet.Models
{
    public class DatabaseContext : DbContext
    {
        //public DbSet<Education> Educations { get; set; }
        public DbSet<Persona> Personas { get; set; }
        //public DbSet<TechnicalSkill> TechnicalSkills { get; set; }
        //public DbSet<SoftSkill> SoftSkills { get; set; }
        //public DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("lite.db");
    }
}
