namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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


            }


        }
    }
}
