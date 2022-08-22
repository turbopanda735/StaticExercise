using System;

namespace StaticExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(TempConverter.FahrenheitToCelsius(74));
            Console.WriteLine(TempConverter.FahrenheitToKelvin(74));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(23));
            Console.WriteLine(TempConverter.CelsiusToKelvin(23));
            Console.WriteLine(TempConverter.KelvinToFahrenheit(296.483));
            Console.WriteLine(TempConverter.KelvinToCelsius(296.483));
        }
    }
}