using System;
using System.Collections.Generic;
using Microsoft.ProjectOxford.Face.Contract;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCameraSample
{
    static class Extensions
    {
        public static bool NoneEmpty(this List<Person> list)
        {
            bool check = false;
            foreach (Person p in list)
            {
                if (p.ComparePerson(new Person()))
                    check = true;
            }
            return check;
        }

        public static bool ComparePerson(this Person a, Person b)
        {
            return (a.Name == b.Name && a.PersistedFaceIds == b.PersistedFaceIds && a.PersonId == b.PersonId && a.UserData == b.UserData);
        }

        public static Person FindByID(this List<Person> a, Guid personID)
        {
            foreach(Person p in a)
            {
                if (p.PersonId == personID)
                    return p;
            }
            return new Person();
        }
    }
}
