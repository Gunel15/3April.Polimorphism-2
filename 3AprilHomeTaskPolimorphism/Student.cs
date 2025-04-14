using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AprilHomeTaskPolimorphism
{
    public class Student : ICodeAcademy
    {
        public static int Count = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }
         

        public Student(string name,string surname)
        {
            Id = ++Count;
            Name = name;
            Surname = surname;
            GenerateMail();
        }

        public void GenerateMail()
        {
            CodeEmail = Name.ToLower() + "." + Surname.ToLower() + Id + "@code.edu.az";
            Console.WriteLine(CodeEmail);
        }

        //ve ya ayrica showinfo methodu da yaradib codemaili-i consola vermeden hemin metodun icinde butun melumatlari consola vererdik
        
    }
}
