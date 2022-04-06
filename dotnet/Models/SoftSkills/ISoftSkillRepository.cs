using System;
using System.Collections.Generic;

namespace dotnet.Models.SoftSkills
{
    public interface ISoftSkillRepository
    {
        SoftSkill GetSoftSkill(int id);

        List<SoftSkill> GetAllSoftSkills();
    }
}
