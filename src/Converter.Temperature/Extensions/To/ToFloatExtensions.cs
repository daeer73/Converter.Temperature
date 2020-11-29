using System;
using System.Globalization;

using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;

namespace Converter.Temperature.Extensions.To
{
    /// <summary>
    /// The to <see langword="float"/> extensions.
    /// </summary>
    public static class ToFloatExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this CelsiusFloat input)
        {
            float.TryParse(
                Celsius.CelsiusToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this FahrenheitFloat input)
        {
            var result = input.Temperature;
            if (float.TryParse(
                Fahrenheit.FahrenheitToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp))
            {
                result = convertedTemp;
            }
            return result;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this GasFloat input)
        {
            float.TryParse(
                Gas.GasToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this KelvinFloat input)
        {
            float.TryParse(
                Kelvin.KelvinToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return (float)Math.Round(convertedTemp, 2);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this RankineFloat input)
        {
            float.TryParse(
                Rankine.RankineToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return (float)Math.Round(convertedTemp, 2);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this CelsiusFloat input)
        {
            float.TryParse(
                Celsius.CelsiusToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);

            if (float.IsInfinity(convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Fahrenheit <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this FahrenheitFloat input)
        {
            float.TryParse(
                Fahrenheit.FahrenheitToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Fahrenheit <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this GasFloat input)
        {
            float.TryParse(
                Gas.GasToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this KelvinFloat input)
        {
            float.TryParse(
                Kelvin.KelvinToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);

            if (float.IsInfinity(convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);

            return (float)Math.Round(convertedTemp, 2);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this CelsiusFloat input)
        {
            float.TryParse(
                Celsius.CelsiusToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this FahrenheitFloat input)
        {
            float.TryParse(
                Fahrenheit.FahrenheitToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this GasFloat input)
        {
            float.TryParse(
                Gas.GasToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this KelvinFloat input)
        {
            float.TryParse(
                Kelvin.KelvinToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this CelsiusFloat input)
        {
            float.TryParse(
                Celsius.CelsiusToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this FahrenheitFloat input)
        {
            float.TryParse(
                Fahrenheit.FahrenheitToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Kelvin <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this GasFloat input)
        {
            float.TryParse(
                Gas.GasToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this KelvinFloat input)
        {
            float.TryParse(
                Kelvin.KelvinToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }
    }
}