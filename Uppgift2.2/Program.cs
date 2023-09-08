using System;

namespace Uppgift2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år är det?");
            int nuår = int.Parse(Console.ReadLine());
            int årsen = nuår + 20;
            Console.WriteLine("Om 20 år så är det " + årsen);
        }
    }
}