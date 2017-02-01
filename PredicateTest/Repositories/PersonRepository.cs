using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateTest
{
    public class PersonRepository
    {
        private static volatile PersonRepository instance;

        public static PersonRepository Instance {
            get {
                if (instance == null) instance = new PersonRepository();
                return instance;
            }
        }

        private IEnumerable<Person> _people = new PersonMapper().GetPeople();

        private PersonRepository() {
        }


        public IEnumerable<Person> GetBrownHaired() {
            foreach(Person p in _people) { 
                if(p.HairColor == "Brown")yield return p;
            }
        }

        public IEnumerable<Person> GetEveryone()
        {
            return _people;
        }

        public void SortListByName()
        {
            _people = _people.OrderBy(x => x.Name).ToList();
        }

        public void SortListByAge()
        {
            _people = _people.OrderBy(x => x.Age).ToList();
        }

        public void SortListByHairColor()
        {
            _people = _people.OrderBy(x => x.HairColor).ToList();
        }
        

    }
}
