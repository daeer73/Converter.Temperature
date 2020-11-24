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
    public class FromDoubleExtensionsTests
    {
        [Fact]
        public void Test_from_celsius_returns_celsius_double_type()
        {
            // Arrange.
            var input = 39d;

            // Act.
            var result = input.FromCelsius();

            // Assert.
            result.Should().BeOfType<CelsiusDouble>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_fahrenheit_returns_fahrenheit_double_type()
        {
            // Arrange.
            var input = 39d;

            // Act.
            var result = input.FromFahrenheit();

            // Assert.
            result.Should().BeOfType<FahrenheitDouble>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_gas_returns_gas_double_type()
        {
            // Arrange.
            var input = 39d;

            // Act.
            var result = input.FromGas();

            // Assert.
            result.Should().BeOfType<GasDouble>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_kelvin_returns_kelvin_double_type()
        {
            // Arrange.
            var input = 39d;

            // Act.
            var result = input.FromKelvin();

            // Assert.
            result.Should().BeOfType<KelvinDouble>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_rankine_returns_rankine_double_type()
        {
            // Arrange.
            var input = 39d;

            // Act.
            var result = input.FromRankine();

            // Assert.
            result.Should().BeOfType<RankineDouble>().Which.Temperature.Should().Be(input);
        }
    }
}