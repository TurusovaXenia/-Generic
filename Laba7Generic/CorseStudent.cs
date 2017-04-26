using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7Generic
{
    public class CorseStudent : IMarks
    {
        public Dictionary<int, Marks> MarksStudent { get; set; } = new Dictionary<int, Marks>();

    }
}

