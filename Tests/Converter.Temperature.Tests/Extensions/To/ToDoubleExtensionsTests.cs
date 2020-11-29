using System;

using Converter.Temperature.Extensions.To;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To
{
    public class ToDoubleExtensionsTests
    {
        [Fact]
        public void Test_to_celsius_from_celsius_returns_same_value()
        {
            // Arrange.
            var input = new CelsiusDouble(42);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_celsius_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const double expected = 10d;
            var input = new FahrenheitDouble(50);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

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
        public void Test_to_celsius_from_gas_returns_correct_value(double input, double expected)
        {
            // Arrange.
            var inputGas = new GasDouble(input);

            // Act.
            var result = inputGas.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.24d)]
        [InlineData(10.1d)]
        public void Test_to_celsius_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(double input)
        {
            // Arrange.
            var inputGas = new GasDouble(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.ToCelsius());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        [Fact]
        public void Test_to_celsius_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const double expected = 1.0d;
            var input = new KelvinDouble(274.15);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_rankine_returns_correct_value()
        {
            // Arrange.
            const double expected = 1.0000000000000062d;
            var input = new RankineDouble(493.47d);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_celsius_returns_correct_value()
        {
            // Arrange.
            const double expected = 53.6d;
            var input = new CelsiusDouble(12);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_to_fahrenheit_from_celsius_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            var inputCelsius = new CelsiusDouble(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_fahrenheit_from_fahrenheit_returns_same_value()
        {
            // Arrange.
            var input = new FahrenheitDouble(50);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_fahrenheit_from_gas_returns_correct_value()
        {
            // Arrange.
            const double expected = 428d;
            var input = new GasDouble(7);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const double expected = 33.8d;
            var input = new KelvinDouble(274.15);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_rankine_returns_correct_value()
        {
            // Arrange.
            const double expected = 33.800999999999991d;
            var input = new RankineDouble(493.471d);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(80, 0.25d)]
        [InlineData(114, 0.25d)]
        [InlineData(115, 0.5d)]
        [InlineData(134, 0.5d)]
        [InlineData(135, 1d)]
        [InlineData(144, 1d)]
        [InlineData(145, 2d)]
        [InlineData(154, 2d)]
        [InlineData(155, 3d)]
        [InlineData(174, 3d)]
        [InlineData(175, 4d)]
        [InlineData(184, 4d)]
        [InlineData(185, 5d)]
        [InlineData(194, 5d)]
        [InlineData(195, 6d)]
        [InlineData(209, 6d)]
        [InlineData(210, 7d)]
        [InlineData(224, 7d)]
        [InlineData(225, 8d)]
        [InlineData(234, 8d)]
        [InlineData(235, 9d)]
        [InlineData(244, 9d)]
        [InlineData(245, 10d)]
        [InlineData(269, 10d)]
        public void Test_to_gas_from_celsius_returns_correct_value(double input, double expected)
        {
            // Arrange.
            var inputCelsius = new CelsiusDouble(input);

            // Act.
            var result = inputCelsius.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(79d, "Temp too low for gas mark!")]
        [InlineData(270d, "Temp too high for gas mark!")]
        public void Test_to_gas_from_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(double input, string expectedErrorMessage)
        {
            // Arrange.
            var inputGas = new CelsiusDouble(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.ToGas());

            // Assert.
            result.Message.Should().Contain(expectedErrorMessage);
        }

        [Fact]
        public void Test_to_gas_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const double expected = 6d;
            var input = new FahrenheitDouble(392);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_gas_returns_same_value()
        {
            // Arrange.
            var input = new GasDouble(7);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Theory]
        [InlineData(0.24d)]
        [InlineData(10.1d)]
        public void Test_to_gas_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(double input)
        {
            // Arrange.
            var inputGas = new GasDouble(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        [Fact]
        public void Test_to_gas_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const double expected = 6d;
            var input = new KelvinDouble(473.15);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_rankine_returns_correct_value()
        {
            // Arrange.
            const double expected = 3d;
            var input = new RankineDouble(806.67);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_celsius_returns_correct_value()
        {
            // Arrange.
            const double expected = 473.15d;
            var input = new CelsiusDouble(200);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_to_kelvin_from_celsius_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            var inputCelsius = new CelsiusDouble(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToKelvin());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const double expected = 473.15d;
            var input = new FahrenheitDouble(392);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_gas_returns_correct_value()
        {
            // Arrange.
            const double expected = 473.15d;
            var input = new GasDouble(6);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_kelvin_returns_same_value()
        {
            // Arrange.
            var input = new KelvinDouble(473.15);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_kelvin_from_rankine_returns_same_value()
        {
            // Arrange.
            const double expected = 473.1499999999999d;
            var input = new RankineDouble(851.67);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_celsius_returns_correct_value()
        {
            // Arrange.
            const double expected = 851.6699999999998d;
            var input = new CelsiusDouble(200);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_to_rankine_from_celsius_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            var inputCelsius = new CelsiusDouble(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRankine());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_rankine_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const double expected = 851.6700000000001d;
            var input = new FahrenheitDouble(392);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_gas_returns_correct_value()
        {
            // Arrange.
            const double expected = 851.6699999999998d;
            var input = new GasDouble(6);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_kelvin_returns_same_value()
        {
            // Arrange.
            const double expected = 851.6699999999998d;
            var input = new KelvinDouble(473.15);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_rankine_returns_same_value()
        {
            // Arrange.
            var input = new RankineDouble(851.67);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(input.Temperature);
        }
    }
}