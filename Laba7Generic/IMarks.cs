using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7Generic
{
   public interface IMarks
    {
        Dictionary<int,Marks> MarksStudent { get; set; }
    }
}
