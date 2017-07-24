using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class HumanitaryStudent : Student, ILearn
    {
        public HumanitaryStudent(Gender some, string name, DateTime year, int id) : base(some, name, year, id)
        {
        }
        public HumanitaryStudent() { }

        public void ToLearn()
        {
            Console.WriteLine(string.Format("{0} is of humanity discipline, and is learning", this.FullName));
        }
        public void ToSleep()
        {
            Console.WriteLine(string.Format("{0} is of humanity discipline, and is sleeping", this.FullName));
        }
    }
}
