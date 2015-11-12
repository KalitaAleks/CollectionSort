using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Omgtu.CollectionSortExcercise
    {
    public static class PersonComparer
        {
        public static int CompareByName(Person leftPerson, Person rightPerson)
            {
            if (rightPerson == null && leftPerson == null)
                {
                return 0;
                }
            if (leftPerson == null)
                {
                return -1;
                }
            if (rightPerson == null)
                {
                return 1;
                }

            return leftPerson.Name.CompareTo(rightPerson.Name);



            }

        public static int CompareBySurname(Person leftPerson, Person rightPerson)
            {
            return leftPerson.Surname.CompareTo(rightPerson.Surname);


            }

        public static int CompareByGroupNameSurname(Person leftPerson, Person rightPerson)
            {


            if (leftPerson.Group.CompareTo(rightPerson.Group) == 0)
                {
                if (CompareByName(leftPerson, rightPerson) == 0)
                { return CompareBySurname(leftPerson, rightPerson); }
                else return CompareByName(leftPerson, rightPerson);

                }
            else
                return leftPerson.Group.CompareTo(rightPerson.Group);







            }
        }
    }
