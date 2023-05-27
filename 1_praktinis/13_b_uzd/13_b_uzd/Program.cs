//13_b_užduotis Andrius Stulgys

using System;

public class TemperatureConverter
{
    private double celsius;
    private double fahrenheit;
    private double kelvin;

    public void TemperatureConversions(double celsius = 30, double fahrenheit = 0, double kelvin = 0)
    {
        try
        {
            if (fahrenheit != 0)
            {
                this.celsius = (fahrenheit - 32) * 5 / 9;
                this.fahrenheit = fahrenheit;
                this.kelvin = (fahrenheit + 459.67) * 5 / 9;
            }
            else if (kelvin != 0)
            {
                this.celsius = kelvin - 273.15;
                this.fahrenheit = kelvin * 9 / 5 - 459.67;
                this.kelvin = kelvin;
            }
            else
            {
                this.celsius = celsius;
                this.fahrenheit = celsius * 9 / 5 + 32;
                this.kelvin = celsius + 273.15;
            }

            Console.WriteLine($"Celsijaus reikšmė: {this.celsius} °C");
            Console.WriteLine($"Farenheito reikšmė: {this.fahrenheit} °F");
            Console.WriteLine($"Kelvino reikšmė: {this.kelvin} K");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Klaida: {ex.Message}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        TemperatureConverter temperatureConverter = new TemperatureConverter();
        temperatureConverter.TemperatureConversions(celsius: 0);
    }
}
