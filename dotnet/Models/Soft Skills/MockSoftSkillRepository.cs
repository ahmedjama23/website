using System;
using System.Collections.Generic;

namespace dotnet.Models.SoftSkills
{
    public class MockSoftSkillRepository: ISoftSkillRepository
    {
        private List<SoftSkill> _softSkillList;



        //Constructor
        public MockSoftSkillRepository()
        {
            _softSkillList = new List<SoftSkill>();

            _softSkillList.Add(new SoftSkill(1, "Solution-oriented approach", "can-do mentality for overcoming adversity"));
            _softSkillList.Add(new SoftSkill(2, "Time management", "able to manage workload from multiple concurrent projects through effective prioritization and time allocation"));
            _softSkillList.Add(new SoftSkill(3, "Presentation", "Confident and collected when presenting to stakeholders"));
        }

        public List<SoftSkill> GetAllSoftSkills()
        {
            return _softSkillList;
        }

        public SoftSkill GetSoftSkill(int id)
        {
            return _softSkillList.Find(x => x.Id == id);
        }
    }
}
