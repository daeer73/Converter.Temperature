using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;

namespace Converter.Temperature.Extensions.From
{
    /// <summary>
    /// The from string extensions.
    /// </summary>
    public static class FromStringExtensions
    {
        /// <summary>
        /// Sets the conversion to be from Celsius.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Celsius String class for the 'To' extensions to use.
        /// </returns>
        public static CelsiusString FromCelsius(this string input)
        {
            return new CelsiusString(input);
        }

        /// <summary>
        /// Sets the conversion to be from Fahrenheit.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Fahrenheit String class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitString FromFahrenheit(this string input)
        {
            return new FahrenheitString(input);
        }

        /// <summary>
        /// Sets the conversion to be from Gas.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Gas String class for the 'To' extensions to use.
        /// </returns>
        public static GasString FromGas(this string input)
        {
            return new GasString(input);
        }

        /// <summary>
        /// Sets the conversion to be from Kelvin.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Kelvin String class for the 'To' extensions to use.
        /// </returns>
        public static KelvinString FromKelvin(this string input)
        {
            return new KelvinString(input);
        }

        /// <summary>
        /// Sets the conversion to be from Rankine.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Rankine String class for the 'To' extensions to use.
        /// </returns>
        public static RankineString FromRankine(this string input)
        {
            return new RankineString(input);
        }
    }
}