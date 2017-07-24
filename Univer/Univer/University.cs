using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class University
    {
        public List<Human> Humans = new List<Human>();
        public List<Subject> Lectures = new List<Subject>();
        public List<TechnoStudent> TechnoStudents = new List<TechnoStudent>();
        public List<HumanitaryStudent> HumanityStudents = new List<HumanitaryStudent>();
        public List<Teacher> Teachers = new List<Teacher>();
    }
}
