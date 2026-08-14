namespace CSharpHelloWorld
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format error: Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow error: The number is too large or too small for int.");
            }
        }
    }
}