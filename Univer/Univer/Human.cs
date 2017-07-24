using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    abstract class Human
    {
        public Gender manOrWoman;
        public string FullName { get; set; }
        public DateTime BirthYear { get; set; }
        public Human(Gender some, string fullName, DateTime birthYear)
        {
            this.manOrWoman = some;
            this.FullName = fullName;
            this.BirthYear = birthYear;
        }
        public Human()
        {
        }
    }
}
