using System;
namespace dotnet.Models.SoftSkills
{
    public class SoftSkill : ISoftSkill
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Subtitle { get; set; }

        //Constructor
        public SoftSkill(int id, string title, string subtitle)
        {
            this.Id = id;
            this.Title = title;
            this.Subtitle = subtitle;
        }

    }
}