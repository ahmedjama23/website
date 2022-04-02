using System;
using System.Collections.Generic;

namespace dotnet.Models.Jobs
{
    public interface IJobRepository
    {
        public Job GetJob(int id);
        public List<Job> GetAllJobs();
    }
}
