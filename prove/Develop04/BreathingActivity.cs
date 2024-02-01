using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class BreathingActivity : Activity
{
    public void BreathingExercise(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        Console.Clear();
        Console.WriteLine("Ready?");
        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("Begin");
        Thread.Sleep(2000);


        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.Write("Breathe In: ");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Clear();

            Console.Write("Breathe Out: ");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}