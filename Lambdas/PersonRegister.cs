using System;
using System.Collections;
using System.Collections.Generic;

namespace Lambdas
{
    internal class PersonRegister : IEnumerable<Person>
    {
        private IList<Person> _listPerson;

        public PersonRegister(IList<Person> listPerson)
        {
            _listPerson = listPerson;
        }

        public IEnumerable<Person> Filter(Func<Person, bool> selector)
        {
            foreach (Person p in _listPerson)
            {
                if (selector(p))
                    yield return p;
            }
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return _listPerson.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}