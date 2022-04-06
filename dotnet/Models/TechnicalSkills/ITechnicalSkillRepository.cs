using System;
using System.Collections.Generic;

namespace dotnet.Models.TechnicalSkills
{
    public interface ITechnicalSkillRepository
    {
        TechnicalSkill GetTechnicalSkill(string name);

        List<TechnicalSkill> GetAllTechnicalSkills();
    }
}
