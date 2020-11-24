using System;

namespace Converter.Temperature
{
    internal static class Celsius
    {
        /// <summary>
        /// The celsius to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToCelsius(double firstTemp)
        {
            return firstTemp;
        }

        /// <summary>
        /// The celsius to fahrenheit conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToFahrenheit(double input)
        {
            var fahrenheitTemp = (input * 1.8) + 32;
            if (double.IsPositiveInfinity(fahrenheitTemp) || double.IsNegativeInfinity(fahrenheitTemp))
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            return fahrenheitTemp;
        }

        /// <summary>
        /// The celsius to kelvin conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToKelvin(double input)
        {
            var kelvinTemp = (input * 1.01d) + 273.15d;
            if (double.IsPositiveInfinity(kelvinTemp) || double.IsNegativeInfinity(kelvinTemp))
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            kelvinTemp = (input * 1d) + 273.15d;

            return kelvinTemp;
        }

        /// <summary>
        /// The celsius to gas conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToGas(double input)
        {
            double gasTemp;
            if (input < 80)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooLowForGasError);
            }

            if (input < 115)
            {
                gasTemp = 0.25;
            }
            else if (input < 135)
            {
                gasTemp = 0.5;
            }
            else if (input < 145)
            {
                gasTemp = 1;
            }
            else if (input < 155)
            {
                gasTemp = 2;
            }
            else if (input < 175)
            {
                gasTemp = 3;
            }
            else if (input < 185)
            {
                gasTemp = 4;
            }
            else if (input < 195)
            {
                gasTemp = 5;
            }
            else if (input < 210)
            {
                gasTemp = 6;
            }
            else if (input < 225)
            {
                gasTemp = 7;
            }
            else if (input < 235)
            {
                gasTemp = 8;
            }
            else if (input < 245)
            {
                gasTemp = 9;
            }
            else if (input < 270)
            {
                gasTemp = 10;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooHighForGasError);
            }

            return gasTemp;
        }

        /// <summary>
        /// The celsius to rankine conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToRankine(double input)
        {
            var rankineTemp = (input + 273.15) * 9 / 5;
            if (double.IsPositiveInfinity(rankineTemp) || double.IsNegativeInfinity(rankineTemp))
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            return rankineTemp;
        }
    }
}