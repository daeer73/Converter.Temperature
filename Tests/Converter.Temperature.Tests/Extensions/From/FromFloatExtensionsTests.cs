using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From
{
    public class FromFloatExtensionsTests
    {
        [Fact]
        public void Test_from_celsius_returns_celsius_float_type()
        {
            // Arrange.
            var input = 39f;

            // Act.
            var result = input.FromCelsius();

            // Assert.
            result.Should().BeOfType<CelsiusFloat>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_fahrenheit_returns_fahrenheit_float_type()
        {
            // Arrange.
            var input = 39f;

            // Act.
            var result = input.FromFahrenheit();

            // Assert.
            result.Should().BeOfType<FahrenheitFloat>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_gas_returns_gas_float_type()
        {
            // Arrange.
            var input = 39f;

            // Act.
            var result = input.FromGas();

            // Assert.
            result.Should().BeOfType<GasFloat>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_kelvin_returns_kelvin_float_type()
        {
            // Arrange.
            var input = 39f;

            // Act.
            var result = input.FromKelvin();

            // Assert.
            result.Should().BeOfType<KelvinFloat>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_rankine_returns_rankine_float_type()
        {
            // Arrange.
            var input = 39f;

            // Act.
            var result = input.FromRankine();

            // Assert.
            result.Should().BeOfType<RankineFloat>().Which.Temperature.Should().Be(input);
        }
    }
}