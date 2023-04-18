namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var r = new Random();
            //var favNumber = r.Next(1, 1000);
            var favNumber = 5;

            Console.WriteLine("Pick a number from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low!");
               
            }
            if(userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high!");

            }
            else
            {
                Console.WriteLine($"You guessed it!");
=======
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                    Console.WriteLine("Science rocks!");
                    break;
                case "english":
                    Console.WriteLine("To be, or not to be... english is a great choice.");
                    break;
                case "history":
                    Console.WriteLine("Another lovely choice.");
                    break;
                case "lunch":
                    Console.WriteLine("Not techniqually a subject but I have to agree.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;


>>>>>>> exercise2
            }


        }
    }
}
