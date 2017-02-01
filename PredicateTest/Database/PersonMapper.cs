using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateTest
{
    public class PersonMapper : IPersonMapper
    {

        public IEnumerable<Person> GetPeople() {
            yield return new Person { Name = "Allan", Age = 12, HairColor = "Bald" };
            yield return new Person { Name = "Simon", Age = 14, HairColor = "Black" };
            yield return new Person { Name = "Tove", Age = 15, HairColor = "Brown" };
            yield return new Person { Name = "Lene", Age = 11, HairColor = "Brown" };
        }

        public IEnumerable<Person> GetEveryPersonWithBrownHair() {
            yield return GetPeople().Select(x => x.HairColor == "Brown") as Person;
        }
    }
}
