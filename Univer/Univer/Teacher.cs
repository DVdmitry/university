using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class Teacher : Human
    {
        public int Experience { get; set; }
        public Subject mySubject;
        public Teacher(Gender some, string name, DateTime year, int exper, Subject mySubj) : base(some, name, year)
        {
            this.Experience = exper;
            this.mySubject = mySubj;
        }
        public Teacher()
        {
        }

        public void ToWork(Subject subj)
        {
            if(mySubject == subj)
                Console.WriteLine(string.Format("{0} is working hard {1} is her subject", this.FullName, subj));
            else
                Console.WriteLine(string.Format("{0} is having a rest", this.FullName));
        }
    }
}
