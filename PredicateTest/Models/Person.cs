using System;
using System.Collections.Generic;

namespace PredicateTest
{
    public class Person : IPerson
    {

        private static List<string> _colors = new List<string>() {
            "Orange", "Black", "Orange", "Bald", "Yellow", "Brown"
        };
        private string _haircolor = "";
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor {
            get { return _haircolor; }
            set {
                if (_colors.Contains((value))) { _haircolor = value; }
                else { throw new Exception("Invalid color"); }
            }
        }

        public override string ToString()
        {
            return "[Name = " + Name + ", Age = " + Age + ", HairColor = " + HairColor + "]\n";
        }

        public override bool Equals(object obj)
        {
            bool cond = false;
            Person p = (Person)obj;
            Predicate<Person> PersonEquals = 
                x => x.Age == this.Age && 
                x.Name == this.Name && 
                x.HairColor == this.HairColor;

            if (PersonEquals(p))
            {
                cond = true;        
            }

            return cond;
        }

    }
}
