using System;
namespace dotnet.Models.TechnicalSkills
{
    public class TechnicalSkill : ITechnicalSkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public TechnicalSkill()
        {
        }

    }
}