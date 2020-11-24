using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;

namespace Converter.Temperature.Extensions.From
{
    /// <summary>
    /// The from <see langword="float"/> extensions.
    /// </summary>
    public static class FromFloatExtensions
    {
        /// <summary>
        /// Sets the conversion to be from Celsius.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Celsius Float class for the 'To' extensions to use.
        /// </returns>
        public static CelsiusFloat FromCelsius(this float input)
        {
            return new CelsiusFloat(input);
        }
        
        /// <summary>
        /// Sets the conversion to be from Fahrenheit.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Fahrenheit Float class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitFloat FromFahrenheit(this float input)
        {
            return new FahrenheitFloat(input);
        }

        /// <summary>
        /// Sets the conversion to be from Gas.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Gas Float class for the 'To' extensions to use.
        /// </returns>
        public static GasFloat FromGas(this float input)
        {
            return new GasFloat(input);
        }

        /// <summary>
        /// Sets the conversion to be from Kelvin.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Kelvin Float class for the 'To' extensions to use.
        /// </returns>
        public static KelvinFloat FromKelvin(this float input)
        {
            return new KelvinFloat(input);
        }

        /// <summary>
        /// Sets the conversion to be from Rankine.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Rankine Float class for the 'To' extensions to use.
        /// </returns>
        public static RankineFloat FromRankine(this float input)
        {
            return new RankineFloat(input);
        }
    }
}