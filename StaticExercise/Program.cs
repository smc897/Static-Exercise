namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine($"32F={TempConverter.FahrenheitToCelcius(32.0)}C");
            Console.WriteLine($"32C={TempConverter.CelsiusToFahrenheit(32.0)}F");
        }
    }
}
