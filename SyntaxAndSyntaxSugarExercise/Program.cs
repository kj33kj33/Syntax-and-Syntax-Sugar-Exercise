namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer >= 9) ? $"{answer} is greater than or equal to nine" : $"{answer} is less than nine";
            Console.WriteLine(response);
        }
    }
}
