using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Marks mark1 = new Marks() { data = new DateTime(2017, 03, 14), Mark = 5 };
            Marks mark2 = new Marks() { data = new DateTime(2017, 03, 14), Mark = 4 };
            Marks mark3 = new Marks() { data = new DateTime(2017, 03, 14), Mark = 3 };
            Marks mark4 = new Marks() { data = new DateTime(2017, 03, 14), Mark = 2 };

            Marks mark5 = new Marks() { data = new DateTime(2017, 04, 14), Mark = 5 };
            Marks mark6 = new Marks() { data = new DateTime(2017, 04, 14), Mark = 4 };
            Marks mark7 = new Marks() { data = new DateTime(2017, 04, 14), Mark = 3 };
            Marks mark8 = new Marks() { data = new DateTime(2017, 04, 14), Mark = 2 };

            Dictionary<int, Marks> PerfectDictionary = new Dictionary<int, Marks>();
            PerfectDictionary.Add(1, mark1);
            PerfectDictionary.Add(2, mark5);

            Dictionary<int, Marks> GoodDictionary = new Dictionary<int, Marks>();
            GoodDictionary.Add(1, mark2);
            GoodDictionary.Add(2, mark6);

            Dictionary<int, Marks> NormasDictionary = new Dictionary<int, Marks>();
            NormasDictionary.Add(1, mark3);
            NormasDictionary.Add(2, mark7);

            Dictionary<int, Marks> BadDictionary = new Dictionary<int, Marks>();
            BadDictionary.Add(1, mark4);
            BadDictionary.Add(2, mark8);

            AcademStudent AcadStud1 = new AcademStudent();
            AcademStudent AcadStud2 = new AcademStudent();

            CorseStudent CorseStud1 = new CorseStudent() { MarksStudent = GoodDictionary };
            CorseStudent CorseStud2 = new CorseStudent() { MarksStudent = BadDictionary };

            GraduateStudent Acper1 = new GraduateStudent() { Name = "Василий", MarksStudent = PerfectDictionary };
            GraduateStudent Acper2 = new GraduateStudent() { Name = "Анатолий", MarksStudent = GoodDictionary };

            Master Master1 = new Master() { Name = "Филипп", MarksStudent = PerfectDictionary };
            Master Master2 = new Master() { Name = "Ронни", MarksStudent = NormasDictionary };

            Student Stud1 = new Student() { Name = "Aристарх", MarksStudent = PerfectDictionary };
            Student Stud2 = new Student() { Name = "Василиса", MarksStudent = NormasDictionary };

            Backelor Bac1 = new Backelor() { Name = "Венислав", MarksStudent = PerfectDictionary };
            Backelor Bac2 = new Backelor() { Name = "Дартя Вейдер", MarksStudent = NormasDictionary };

            var Dec = new Decanat<Premiator>();
            //Dec.Registration(AcadStud1);
            //Dec.Registration(CorseStud1);
            Dec.Registration(Acper1);
            Dec.Registration(Acper2);
            Dec.Registration(Master1);
            Dec.Registration(Master2);
            Dec.Registration(Stud1);
            Dec.Registration(Stud2);
            Dec.Registration(Bac1);
            Dec.Registration(Bac2);

            Dec.CheckPremia();
            Console.ReadKey();













        }
    }
}
