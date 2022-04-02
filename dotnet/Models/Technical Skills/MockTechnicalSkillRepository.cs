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
            _technicalSkillList.Add(new TechnicalSkill(1, "JavaScript", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(1, "Python", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(1, "Microsoft SQL", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(1, "PostgreSQL", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(1, "HTML", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(1, "React", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(1, "Node.js", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(1, "CSS", "Language"));
            _technicalSkillList.Add(new TechnicalSkill(1, "PHP", "Language"));

            _technicalSkillList.Add(new TechnicalSkill(1, "Tableau", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(1, "Power BI", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(1, "SSMS", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(1, "Visual Studio Code", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(1, "Visual Studio", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(1, "JIRA", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(1, "Virtual Machines", "Technologies"));
            _technicalSkillList.Add(new TechnicalSkill(1, "ArcGIS Pro", "Technologies"));
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
