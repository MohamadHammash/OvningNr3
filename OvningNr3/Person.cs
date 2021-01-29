using System;
using System.Collections.Generic;
using System.Text;

namespace OvningNr3
{
    class Person
    {
       
       
        
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be at least 1");

                }
                else
                {
                    age = value;
                }
            }
        }
       
       
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        
       
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
       
        
        private string fName;
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must be at least 2 characters and not more than 10 characters! ");
                }
                else
                {
                    fName = value;
                }
            }
        }
        
      
        private string lName;
        public string Lname
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must be at least 3 characters and not more than 15 characters! ");
                }
                else
                {
                    lName = value;
                }
                lName = value;
            }
        }

       

       
    }
}
