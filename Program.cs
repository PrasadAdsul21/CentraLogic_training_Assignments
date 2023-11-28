internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dear user please enter your name to be stored:");
        var uname = Console.ReadLine();
        Console.WriteLine("Greetings,");
        Console.WriteLine("Hello Dear, " + uname + " have a nice day.");
    }
}