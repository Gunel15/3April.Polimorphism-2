using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AprilHomeTaskPolimorphism
{
    abstract class Student : ICodeAcademy
    {
        public static int Count = 0;
        public int Id;
        public string Name;
        public string Surname;

        protected Student()
        {
            Id = ++Count;
        }

        public string CodeEmail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static void CheckName(string name)
        {

        }


        public void GenerateMail(string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            Id = id;
            string combineWords = Name + "." + Surname;
            Console.WriteLine(combineWords);
        }
    }
}
