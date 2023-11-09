using System.Collections;

namespace IEnumerator_and_Ienumerable
{
    internal class Program
    {
        // 1.IEnumerable <T> for generic collections
        // 2. IEnumerable for non generic collections
        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this interface;
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// the returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a Current property that points at the object we are currently at in the collection.
        /// </summary>
        
        /// when it is recommended to use the IEnumerable interface:
        /// - your collection represents a massive database
        /// you don't want to copy the entire thing into memory and cause performance issue in your application.
        /// when it is not recommended to use the IEnumerable interface:
        /// you need the results right away and are possible mutating/ edditing the object later on. In this case, it is better to


        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }

        class Dog
        {
            //the name of the dog
            public string Name { get; set; }
            //is this a naughty dog
            public bool IsNaughtyDog { get; set; }
            //simple constructor
            public Dog(string name, bool isNaughtyDog)
            {
                this.Name = name;
                this.IsNaughtyDog = isNaughtyDog;
            }
            //this method will print how many treats the dog received
            public void GiveTreat(int numberofTreats)
            {
                //print a message containing the number of treats and the name of the dog
                Console.WriteLine("Dog: {0} said wouff {1} time!.", Name, numberofTreats);
            }
        }

        class DogShelter : IEnumerable<Dog>
        {
            // list of type List<Dog>
            public List<Dog> dogs;
            //this constructor will initialize the dogs list with some values
            public DogShelter()
            {
                //initialize the dogs list using the collection-initializer
                dogs = new List<Dog>()
                {
                    new Dog("Casper",false),
                    new Dog("Sif",true),
                    new Dog("Oreo",false),
                    new Dog("Pixel",false),
                };
            }

            IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
            {
                return dogs.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}