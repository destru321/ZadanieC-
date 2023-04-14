using System;

namespace ZadanieDomowe
{
    class Person
    {

        private int counter;
        private string[] persons = new string[3];
        public Person(string[] _persons)
        {
            persons = _persons;
        }

        ~Person()
        {
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = "";
            }
            counter = persons.Length;
        }

        public void getPersonByID(int id)
        {
            Console.Write("Osoba ktora wybrales to: ");
            Console.WriteLine(persons[id]);
        }

        public override string ToString()
        {
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(i + " " + persons[i]);
            }
            return "";
        }
    }
}