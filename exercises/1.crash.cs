string[] names = { "Alice", "Bob", "Charlie" };

try
{
    Console.Write("Enter an index: ");

    int i = int.Parse(Console.ReadLine()!);

    Console.WriteLine(names[i]);
}
catch (FormatException)
{
    Console.WriteLine("Invalid Number (Incorrect form)");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Invalid Number (Index out of range)");
}