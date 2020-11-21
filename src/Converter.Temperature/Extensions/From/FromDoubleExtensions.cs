using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;

namespace Converter.Temperature.Extensions.From
{
    /// <summary>
    /// The from <see langword="double"/> extensions.
    /// </summary>
    public static class FromDoubleExtensions
    {
        /// <summary>
        /// Sets the conversion to be from Celsius.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Celsius Double class for the 'To' extensions to use.
        /// </returns>
        public static CelsiusDouble FromCelsius(this double input)
        {
            return new CelsiusDouble(input);
        }

        /// <summary>
        /// Sets the conversion to be from Fahrenheit.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Fahrenheit Double class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitDouble FromFahrenheit(this double input)
        {
            return new FahrenheitDouble(input);
        }

        /// <summary>
        /// Sets the conversion to be from Gas.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Gas Double class for the 'To' extensions to use.
        /// </returns>
        public static GasDouble FromGas(this double input)
        {
            return new GasDouble(input);
        }

        /// <summary>
        /// Sets the conversion to be from Kelvin.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Kelvin Double class for the 'To' extensions to use.
        /// </returns>
        public static KelvinDouble FromKelvin(this double input)
        {
            return new KelvinDouble(input);
        }

        public static RankineDouble FromRankine(this double input)
        {
            return new RankineDouble(input);
        }
    }
}