using System;
using System.Collections.Generic;

namespace dotnet.Models.Education
{
    public interface IEducationRepository
    {
        Education GetEducation(string institution);
        List<Education> GetAllEducation();
    }
}
