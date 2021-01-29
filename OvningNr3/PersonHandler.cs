using System;
using System.Collections.Generic;
using System.Text;

namespace OvningNr3
{
    class PersonHandler 
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }
        public void SetLName(Person pers, string lName)
        {
            pers.Lname = lName;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height ;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            SetAge(person, age);
            SetFName(person, fname);
            SetLName(person, lname);
            SetWeight(person, weight);
            SetHeight(person, height);

            return person;
            
        }
       
    }
}
