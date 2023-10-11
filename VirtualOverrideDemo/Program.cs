namespace VirtualOverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sif", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} year old");
            dog.MakeSoung();
            dog.Play();
            dog.Eat();
        }
    }
}