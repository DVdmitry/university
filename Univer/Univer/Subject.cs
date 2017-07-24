using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    public enum Subject
    {
        None = 0,
        English = 1,
        History = 1 << 1,
        Russian = 1 << 2,
        Math = 1 << 3,
        JS = 1 << 4,
        CSS = 1 << 5,
        HTML = 1 << 6
    }
}
