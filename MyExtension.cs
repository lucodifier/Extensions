using System;

public static class MyExtensions
{
    public static string AddZeroToLeft(this String input, int lenght)
    {
        if (!string.IsNullOrEmpty(input))
        {
            input = input.PadLeft(lenght, '0');
        }
        return input;
    }
}