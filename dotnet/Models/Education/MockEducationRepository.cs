using System;
using System.Collections.Generic;

namespace dotnet.Models.Education
{
    public class MockEducationRepository: IEducationRepository
    {

        private List<Education> _educationSkillList;

        public MockEducationRepository()
        {
            _educationSkillList = new List<Education>();

            _educationSkillList.Add(new Education(1, "Mount Royal University", "Bachelor of Computer Information Systems", "Calgary, AB", 2013, 2019));
        }

        public List<Education> GetAllEducation()
        {
            return _educationSkillList;
        }

        public Education GetEducation(string institution)
        {
            return _educationSkillList.Find(x => x.Institution == institution);
        }
    }
}
