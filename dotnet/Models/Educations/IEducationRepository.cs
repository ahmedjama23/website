using System;
using System.Collections.Generic;

namespace dotnet.Models.Educations
{
    public interface IEducationRepository
    {
        Education GetEducation(string institution);
        List<Education> GetAllEducation();
    }
}
