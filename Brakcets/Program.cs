﻿namespace Brakcets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Brakcets!");

            Console.WriteLine("kui palju on 3 + 8 / (4 - 2) * 4 = ?");

            double calculation1 = 3 + 8 / (4 - 2) * 4;
            double calculation2 = (3 + 8) / (4 - 2) * 4;
            double calculation3 = ((3 + 8) / (4 - 2)) * 4;
            
            double calculation4 = ((3.0 + 8.0) / (4.0 - 2.0)) * 4.0;

            Console.WriteLine("Vastus: " + calculation1);
            Console.WriteLine("Vastus: " + calculation2);
            Console.WriteLine("Vastus: " + calculation3);
            Console.WriteLine("Vastus: " + calculation4);

            double firstNr = 100;
            double secondNr = 75;
            double thirdNr = 50;

            double answer = firstNr / (secondNr * thirdNr );

            Console.WriteLine(answer);
        }
    }
}
