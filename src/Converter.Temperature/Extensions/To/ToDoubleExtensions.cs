using System;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;

namespace Converter.Temperature.Extensions.To
{
    /// <summary>
    /// The to <see langword="double"/> extensions.
    /// </summary>
    public static class ToDoubleExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this CelsiusDouble input)
        {
            return Celsius.CelsiusToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this FahrenheitDouble input)
        {
            return Fahrenheit.FahrenheitToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this GasDouble input)
        {
            return Gas.GasToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this KelvinDouble input)
        {
            return Kelvin.KelvinToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this RankineDouble input)
        {
            return Rankine.RankineToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this CelsiusDouble input)
        {
            return Celsius.CelsiusToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this FahrenheitDouble input)
        {
            return Fahrenheit.FahrenheitToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this GasDouble input)
        {
            return Gas.GasToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this KelvinDouble input)
        {
            return Kelvin.KelvinToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this RankineDouble input)
        {
            return Rankine.RankineToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this CelsiusDouble input)
        {
            return Celsius.CelsiusToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this FahrenheitDouble input)
        {
            return Fahrenheit.FahrenheitToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this GasDouble input)
        {
            return Gas.GasToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this KelvinDouble input)
        {
            return Kelvin.KelvinToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this RankineDouble input)
        {
            return Rankine.RankineToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this CelsiusDouble input)
        {
            return Celsius.CelsiusToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this FahrenheitDouble input)
        {
            return Fahrenheit.FahrenheitToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this GasDouble input)
        {
            return Gas.GasToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this KelvinDouble input)
        {
            return Kelvin.KelvinToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this RankineDouble input)
        {
            return Rankine.RankineToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this CelsiusDouble input)
        {
            return Celsius.CelsiusToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this FahrenheitDouble input)
        {
            return Fahrenheit.FahrenheitToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this GasDouble input)
        {
            return Gas.GasToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this KelvinDouble input)
        {
            return Kelvin.KelvinToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this RankineDouble input)
        {
            return Rankine.RankineToRankine(input.Temperature);
        }
    }
}