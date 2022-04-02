using System;
using System.Collections.Generic;

namespace dotnet.Models.TechnicalSkills
{
    public class MockTechnicalSkillRepository: ITechnicalSkillRepository
    {
        private List<TechnicalSkill> _technicalSkillList;



        //Constructor
        public MockTechnicalSkillRepository()
        {
            _technicalSkillList = new List<TechnicalSkill>();

            _technicalSkillList.Add(new TechnicalSkill(1, "Java", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(2, "JavaScript", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(3, "Python", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(4, "Microsoft SQL", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(5, "PostgreSQL", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(6, "HTML", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(7, "React", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(8, "Node.js", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(9, "CSS", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(10, "PHP", "Language"));

            _technicalSkillList.Add(new TechnicalSkill(11, "Tableau", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(12, "Power BI", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(13, "SSMS", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(14, "Visual Studio Code", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(15, "Visual Studio", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(16, "JIRA", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(17, "Virtual Machines", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(18, "ArcGIS Pro", "Technologies"));
        }

        public List<TechnicalSkill> GetAllTechnicalSkills()
        {
            return _technicalSkillList;
        }

        public TechnicalSkill GetTechnicalSkill(string name)
        {
            return _technicalSkillList.Find(x => x.Name == name);
        }

 
    }
}
