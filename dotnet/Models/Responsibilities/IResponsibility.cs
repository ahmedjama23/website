using System;
namespace dotnet.Models.Responsibilities
{
    public interface IResponsibility
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string Description { get; set; }
    }
}
