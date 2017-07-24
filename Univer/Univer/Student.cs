using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    abstract class Student : Human
    {
        public int Id { get; set; }
        public Student(Gender some, string name, DateTime year, int id) : base(some, name, year)
        {
            this.Id = id;
        }
        public Student() { }


    }
}
