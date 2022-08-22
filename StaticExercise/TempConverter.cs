using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double degF)
        {
            return (degF - 32) * 5 / 9;
        }
        public static double FahrenheitToKelvin(double degF)
        {
            return (degF - 32) * 5 / 9 + 273.15;
        }
        public static double CelsiusToFahrenheit(double degC)
        {
            return degC * 9 / 5 + 32;
        }
        public static double CelsiusToKelvin(double degC)
        {
            return degC + 273.15;
        }
        public static double KelvinToFahrenheit(double degK)
        {
            return (degK - 273.15) * 9 / 5 + 32;
        }
        public static double KelvinToCelsius(double degK)
        {
            return degK - 273.15;
        }
    }
}
