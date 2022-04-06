using System;
namespace dotnet.Models.Educations
{
    public class Education: IEducation
    {
        public int Id { get; set;  }
        public string Institution { get; set; }
        public string Program { get; set; }
        public string Locale { get; set; }
        public int BeginYear { get; set; }
        public int EndYear { get; set; }

        public Education()
        {
        }
    }
}
