using System;
using System.Collections.Generic;

namespace Lambdas
{
    internal class PersonRegister
    {
        private IList<Person> _listPerson;

        public PersonRegister(IList<Person> listPerson)
        {
            _listPerson = listPerson;
        }

        public IEnumerable<Person> GetAll()
        {
            return _listPerson;
        }

        public IEnumerable<Person> Filter(Func<Person, bool> selector)
        {
            foreach (Person p in _listPerson)
            {
                if (selector(p))
                    yield return p;
            }
        }
    }
}