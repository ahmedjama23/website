using System;
namespace dotnet.Models.Persona
{
    public class Persona : IPersona
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Locale { get; set; }

        //Constructor
        //public Persona(int id, String name, String email, String phone, String locale)
        //{
        //Id = id;
        //Name = name;
        //Email = email;
        //Phone = phone;
        //Locale = locale;
        //}

        //Mock Constructor
        public Persona()
        {
            Id = 1;
            Name = "Ahmed Jama";
            Email = "ajama07@hotmail.com";
            Phone = "587-707-9670";
            Locale = "Calgary, AB";
        }
    }
}
