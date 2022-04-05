using System;
namespace dotnet.Models.Persona
{
    public class Persona : IPersona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Locale { get; set; }

        //Constructor
        //public Persona(int id, String name, String email, String phone, String locale)
        //{
        //Id = id;
        //Name = name;
        //Email = email;
        //Locale = locale;
        //}

        //Mock Constructor
        public Persona()
        {
            this.Id = 1;
            this.Name = "Ahmed Jama";
            this.Email = "ajama07@hotmail.com";
            this.Locale = "Calgary, AB";
        }
    }
}
