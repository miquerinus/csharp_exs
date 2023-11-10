using System;
using System.Net;

namespace Helloworld {

    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Whats your name ? ");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine} Hello, {name}, on {currentDate:d} at {currentDate:t} !");
            Console.WriteLine($"{Environment.NewLine} press any key to exit ...");
        }
    }
}