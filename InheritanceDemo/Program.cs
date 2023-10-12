namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis Panjuta",
                "https://image.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }

        // CHALLENGE add a deriving Class "VideoPost" with a property VideoURL, Length.
        
        // create the required constructors to create a VideoPost
        // adjust th ToString() method accordingly
        // create an istance of VideoPost

        // More advanced - use Timer and a Callback method here (google it: ))
        // create fields as required
        // add member methods "Play" which should write the current duration of the video
        // and "Stop" which should stop the "timer" and write "stoped at {0}s" on to console.
        // Play the video after creating the instance and pause it, when the user presses any key
    }
}