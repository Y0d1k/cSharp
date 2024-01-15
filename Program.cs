using System;

class Sample
{
    public static void Main()
    {
        string str = "012wxyz789";
        char[] arr;

        arr = str.ToCharArray();
        Array.Sort(arr);
        Console.WriteLine(arr);
    }
}