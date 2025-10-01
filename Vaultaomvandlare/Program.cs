internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please, write down the sum of money in SEK:");
        double summaPengarISEK = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Alternative 1: EUR:");
        Console.WriteLine("Alternative 2: USD:");
        Console.WriteLine("Alternative 3: YEN:");
        Console.WriteLine("Alternative 4: GBP:");
        string UsersChoice = Console.ReadLine();

        //Omvandla valutan med switch case

        switch (UsersChoice)
        {
            case "EUR":
                double summaPengarIEUR = summaPengarISEK * 0.090;
                Console.WriteLine("The sum of money in EUR is: " + summaPengarIEUR);
                break;

            case "USD":
                double summaPengarIUSD = summaPengarISEK * 0.11;
                Console.WriteLine("The sum of money in USD is: " + summaPengarIUSD);
                break;
            
            case "YEN":
                double summaPengarIYEN = summaPengarISEK * 15.65;
                Console.WriteLine("The sum of money in YEN is: " + summaPengarIYEN);
                break;

            case "GBP":
                double summaPengarIGBP = summaPengarISEK * 0.079;
                Console.WriteLine("The sum of money in GBP is: " + summaPengarIGBP);
                break;
            default:
                Console.WriteLine("Invalid currency choice.");
                break;

        }

    }
}