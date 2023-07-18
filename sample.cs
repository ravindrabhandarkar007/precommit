using System;

namespace SampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var date = DateTime.Now;
            Console.WriteLine("Current date and time: " + date);

            // The following code has proper formatting and style according to .NET conventions
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Today is Sunday!");
