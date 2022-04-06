using System;
namespace dotnet.Models.SoftSkills
{
    public class SoftSkill : ISoftSkill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }


        public SoftSkill()
        {
        }

    }
}