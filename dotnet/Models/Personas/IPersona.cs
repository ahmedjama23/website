using System;
namespace dotnet.Models.Personas
{
    public interface IPersona
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Locale { get; set; }
    }
}
