using System;
using System.Collections.Generic;

namespace OvningNr3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            //try
            //    {
            //        person.Age = 0;
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }


            PersonHandler personHandler = new PersonHandler();
            personHandler.CreatePerson(27, "Ahmad ", "Ibrahim ", 171, 72);
            personHandler.CreatePerson(33, "Annika ", "Andersson ", 169, 62);
            personHandler.CreatePerson(45, "Peter ", "Persson ", 171, 75);

            List<Animal> animals = new List<Animal>();
            animals.Add(new Horse(15, "Kalle", 240, "Mamals", "Arabian"));
            animals.Add(new Dog(4, "Fluffy", 15, "Mammal", "Poodle"));
            animals.Add(new Pelican(2, "pepe", 13, "Birds", "Black and white", 12));
            animals.Add(new WolfMan(25, "Wolverine", 100, "Mammals", "Canada", 6));
            
            foreach (var animal in animals)
            {
                if (animal is IPerson)
                {
                    // cast an Iperson
                    IPerson iPerson = (IPerson)animal;
                    Console.WriteLine($"{ animal.Stats()} and says:  {iPerson.Talk()} ");
                }
                else if (animal is Dog)
                {
                    // cast a Dog
                    Dog dog = (Dog)animal;
                    Console.WriteLine($"{ animal.Stats()} and sound like: {animal.DoSound()} and dont forget to {dog.WhatEver()}");
                    
                }
                else
                {
                    Console.WriteLine($"{ animal.Stats()} and sound like: {animal.DoSound()}");

               }
            }
           
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog(10, "Max", 25, "Mamals", "Husky"));
            //  dogs.Add(new Horse (15, "Kalle", 240, "Mamals", "Arabian")); (3.3) 9 
            foreach (Animal dog in dogs)
            {
                
                Console.WriteLine("The dogs list");
                Console.WriteLine($"{ dog.Stats()} and sound like: {dog.DoSound()}");
            }


            List<UserError> userErrors = new List<UserError>();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            foreach (var userErorr in userErrors)
            {
                Console.WriteLine($"{userErorr.UEMessage()}");
            }
            




        }

       


        // ToDo : AddAnimal method.
    }
}
