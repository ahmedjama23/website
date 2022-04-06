using System;
using System.Collections.Generic;

namespace dotnet.Models.Responsibilities
{
    public class MockResponsibilityRepository: IResponsibilityRepository
    {

        private List<Responsibility> _responsibilityList;

        public MockResponsibilityRepository()
        {
            _responsibilityList = new List<Responsibility>();

            _responsibilityList.Add(new Responsibility(1, 1, "Provide consulting services and solution implementation for clients tailored to their needs"));
            _responsibilityList.Add(new Responsibility(2, 1, "Development of TSS Maps for Power BI"));
            _responsibilityList.Add(new Responsibility(3, 1, "Assist in demonstrations of TSS Maps for Power BI"));

            _responsibilityList.Add(new Responsibility(4, 2, "Build data visualizations in Tableau"));
            _responsibilityList.Add(new Responsibility(5, 2, "Create and maintain datasets used for business insights"));
            _responsibilityList.Add(new Responsibility(6, 2, "Develop stored procedures for database tables"));
            _responsibilityList.Add(new Responsibility(7, 2, "Data QA / QC"));
            _responsibilityList.Add(new Responsibility(8, 2, "Documentation of table purpose and structure"));

            _responsibilityList.Add(new Responsibility(9, 3, "Promotion of Shaw services (cold calling)"));
            _responsibilityList.Add(new Responsibility(10, 3, "Set up of services for interested customers"));


            _responsibilityList.Add(new Responsibility(11, 4, "Iterative web development"));
            _responsibilityList.Add(new Responsibility(12, 4, "Updating and maintaining content"));
        }

        public List<Responsibility> GetAllResponsibilities()
        {
            return _responsibilityList;
        }

        public Responsibility GetResponsibility(int id)
        {
            return _responsibilityList.Find(x => x.Id == id);
        }
    }
}
