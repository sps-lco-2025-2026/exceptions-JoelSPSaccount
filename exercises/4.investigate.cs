// Snippet A
try
{
    int[] arr = new int[3];
    arr[10] = 5;
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Index out of range.");
}

// Snippet B
try
{
    string s = null!;
    Console.WriteLine(s.Length);
}
catch (NullReferenceException)
{
    Console.WriteLine("Cannot find length of null");
}

// Snippet C
try
{
    int x = int.MaxValue;
    checked // checked enforces overflow detection
    {
        x = x + 1;
    }
}
catch (OverflowException)
{
    Console.WriteLine("Number is too big");
}

