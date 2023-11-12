namespace IEnumerableDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a list of type List<int> initialized with some number
            List<int> numberList = new List<int>() { 8, 6, 2 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            //call collectionSum() and pass the list to it 
            CollectionSum(numberList);

            Console.WriteLine(" ");
            //call CollectionSum() and pass the array to it
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            //sum variable to store the sum of the numbers in anycollection
            int sum = 0;
            //for each number in collection passed to this method
            foreach (var num in anyCollection)
            {
                //add the num value to sum
                sum += num;
            }

            //print the sum
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}