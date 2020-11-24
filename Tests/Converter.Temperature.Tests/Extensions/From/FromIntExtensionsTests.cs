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
    public class FromIntExtensionsTests
    {
        [Fact]
        public void Test_from_celsius_returns_celsius_int_type()
        {
            // Arrange.
            var input = 39;

            // Act.
            var result = input.FromCelsius();

            // Assert.
            result.Should().BeOfType<CelsiusInt>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_fahrenheit_returns_fahrenheit_int_type()
        {
            // Arrange.
            var input = 39;

            // Act.
            var result = input.FromFahrenheit();

            // Assert.
            result.Should().BeOfType<FahrenheitInt>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_gas_returns_gas_int_type()
        {
            // Arrange.
            var input = 39;

            // Act.
            var result = input.FromGas();

            // Assert.
            result.Should().BeOfType<GasInt>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_kelvin_returns_kelvin_int_type()
        {
            // Arrange.
            var input = 39;

            // Act.
            var result = input.FromKelvin();

            // Assert.
            result.Should().BeOfType<KelvinInt>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_rankine_returns_rankine_int_type()
        {
            // Arrange.
            var input = 39;

            // Act.
            var result = input.FromRankine();

            // Assert.
            result.Should().BeOfType<RankineInt>().Which.Temperature.Should().Be(input);
        }
    }
}