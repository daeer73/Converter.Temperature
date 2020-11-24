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
    public class FromStringExtensionsTests
    {
        [Fact]
        public void Test_from_celsius_returns_celsius_string_type()
        {
            // Arrange.
            var input = "39";

            // Act.
            var result = input.FromCelsius();

            // Assert.
            result.Should().BeOfType<CelsiusString>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_fahrenheit_returns_fahrenheit_string_type()
        {
            // Arrange.
            var input = "39";

            // Act.
            var result = input.FromFahrenheit();

            // Assert.
            result.Should().BeOfType<FahrenheitString>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_gas_returns_gas_string_type()
        {
            // Arrange.
            var input = "39";

            // Act.
            var result = input.FromGas();

            // Assert.
            result.Should().BeOfType<GasString>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_kelvin_returns_kelvin_string_type()
        {
            // Arrange.
            var input = "39";

            // Act.
            var result = input.FromKelvin();

            // Assert.
            result.Should().BeOfType<KelvinString>().Which.Temperature.Should().Be(input);
        }

        [Fact]
        public void Test_from_rankine_returns_rankine_string_type()
        {
            // Arrange.
            var input = "39";

            // Act.
            var result = input.FromRankine();

            // Assert.
            result.Should().BeOfType<RankineString>().Which.Temperature.Should().Be(input);
        }
    }
}