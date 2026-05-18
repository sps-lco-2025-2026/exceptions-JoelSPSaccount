// exercise 3

try
{
    Console.Write("Enter a number: ");

    int n = int.Parse(Console.ReadLine()!);

    if (n % 2 == 0)
        Console.WriteLine("Even");
    else
        Console.WriteLine("Odd");
    
}
catch (FormatException)
{
    Console.WriteLine("Input was not in the correct format");
}
finally
{
    Console.WriteLine("Thank you for using the program.");
}