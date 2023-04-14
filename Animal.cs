using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    public abstract class Animal
    {
        public string name;

        public abstract void SetName(string name);
        public abstract string GetName();
        public abstract void Eat();

    }

    class Dog : Animal
    { 
        public override void SetName(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override void Eat()
        {
            System.Console.WriteLine("Twoj pies wlasnie zjadl");
        }

        public string Sound()
        {
            return "Wof wof";
        }
    }

    class Cat : Animal
    {
        public override void SetName(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override void Eat()
        {
            System.Console.WriteLine("Twoj kot wlasnie zjadl");
        }

        public string Sound()
        {
            return "Miau";
        }
    }

    class Pig : Animal
    {
        public override void SetName(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override void Eat()
        {
            System.Console.WriteLine("Twoja swinka wlasnie zjadla");
        }
        public string Sound()
        {
            return "Chrum chrum";
        }
    }
}
