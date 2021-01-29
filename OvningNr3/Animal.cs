using System;
using System.Collections.Generic;
using System.Text;

namespace OvningNr3
{
    public interface IPerson
    {
        string Talk();
    }

    public abstract class Animal
    {
        public int AnimalAge { get; set; }
        public string AnimalName { get; set; }
        public double AnimalWeight { get; set; }
        public string AnimalClass { get; set; }
        // These proporties exist in all the classes that inherits from this class
        public Animal(int animalAge, string animalName, double animalWeight, string animalClass)
        {
            AnimalAge = animalAge;
            AnimalName = animalName;
            AnimalWeight = animalWeight;
            AnimalClass = animalClass;
        }
        // the contructor here allows us to set the value of these proporties and each class 
        // that will inherit from this class has to have a constructor with the same arguments followed by 
        // a colon : and the keyword base(animalAge, animalName ...etc) with the variables inside the paranthesis like that  
        public abstract string DoSound();
        // this abstract method can only be declared in an abstract class and MUST be invoked in all
        // the classes that inherist from this abstract class.
        // public string Talk()
        //  {
        // here we can implement the method from the interface if we want all the animals 
        // to invoke the method
        // return $"{this.GetType().Name} says {talk}";
        //  }
        public virtual string Stats()
        {
            return $"name is: {AnimalName} Age is: {AnimalAge} Weight is: {AnimalWeight} Class is: {AnimalClass}";
        }
    }
    class Horse : Animal
    {
        public string Breed { get; set; }
        //this proporty here is unique to this class and must be included
        // as an argument in this class's constructor and initlized inside the constructor.
        public Horse(int animalAge, string animalName, double animalWeight, string animalClass, string breed) : base(animalAge, animalName, animalWeight, animalClass)
        {
            Breed = breed;
        }
        public override string DoSound()
        {
            return "neigh neigh";
        }
        // This is an implementation of the abstract method from the abstract class.
        // it's a must-do implementation as long as this class inherits from the abstact class. 
        public override string Stats()
        {
            var temp = base.Stats();
            string horseStats = $"The horse's {temp} Breed: {Breed}";
            return horseStats;

        }

    }
    class Dog : Animal
    {
        public string DogCategory { get; set; }
        // a unique proporty of the Dog 
        public Dog(int animalAge, string animalName, double animalWeight, string animalClass, string dogCategory) : base(animalAge, animalName, animalWeight, animalClass)
        {
            DogCategory = dogCategory;
        }
        public override string DoSound()
        {
            return "wuf wuf";
        }
        public override string Stats()
        {
            var temp = base.Stats();
            string dogStats = $"The dog's {temp} Category: {DogCategory}";
            return dogStats;
        }
        public string WhatEver() // 3.3 15 
        {
            return "Treat the dog well";
        }
    }
    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(int animalAge, string animalName, double animalWeight, string animalClass, int nrOfSpikes) : base(animalAge, animalName, animalWeight, animalClass)
        {
            NrOfSpikes = nrOfSpikes;
        }
        public override string DoSound()
        {
            return "peff peff";
        }
        public override string Stats()
        {
            var temp = base.Stats();
            string HodgehogStats = $"The hedgehog's {temp} Number of spikes {NrOfSpikes}";
            return HodgehogStats;
        }
    }
    class Worm : Animal
    {
        public string DoesItBite { get; set; }
        public Worm(int animalAge, string animalName, double animalWeight, string animalClass, string doesItBite) : base(animalAge, animalName, animalWeight, animalClass)
        {
            DoesItBite = doesItBite;
        }
        public override string DoSound()
        {
            return "er";
        }
        public override string Stats()
        {
            var temp = base.Stats();
            string wormStats = $"The worm's {temp} Biting ability: {DoesItBite}";
            return wormStats;
        }
    }
    class Bird : Animal
    {
        public string FeatherColor { get; set; }
        public Bird(int animalAge, string animalName, double animalWeight, string animalClass, string featherColor) : base(animalAge, animalName, animalWeight, animalClass)
        {
            FeatherColor = featherColor;
        }
        public override string DoSound()
        {
            return "chirp chirp ";
        }
        public override string Stats()
        {
            var temp = base.Stats();
            string birdStats = $"The bird's {temp} Feather Color: {FeatherColor}";
            return birdStats;
        }
    }
    class Wolf : Animal
    {
        public string HomeCountry { get; set; }
        public Wolf(int animalAge, string animalName, double animalWeight, string animalClass, string homeCountry) : base(animalAge, animalName, animalWeight, animalClass)
        {
            HomeCountry = homeCountry;
        }
        public override string DoSound()
        {
            return "owooooo";
        }
        public override string Stats()
        {
            var temp = base.Stats();
            string wolfStats = $"{temp} Home Country: {HomeCountry}";
            return wolfStats;
        }
    }
    class Pelican : Bird
    {
        public int DaysOfFly { get; set; }
        public Pelican(int animalAge, string animalName, double animalWeight, string animalClass, string featherColor, int daysOfFly) : base(animalAge, animalName, animalWeight, animalClass, featherColor)
        {
            DaysOfFly = daysOfFly;
        }
        public override string Stats()
        {
            var temp = base.Stats();
            string pelicanStats = $"{temp} and can fly for: {DaysOfFly} days";  // ToDo: check the output for later
            return pelicanStats;
        }

    }
    class Flamingo : Bird
    {
        public int EggsPerYear { get; set; }
        public Flamingo(int animalAge, string animalName, double animalWeight, string animalClass, string featherColor, int eggsPerYear) : base(animalAge, animalName, animalWeight, animalClass, featherColor)
        {
            EggsPerYear = eggsPerYear;
        }
        public override string Stats()
        {
            var temp = base.Stats();
            string flamingoStats = $" {temp} and lays {EggsPerYear} Eggs per year";
            return flamingoStats;
        }

    }
    class Swan : Bird
    {
        public string SwanSpecies { get; set; }
        public Swan(int animalAge, string animalName, double animalWeight, string animalClass, string featherColor, string swanSpecies) : base(animalAge, animalName, animalWeight, animalClass, featherColor)
        {
            SwanSpecies = swanSpecies;
        }
        public override string Stats()
        {
            var temp = base.Stats();
            string swanStats = $" {temp}  Species: {SwanSpecies}";
            return swanStats;
        }

    }


    class WolfMan : Wolf, IPerson
    {
        public int JumpingHeight { get; set; }
        public WolfMan(int animalAge, string animalName, double animalWeight, string animalClass, string homeCountry, int jumpingHeight) : base(animalAge, animalName, animalWeight, animalClass, homeCountry)
        {
            JumpingHeight = jumpingHeight;
        }
        public string Talk()
        {
            return "I can talk";
        }
        public override string Stats()
        {

            var temp = base.Stats();
            string wolfManStats = $"The wolfman's {temp}  and can jump up to {JumpingHeight} meters";
            return wolfManStats;
        }
    }
    // svar på F 13(3.2) : i klassen Bird

    // svar på F 14(3.2) : i klassen Animal

    // Svar på F 9(3.3) Den går inte att lägga till en häst i hund klassen
    // för att Horse ärvar från Animal men inte från Dog. 

    // Svar på F 10(3.3) Listan måste antigen vara vara av typ Horse eller Animal.

    //svar på F 16(3.3) : Nej

    // svar på F 17(3.3) : 
    //för att metoden gäller bara hundar, och inte alla 
    //  Animals är hundar.

    // svar på F 11(3.4) : 
    //Den är en jätteviktigt del av oop och den öppnar 
    // möjligheten till att strukturera våra klasser och metoder precis som vi vill.
    // Den ger möjligheten till att använda samma metods namn för att göra
    //olika grjer beroende på var metoden är används. 

    // svar på F 12(3.4) : 
    // Underhållet blir mycket enklare när man har den, dvs att det räcker
    //att ändra på ett ställe för att underhålla hur många ställe som helst.
    //Man kan beskriva betydligt vad gör koden genom att ha bra namn till metoder
    // så blir koden mycket snyggare och mer läsbart.
    //det som jag kan tänka på mig nu :D 

    // svar på F 13(3.4) :
    // 1. Abstrakta klasser kan innehålla metoder med implementering , 
    //medan gränssnitt inte tillåter det och bara ger definitioner av elementen.

    // 2. Abstrakta klasser kan innehålla vad vanliga klasser innehåller, som konstruktörer 
    //medan gränssnittkan inte innehålla sånt .

    //3. En klass kan ärva från en abstrakt klass 
    // medan den kan implementera mer än ett gränssnitt.

    // jag har läst mer skilnader men inte förstått riktigt så kan vi ta dem sen tror jag.

}
