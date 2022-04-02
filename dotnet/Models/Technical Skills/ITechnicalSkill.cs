using System;
namespace dotnet.Models.TechnicalSkills
{
    public interface ITechnicalSkill
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
