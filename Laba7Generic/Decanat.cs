using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7Generic
{
    public delegate void GetPremiaHandler(List<Premiator> obj);
    public class Decanat<T> where T : Premiator
    {
        private List<T> SelectedStudent = new List<T>();

        public event GetPremiaHandler GivePremia;

        public void Registration(T person)
        {
            GivePremia += person.OnEvent;
            SelectedStudent.Add(person);
        }

        public void CheckPremia()
        {
            List<Premiator> PremiaStudents = new List<Premiator>();
                foreach (var a in SelectedStudent)
                {
                    double sum = 0;
                    int count = 0;
                
                    foreach (var i in a.MarksStudent.Values)
                    {
                        if (DateTime.Now.Day - i.data.Day <= 30)
                        {
                            sum += i.Mark;
                            count++;
                        }
                    }
                    if (sum / count >= 4.5)
                    {
                        PremiaStudents.Add(a);
                    }
                }
            GivePremia.Invoke(PremiaStudents);
            }
        }
    }

