using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string delimetr = new string('#', 20);
            string header = string.Format("\n{0} Check it out about our university {0}\n", delimetr);
            Console.WriteLine(header);

            University univer = new University();
            univer.Lectures.Add(Subject.CSS);
            univer.Lectures.Add(Subject.English);
            univer.Lectures.Add(Subject.History);
            univer.Lectures.Add(Subject.HTML);
            univer.Lectures.Add(Subject.JS);
            univer.Lectures.Add(Subject.Math);

            univer.Teachers.Add(new Teacher(Gender.female, "Galina Seeva", new DateTime(1980, 1, 1), 5, Subject.Math));
            univer.Teachers.Add(new Teacher(Gender.male, "Andrew Hewinsky", new DateTime(1960, 1, 1), 10, Subject.JS));
            univer.Teachers.Add(new Teacher(Gender.female, "Natasha Reeva", new DateTime(1980, 1, 1), 5, Subject.Math));
            univer.Teachers.Add(new Teacher(Gender.male, "Serge Oginsky", new DateTime(1990, 1, 1), 2, Subject.HTML));
            univer.Teachers.Add(new Teacher(Gender.female, "Lisa Retona", new DateTime(1984, 1, 1), 7, Subject.CSS));
            univer.Teachers.Add(new Teacher(Gender.male, "Andrew Nomet", new DateTime(1960, 1, 1), 10, Subject.History));
            univer.Teachers.Add(new Teacher(Gender.female, "Maria Leeva", new DateTime(1980, 1, 1), 8, Subject.Russian));

            univer.TechnoStudents.Add(new TechnoStudent(Gender.male, "Fedor Rotor", new DateTime(2000, 1, 1), 10984));
            univer.TechnoStudents.Add(new TechnoStudent(Gender.male, "Roma Kolot", new DateTime(2001, 1, 1), 10987));

            univer.HumanityStudents.Add(new HumanitaryStudent(Gender.female, "Masha Socket", new DateTime(2000, 1, 1), 10983));
            univer.HumanityStudents.Add(new HumanitaryStudent(Gender.female, "Sveta Gor", new DateTime(2001, 1, 1), 10982));


            TechnoStudent tech = new TechnoStudent();
            HumanitaryStudent hamanity = new HumanitaryStudent();
            Teacher teach = new Teacher();

            void UniverBussiness(List<Subject> lectures)
            {
                foreach (Subject item in lectures)
                {
                    Console.WriteLine($"Take a look, what`s going`on on {item}");
                    if (item == Subject.CSS || item == Subject.HTML || item == Subject.JS || item == Subject.Math)
                    {
                        foreach(TechnoStudent technoSt in univer.TechnoStudents)
                            technoSt.ToLearn();
                        foreach (HumanitaryStudent humanist in univer.HumanityStudents)
                            humanist.ToSleep();
                    }
                    if (item == Subject.English || item == Subject.History || item == Subject.Russian)
                    {
                        foreach (TechnoStudent technoSt in univer.TechnoStudents)
                            technoSt.ToSleep();
                        foreach (HumanitaryStudent humanist in univer.HumanityStudents)
                            humanist.ToLearn();
                    }
                    foreach(Teacher teache in univer.Teachers)
                        teache.ToWork(item);
                    Console.Write("{0, 40}\n", delimetr);
                }
            }
            UniverBussiness(univer.Lectures);
            Console.ReadKey();
        }
    }
}
