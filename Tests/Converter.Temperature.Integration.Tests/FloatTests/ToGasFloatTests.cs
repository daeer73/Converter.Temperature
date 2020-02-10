﻿using System;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests
{
    public class ToGasFloatTests
    {
        #region From Celsius

        [Fact]
        public void Test_float_extensions_from_celsius_to_gas_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 6f;
            const float input = 200f;

            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_float_extensions_from_celsius_to_gas_with_large_value_throws_exception()
        {
            // Arrange.
            const float input = 74536.9876f;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_float_extensions_from_fahrenheit_to_gas_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 6f;
            const float input = 392f;

            // Act.
            var result = input.FromFahrenheit().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_float_extensions_from_kelvin_to_gas_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 6f;
            const float input = 473.15f;

            // Act.
            var result = input.FromKelvin().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(0.25f)]
        [InlineData(3f)]
        [InlineData(5f)]
        [InlineData(8f)]
        [InlineData(10f)]
        public void Test_float_extension_from_and_to_gas_returns_correct_float_value(float value)
        {
            // Arrange.
            // Act.
            var result = value.FromGas().ToGas();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Gas
    }
}