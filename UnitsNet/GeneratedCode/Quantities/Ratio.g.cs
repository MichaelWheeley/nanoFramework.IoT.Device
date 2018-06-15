﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In mathematics, a ratio is a relationship between two numbers of the same kind (e.g., objects, persons, students, spoonfuls, units of whatever identical dimension), usually expressed as "a to b" or a:b, sometimes expressed arithmetically as a dimensionless quotient of the two that explicitly indicates how many times the first number contains the second (not necessarily an integer).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Ratio
#else
    public partial struct Ratio : IComparable, IComparable<Ratio>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RatioUnit? _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
#if WINDOWS_UWP
        public double Value => Convert.ToDouble(_value);
#else
        public double Value => _value;
#endif

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public RatioUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        // Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public Ratio()
        {
            _value = 0;
            _unit = BaseUnit;
        }
#endif

        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public Ratio(double decimalfractions)
        {
            _value = Convert.ToDouble(decimalfractions);
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">Unit representation.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public 
#endif
          Ratio(double numericValue, RatioUnit unit)
        {
            _value = numericValue;
            _unit = unit;
         }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit DecimalFraction.
        /// </summary>
        /// <param name="decimalfractions">Value assuming base unit DecimalFraction.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Ratio(long decimalfractions) : this(Convert.ToDouble(decimalfractions), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit DecimalFraction.
        /// </summary>
        /// <param name="decimalfractions">Value assuming base unit DecimalFraction.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Ratio(decimal decimalfractions) : this(Convert.ToDouble(decimalfractions), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Ratio;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static RatioUnit BaseUnit => RatioUnit.DecimalFraction;

        /// <summary>
        ///     All units of measurement for the Ratio quantity.
        /// </summary>
        public static RatioUnit[] Units { get; } = Enum.GetValues(typeof(RatioUnit)).Cast<RatioUnit>().ToArray();
        /// <summary>
        ///     Get Ratio in DecimalFractions.
        /// </summary>
        public double DecimalFractions => As(RatioUnit.DecimalFraction);
        /// <summary>
        ///     Get Ratio in PartsPerBillion.
        /// </summary>
        public double PartsPerBillion => As(RatioUnit.PartPerBillion);
        /// <summary>
        ///     Get Ratio in PartsPerMillion.
        /// </summary>
        public double PartsPerMillion => As(RatioUnit.PartPerMillion);
        /// <summary>
        ///     Get Ratio in PartsPerThousand.
        /// </summary>
        public double PartsPerThousand => As(RatioUnit.PartPerThousand);
        /// <summary>
        ///     Get Ratio in PartsPerTrillion.
        /// </summary>
        public double PartsPerTrillion => As(RatioUnit.PartPerTrillion);
        /// <summary>
        ///     Get Ratio in Percent.
        /// </summary>
        public double Percent => As(RatioUnit.Percent);

        #endregion

        #region Static

        public static Ratio Zero => new Ratio(0, BaseUnit);

        /// <summary>
        ///     Get Ratio from DecimalFractions.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Ratio FromDecimalFractions(double decimalfractions)
#else
        public static Ratio FromDecimalFractions(QuantityValue decimalfractions)
#endif
        {
            double value = (double) decimalfractions;
            return new Ratio(value, RatioUnit.DecimalFraction);
        }

        /// <summary>
        ///     Get Ratio from PartsPerBillion.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Ratio FromPartsPerBillion(double partsperbillion)
#else
        public static Ratio FromPartsPerBillion(QuantityValue partsperbillion)
#endif
        {
            double value = (double) partsperbillion;
            return new Ratio(value, RatioUnit.PartPerBillion);
        }

        /// <summary>
        ///     Get Ratio from PartsPerMillion.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Ratio FromPartsPerMillion(double partspermillion)
#else
        public static Ratio FromPartsPerMillion(QuantityValue partspermillion)
#endif
        {
            double value = (double) partspermillion;
            return new Ratio(value, RatioUnit.PartPerMillion);
        }

        /// <summary>
        ///     Get Ratio from PartsPerThousand.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Ratio FromPartsPerThousand(double partsperthousand)
#else
        public static Ratio FromPartsPerThousand(QuantityValue partsperthousand)
#endif
        {
            double value = (double) partsperthousand;
            return new Ratio(value, RatioUnit.PartPerThousand);
        }

        /// <summary>
        ///     Get Ratio from PartsPerTrillion.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Ratio FromPartsPerTrillion(double partspertrillion)
#else
        public static Ratio FromPartsPerTrillion(QuantityValue partspertrillion)
#endif
        {
            double value = (double) partspertrillion;
            return new Ratio(value, RatioUnit.PartPerTrillion);
        }

        /// <summary>
        ///     Get Ratio from Percent.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Ratio FromPercent(double percent)
#else
        public static Ratio FromPercent(QuantityValue percent)
#endif
        {
            double value = (double) percent;
            return new Ratio(value, RatioUnit.Percent);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable Ratio from nullable DecimalFractions.
        /// </summary>
        public static Ratio? FromDecimalFractions(QuantityValue? decimalfractions)
        {
            if (decimalfractions.HasValue)
            {
                return FromDecimalFractions(decimalfractions.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Ratio from nullable PartsPerBillion.
        /// </summary>
        public static Ratio? FromPartsPerBillion(QuantityValue? partsperbillion)
        {
            if (partsperbillion.HasValue)
            {
                return FromPartsPerBillion(partsperbillion.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Ratio from nullable PartsPerMillion.
        /// </summary>
        public static Ratio? FromPartsPerMillion(QuantityValue? partspermillion)
        {
            if (partspermillion.HasValue)
            {
                return FromPartsPerMillion(partspermillion.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Ratio from nullable PartsPerThousand.
        /// </summary>
        public static Ratio? FromPartsPerThousand(QuantityValue? partsperthousand)
        {
            if (partsperthousand.HasValue)
            {
                return FromPartsPerThousand(partsperthousand.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Ratio from nullable PartsPerTrillion.
        /// </summary>
        public static Ratio? FromPartsPerTrillion(QuantityValue? partspertrillion)
        {
            if (partspertrillion.HasValue)
            {
                return FromPartsPerTrillion(partspertrillion.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable Ratio from nullable Percent.
        /// </summary>
        public static Ratio? FromPercent(QuantityValue? percent)
        {
            if (percent.HasValue)
            {
                return FromPercent(percent.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RatioUnit" /> to <see cref="Ratio" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Ratio unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Ratio From(double value, RatioUnit fromUnit)
#else
        public static Ratio From(QuantityValue value, RatioUnit fromUnit)
#endif
        {
            return new Ratio((double)value, fromUnit);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RatioUnit" /> to <see cref="Ratio" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Ratio unit value.</returns>
        public static Ratio? From(QuantityValue? value, RatioUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return new Ratio((double)value.Value, fromUnit);
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(RatioUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(
          RatioUnit unit,
#if WINDOWS_UWP
          [CanBeNull] string cultureName)
#else
          [CanBeNull] IFormatProvider provider)
#endif
        {
#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static Ratio operator -(Ratio right)
        {
            return new Ratio(-right.Value, right.Unit);
        }

        public static Ratio operator +(Ratio left, Ratio right)
        {
            return new Ratio(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Ratio operator -(Ratio left, Ratio right)
        {
            return new Ratio(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Ratio operator *(double left, Ratio right)
        {
            return new Ratio(left * right.Value, right.Unit);
        }

        public static Ratio operator *(Ratio left, double right)
        {
            return new Ratio(left.Value * right, left.Unit);
        }

        public static Ratio operator /(Ratio left, double right)
        {
            return new Ratio(left.Value / right, left.Unit);
        }

        public static double operator /(Ratio left, Ratio right)
        {
            return left.DecimalFractions / right.DecimalFractions;
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is Ratio)) throw new ArgumentException("Expected type Ratio.", "obj");
            return CompareTo((Ratio) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Ratio other)
        {
            return AsBaseUnitDecimalFractions().CompareTo(other.AsBaseUnitDecimalFractions());
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(Ratio left, Ratio right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Ratio left, Ratio right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Ratio left, Ratio right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Ratio left, Ratio right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Ratio left, Ratio right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Ratio left, Ratio right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
#endif

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return AsBaseUnitDecimalFractions().Equals(((Ratio) obj).AsBaseUnitDecimalFractions());
        }

        /// <summary>
        ///     Compare equality to another Ratio by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        public bool Equals(Ratio other, Ratio maxError)
        {
            return Math.Abs(AsBaseUnitDecimalFractions() - other.AsBaseUnitDecimalFractions()) <= maxError.AsBaseUnitDecimalFractions();
        }

        public override int GetHashCode()
        {
			return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(RatioUnit unit)
        {
            if (Unit == unit)
            {
                return (double)Value;
            }

            double baseUnitValue = AsBaseUnitDecimalFractions();

            switch (unit)
            {
                case RatioUnit.DecimalFraction: return baseUnitValue;
                case RatioUnit.PartPerBillion: return baseUnitValue*1e9;
                case RatioUnit.PartPerMillion: return baseUnitValue*1e6;
                case RatioUnit.PartPerThousand: return baseUnitValue*1e3;
                case RatioUnit.PartPerTrillion: return baseUnitValue*1e12;
                case RatioUnit.Percent: return baseUnitValue*1e2;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Ratio Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Ratio Parse(
            string str,
#if WINDOWS_UWP
            [CanBeNull] string cultureName)
#else
            [CanBeNull] IFormatProvider provider)
#endif
        {
            if (str == null) throw new ArgumentNullException("str");

#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            return QuantityParser.Parse<Ratio, RatioUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    RatioUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromDecimalFractions(x.DecimalFractions + y.DecimalFractions));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Ratio result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse(
            [CanBeNull] string str,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
          out Ratio result)
        {
#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif
            try
            {

                result = Parse(
                  str,
#if WINDOWS_UWP
                  cultureName);
#else
                  provider);
#endif

                return true;
            }
            catch
            {
                result = default(Ratio);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static RatioUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from other .NET targets.")]
        public static RatioUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static RatioUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<RatioUnit>(str.Trim());

            if (unit == RatioUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized RatioUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        /// <summary>
        ///     Set the default unit used by ToString(). Default is DecimalFraction
        /// </summary>
        public static RatioUnit ToStringDefaultUnit { get; set; } = RatioUnit.DecimalFraction;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(RatioUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <returns>String representation.</returns>
        public string ToString(
          RatioUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName)
#else
            [CanBeNull] IFormatProvider provider)
#endif
        {
            return ToString(
              unit,
#if WINDOWS_UWP
              cultureName,
#else
              provider,
#endif
              2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(
            RatioUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
            int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(
              unit,
#if WINDOWS_UWP
              cultureName,
#else
              provider,
#endif
              format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(
            RatioUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
            [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of Ratio
        /// </summary>
        public static Ratio MaxValue => new Ratio(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Ratio
        /// </summary>
        public static Ratio MinValue => new Ratio(double.MinValue, BaseUnit);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnitDecimalFractions()
        {
            if (Unit == RatioUnit.DecimalFraction) { return _value; }

            switch (Unit)
            {
                case RatioUnit.DecimalFraction: return _value;
                case RatioUnit.PartPerBillion: return _value/1e9;
                case RatioUnit.PartPerMillion: return _value/1e6;
                case RatioUnit.PartPerThousand: return _value/1e3;
                case RatioUnit.PartPerTrillion: return _value/1e12;
                case RatioUnit.Percent: return _value/1e2;
                default:
                    throw new NotImplementedException("Unit not implemented: " + Unit);
            }
        }

        /// <summary>Convenience method for working with internal numeric type.</summary>
        private double AsBaseNumericType(RatioUnit unit) => Convert.ToDouble(As(unit));

    }
}
