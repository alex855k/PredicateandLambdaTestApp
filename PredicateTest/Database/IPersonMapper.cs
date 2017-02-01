using System.Collections.Generic;

namespace PredicateTest
{
    public interface IPersonMapper
    {
        IEnumerable<Person> GetPeople();
        IEnumerable<Person> GetEveryPersonWithBrownHair();
    }
}