using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelcius(double temp) {
            return (9.0 / 5.0)*(temp - 32);
        }

        public static double CelsiusToFahrenheit(double temp) {
            return (9.0 / 5.0) * temp + 32.0;
        }
    }
}
