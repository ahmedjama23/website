using System;
namespace dotnet.Models.Education
{
    public class Education: IEducation
    {
        public int Id { get; }
        public string Institution { get; set; }
        public string Program { get; set; }
        public string Locale { get; set; }
        public int BeginYear { get; set; }
        public int EndYear { get; set; }

        public Education(int id, string institution, string program, string locale, int beginYear, int endYear)
        {
            this.Id = id;
            this.Institution = institution;
            this.Program = program;
            this.Locale = locale;
            this.BeginYear = beginYear;
            this.EndYear = endYear;
        }
    }
}
