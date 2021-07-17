# README

> Converter.Temperature
> This project was created to extract out the main conversion code from the *Temperature Converter* applications in the other repositories.
> I am using this as a way to show how my development skills have changed over the years, as I get to be a better developer.

[![Build status](https://daeer73.visualstudio.com/Converter.Temperature/_apis/build/status/Converter.Temperature-.NET%20Desktop-CI)](https://daeer73.visualstudio.com/Converter.Temperature/_build/latest?definitionId=7)

## Introduction

These extension methods will convert different types of temperatures to other types.

### Temperature types

* Celsius
* Fahrenheit
* Kelvin
* Gas

### Data types

* int
* float
* double
* string

## Ideas

I had a few ideas on how to do the extension methods, but decided on using a fluent style.

Originally, the extensions looked like this:

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.CelsiusToFahrenheit();
```

Then I thought that this looked a bit naf, so went with setting up the *from* first, then the *to*.  This follows the *fluent* pattern.

Now it is used like this:

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromCelsius().ToFahrenheit();
```

### What to do for edge cases

I'm working on what I want the library to do when an exception could be thrown.  This is when we have the edge cases of values that are too small or too large for the type being converted to.

E.g.:

From a float type with a value close to the max value of a float, converted from celsius to fahrenheit.  As a fahrenheit value is greater than the celsius value, then we can't convert correctly.

Should this throw an exception, or just return the original value?

Well, returning the same value would seem like all is well, even though the converted value is wrong.  Thinking about this means, that for me, it should throw an exception for the calling application to handle.

If anyone has any better ideas, then, I would be willing to change this behaviour.

## How to use

This section will go through the ways to use the extensions for the different types.

### Caveat

When you use a double, and you set a value to convert that is at or just below double.MaxValue, then your conversion will fail.  This is because the double.MaxValue is so big, the conversion calculations are too small for the double to notice.

For example, if I want to convert double.MaxValue (Celsius) to Kelvin, (which adds 273 to it), I would expect the calculation to return double.Infinity.  However, it doesn't, so I had to work around that problem.

If your value, times it by 1.01 doesn't hit the infinity, then this library will return a valid value.  Your application may not be able to display it though.

### Exceptions

The library will throw the System.ArgumentOutOfRangeException exception if the value can not be converted.

### int extensions

For each of the different temperature types, you can convert to something else.

#### From Celsius

* To Celsius - yes you can do this, but why would you.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromCelsius().ToCelsius();
```

* To Fahrenheit.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromCelsius().ToFahrenheit();
```

* To Kelvin.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromCelsius().ToKelvin();
```

* To Gas.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromCelsius().ToGas();
```

#### From Fahrenheit

* To Celsius.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromFahrenheit().ToCelsius();
```

* To Fahrenheit - yes you can do this, but why would you.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromFahrenheit().ToFahrenheit();
```

* To Kelvin.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromFahrenheit().ToKelvin();
```

* To Gas.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromFahrenheit().ToGas();
```

#### From Kelvin

* To Celsius.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromKelvin().ToCelsius();
```

* To Fahrenheit.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromKelvin().ToFahrenheit();
```

* To Kelvin - yes you can do this, but why would you.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromKelvin().ToKelvin();
```

* To Gas.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromKelvin().ToGas();
```

#### From Gas

* To Celsius.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromGas().ToCelsius();
```

* To Fahrenheit.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromGas().ToFahrenheit();
```

* To Kelvin.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromGas().ToKelvin();
```

* To Gas - yes you can do this, but why would you.

``` csharp
    var tempToConvert = 34; // an int.
    var convertedTemp = tempToConvert.FromGas().ToGas();
```

### float extensions

As the types all look very similar, I will only show one conversion. I'm picking on the FromCelsius ToFahrenheit method.

``` csharp
    var tempToConvert = 34.5f; // a float.
    var convertedTemp = tempToConvert.FromCelsius().ToFahrenheit();
```

### double extensions

This time, a FromFahrenheit ToGas method.

``` csharp
    var tempToConvert = 34.5d; // a double.
    var convertedTemp = tempToConvert.FromFahrenheit().ToGas();
```

### string extensions

This time, a FromFahrenheit ToKelvin method.

``` csharp
    var tempToConvert = "34.5"; // a string.
    var convertedTemp = tempToConvert.FromFahrenheit().ToKelvin();
```

## More Information

For more information on the project and where it is heading, see the [wiki](https://github.com/daeer73/Converter.Temperature/wiki).
