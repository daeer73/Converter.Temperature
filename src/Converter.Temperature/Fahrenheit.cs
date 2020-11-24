using System;

namespace Converter.Temperature
{
    internal static class Fahrenheit
    {
        /// <summary>
        /// The fahrenheit to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToCelsius(double firstTemp)
        {
            var celsiusTemp = (firstTemp - 32) * 5 / 9;
            if (double.IsPositiveInfinity(celsiusTemp) || double.IsNegativeInfinity(celsiusTemp))
            {
                throw new ArgumentOutOfRangeException(nameof(firstTemp), Constants.ValueOutOfRangeForType);
            }

            return celsiusTemp;
        }

        /// <summary>
        /// The fahrenheit to fahrenheit conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToFahrenheit(double firstTemp)
        {
            return firstTemp;
        }

        /// <summary>
        /// The fahrenheit to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToKelvin(double firstTemp)
        {
            var celsiusTemp = FahrenheitToCelsius(firstTemp);
            var kelvinTemp = Celsius.CelsiusToKelvin(celsiusTemp);
            return kelvinTemp;
        }

        /// <summary>
        /// The fahrenheit to gas conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToGas(double firstTemp)
        {
            var celsiusTemp = FahrenheitToCelsius(firstTemp);
            var gasTemp = Celsius.CelsiusToGas(celsiusTemp);
            return gasTemp;
        }

        /// <summary>
        /// The fahrenheit to rankine conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToRankine(double firstTemp)
        {
            var rankineTemp = firstTemp + 459.67d;
            return rankineTemp;
        }
    }
}