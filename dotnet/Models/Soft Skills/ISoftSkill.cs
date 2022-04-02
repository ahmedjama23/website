using System;
namespace dotnet.Models.SoftSkills
{
    public interface ISoftSkill
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
    }
}
