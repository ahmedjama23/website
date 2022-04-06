using System;
namespace dotnet.Models.Personas
{
    public class Persona : IPersona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Locale { get; set; }

        public Persona()
        {
        }
    }
}
