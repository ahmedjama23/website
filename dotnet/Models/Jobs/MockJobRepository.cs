using System;
using System.Collections.Generic;

namespace dotnet.Models.Jobs
{
    public class MockJobRepository: IJobRepository
    {
        private List<Job> _jobList;

        public MockJobRepository()
        {
            _jobList = new List<Job>();

            //var tssResp = new List<string>
            //{
            //    "Provide consulting services and solution implementation for clients tailored to their needs"
            //    ,"Development of TSS Maps for Power BI"
            //    ,"Assist in demonstrations of TSS Maps for Power BI"
            //};
            var tssDesc = "Currently, I am heavily involved with a project to create a solution for a client to allow them to proactively recognize and remedy potential risks through intelligent reporting and analysis using custom algorithms and a unified, central data source that we developed earlier in the project, resulting in millions saved within 5 years. Previously, involved in developing TSS Maps for Power BI, a custom Power BI visual using the ArcGIS API to fill a gap in the GIS technology space. Additionally, previously involved with the implementation of a custom Geographic Information Solution for a client.";

            _jobList.Add(new Job(1, "The Solution Stack", "Software Developer", "Calgary, AB", tssDesc, "February 2019", "Present"));


            //var hrBlockResp = new List<string>
            //{
            //    "Build data visualizations in Tableau"
            //    ,"Create and maintain datasets used for business insights"
            //    ,"Develop stored procedures for database tables"
            //    ,"Data QA / QC"
            //    ,"Documentation of table purpose and structure"
            //};
            var hrBlockDesc = "Involved in data preparation, analysis and management surrounding customer software. Scrum methodology used in scheduling and delegation of tasks. Heavily involved in organization and migration of data from AWS to Snowflake Data Warehouse.";

            _jobList.Add(new Job(2, "H&R Block", "Digital Product Analyst", "Calgary, AB", hrBlockDesc, "September 2016", "February 2019"));

            //var shawResp = new List<string>
            //{
            //    "Promotion of Shaw services (cold calling)"
            //    ,"Set up of services for interested customers"
            //};
            var shawDesc = "Contacted potential customers to provide internet and cable services.";

            _jobList.Add(new Job(3, "Shaw Communications", "Customer Solutions Expert", "Calgary, AB", shawDesc, "January 2016", "September 2016"));


            //var nfnResp = new List<string>
            //{
            //    "Iterative web development"
            //    ,"Updating and maintaining content"
            //};
            var nfnDesc = "Developed company website based on requirements provided by the client.";

            _jobList.Add(new Job(4, "Ninety Five Noir", "Freelance Web Developer", "Calgary, AB", nfnDesc, "November 2015", "December 2016"));
        }

        public List<Job> GetAllJobs()
        {
            return _jobList;
        }

        public Job GetJob(int id)
        {
            return _jobList.Find(x => x.Id == id);
        }
    }
}
