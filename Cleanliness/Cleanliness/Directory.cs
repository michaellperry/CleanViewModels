using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cleanliness
{
    public class Directory
    {
        public List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person { Id = 1 },
                new Person { Id = 2 },
                new Person { Id = 3 }
            };
        }

        public Person LoadPerson(int personId)
        {
            throw new NotImplementedException();
        }
    }
}
