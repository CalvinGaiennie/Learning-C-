// See https://aka.ms/new-console-template for more information

/*
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

bool isPrime = true;

if (number <= 1)
{
    isPrime = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
{
    Console.WriteLine($"{number} is a prime number.");
}
else
{
    Console.WriteLine($"{number} is not a prime number.");
}
*/

using System;
using System.Diagnostics;
using System.Threading;

class StopwatchApp
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch(); // Create the stopwatch
        bool running = false;  // Flag to track if stopwatch is running
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Stopwatch");
            Console.WriteLine("Press 's' to start/stop");
            Console.WriteLine("Press 'r' to reset");
            Console.WriteLine("Press 'q' to quit");
            Console.WriteLine("Elapsed time: {0}", stopwatch.Elapsed.ToString(@"hh\:mm\:ss"));

            char key = Console.ReadKey(true).KeyChar;

            if (key == 's' || key == 'S') // Toggle start/stop
            {
                if (running)
                {
                    stopwatch.Stop();
                    running = false;
                }
                else
                {
                    stopwatch.Start();
                    running = true;
                }
            }
            else if (key == 'r' || key == 'R') // Reset stopwatch
            {
                stopwatch.Reset();
                running = false;
            }
            else if (key == 'q' || key == 'Q') // Quit
            {
                break;
            }
        }
    }
}
