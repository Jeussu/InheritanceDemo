namespace InheritanceChallenge2
{
    internal class Program
    {
        //Create a main class with the Main method, then a base class employee with the properties Name,
        // FirstName, Salary and the methods Work() and Pause().
        // Create a deriving class boss with the propertie CompanyCar and method Lead().
        // Create another deriving class of employees - trainees with the properties workingHours
        //and SchoolHours and a method Learn();
        //Override the methods Works() of the trainee class so that it indicates
        // the working hours of the trainee.
        //Don't forget to create the constructors.
        //Create an object of each of the three classes (with arbtrary values)
        //and call the methods, Lead() of Boss and Work() of Trainee.
        // Just print out the respective text, what the respective employees do.
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael", "Miller", 40000);

            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 99999999);

            chuckNorris.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 10000);
            michelle.Learn();
            michelle.Work();

            Console.ReadKey();
        }
    }
}