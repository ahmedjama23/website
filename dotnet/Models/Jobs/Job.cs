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
        public string Description { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }


        public Job()
        {
        }
    }
}
