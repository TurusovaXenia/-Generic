using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7Generic
{
    public class Master : Premiator
    {
        public string Name { get; set; }
       

        public override void OnEvent(List<Premiator> obj)
        {
            if (obj.Contains(this))
            {
                Console.WriteLine(Name + " получатель премии!!!");
            }
            else
            {
                Console.WriteLine(Name + " не получатель премии:(");
            }
        }
    }
}
