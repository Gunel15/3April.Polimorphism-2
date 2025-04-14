using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AprilHomeTaskPolimorphism
{
    interface ICodeAcademy
    {
        public string CodeEmail { get; set; }

        void GenerateMail();
    }
}
