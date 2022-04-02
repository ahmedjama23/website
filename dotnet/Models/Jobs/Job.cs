using System;
using System.Collections.Generic;

namespace dotnet.Models.Jobs
{
    public class Job: IJob
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Locale { get; set; }
        public List<string> Responsibilities { get; set; }
        public string Description { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }


        public Job(int id, string company, string position, string locale, List<string> resp, string desc, string beginDate, string endDate)
        {
            this.Id = id;
            this.Company = company;
            this.Position = position;
            this.Locale = locale;
            this.Responsibilities = resp;
            this.Description = desc;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
        }
    }
}
