using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Oblig_1
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;

        public string GetDescription()
        {
            string returnValue = "";
            
            if (FirstName != null)
            {
                returnValue += FirstName + " ";
            }
            if (LastName != null)
            {
                returnValue += LastName + " ";
            }
            if (Id != 0)
            {
                returnValue += "(Id=" + Id + ")";
            }
            if (BirthYear != 0)
            {
                returnValue += " Born: " + BirthYear;
            }
            if (DeathYear != 0)
            {
                returnValue += " Died: " + DeathYear;
            }
            if (Father != null)
            {
                returnValue += " Father: " + Father.FirstName + " (Id=" + Father.Id + ")";
            }
            if (Mother != null)
            {
                returnValue += " Mother: " + Mother.FirstName + " (Id=" + Mother.Id + ")";
            }

            return returnValue;
        }

        

    }
}