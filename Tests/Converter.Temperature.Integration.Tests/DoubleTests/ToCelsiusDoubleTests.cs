using System;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests
{
    public class ToCelsiusDoubleTests
    {
        #region From Celsius

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_double_extension_from_and_to_celsius_returns_correct_double_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_double_extension_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
        {
            // Arrange.
            const double input = double.MinValue;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromFahrenheit().ToCelsius());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_double_extensions_from_fahrenheit_to_celsius_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 10d;
            const double input = 50d;

            // Act.
            var result = input.FromFahrenheit().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_double_extensions_from_kelvin_to_celsius_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 1.0d;
            const double input = 274.15d;

            // Act.
            var result = input.FromKelvin().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_double_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_double_value()
        {
            // Arrange.
            const double expected = double.MinValue;
            const double input = double.MinValue;

            // Act.
            var result = input.FromKelvin().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(0.25d, 125d)]
        [InlineData(0.9d, 125d)]
        [InlineData(1d, 140d)]
        [InlineData(1.4d, 140d)]
        [InlineData(1.5d, 150d)]
        [InlineData(2.4d, 150d)]
        [InlineData(2.5d, 165d)]
        [InlineData(3.4d, 165d)]
        [InlineData(3.5d, 180d)]
        [InlineData(4.4d, 180d)]
        [InlineData(4.5d, 190d)]
        [InlineData(5.4d, 190d)]
        [InlineData(5.5d, 200d)]
        [InlineData(6.4d, 200d)]
        [InlineData(6.5d, 220d)]
        [InlineData(7.4d, 220d)]
        [InlineData(7.5d, 230d)]
        [InlineData(8.4d, 230d)]
        [InlineData(8.5d, 240d)]
        [InlineData(9.4d, 240d)]
        [InlineData(9.5d, 260d)]
        [InlineData(9.9d, 260d)]
        public void Test_double_extensions_from_gas_to_celsius_returns_correct_double_value(double input, double expected)
        {
            // Arrange.
            // Act.
            var result = input.FromGas().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.24d)]
        [InlineData(10.1d)]
        public void Test_double_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas().ToCelsius());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(0d, -273.15d)]
        [InlineData(50d, -245.3722222222222d)]
        [InlineData(100d, -217.59444444444446d)]
        [InlineData(500d, 4.627777777777769d)]
        [InlineData(1000d, 282.40555555555557d)]
        public void Test_double_extension_from_rankine_and_to_celsius_returns_correct_double_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.FromRankine().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Rankine
    }
}
