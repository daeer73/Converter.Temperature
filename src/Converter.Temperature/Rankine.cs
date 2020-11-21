using System;

namespace Converter.Temperature
{
    internal static class Rankine
    {
        public static double RankineToCelsius(double input)
        {
            var celsiusTemp = (input - 491.67) * 5 / 9;
            if (double.IsPositiveInfinity(celsiusTemp) || double.IsNegativeInfinity(celsiusTemp))
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            return celsiusTemp;
        }
    }
}
