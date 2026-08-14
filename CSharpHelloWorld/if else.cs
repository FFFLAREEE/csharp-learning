namespace CSharpHelloWorld;

public class if_else
{
    static void Main()
    {
        Console.WriteLine("Please enter your grade 0-100 ");
        int score =0;

        try
        {
            score = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Please enter a valid grade.");
            return;
        }
        if(score>100)
                
        {
            Console.WriteLine("Wrong grade");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Your grade is HD");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Your grade is D");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Your grade is P");
        }
        else
        {
            Console.WriteLine("Your grade is NP");
        }
    }
}
