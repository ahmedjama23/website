using System;
using System.Collections.Generic;

namespace dotnet.Models.Education
{
    public interface IEducationRepository
    {
        Education getEducation(string institution);
        List<Education> getAllEducation();
    }
}
