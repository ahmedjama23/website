using System;
using System.Collections.Generic;

namespace dotnet.Models.Responsibilities
{
    public interface IResponsibilityRepository
    {
        public Responsibility GetResponsibility(int id);
        public List<Responsibility> GetAllResponsibilities();
    }
}
