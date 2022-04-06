using System;
namespace dotnet.Models.TechnicalSkills
{
    public class TechnicalSkill : ITechnicalSkill
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Type { get; set; }

        //Constructor
        public TechnicalSkill(int id, string name, string type)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }

    }
}