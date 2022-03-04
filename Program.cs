using System;

internal class Program
{

    private static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int majElement = 0;
        int count = 1;
        int curElement;
        for (int i = 0; i < N; i++)
        {
            int.TryParse(Console.ReadLine(), out curElement);
            if (curElement == majElement)
                count++;
            else
                count--;
            if (count == 0)
            {
                majElement = curElement;
                count = 1;
            }
            if (i % 1000 == 0)
                GC.Collect();
        }
        Console.WriteLine(majElement);
    }
}
