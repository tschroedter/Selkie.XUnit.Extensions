using System;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Xunit;

namespace Selkie.XUnit.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class XUnitHelper
    {
        public const double Epsilon = 0.00001;

        public static void AssertIsEqual(object one,
                                         object two,
                                         string text)
        {
            Console.WriteLine("AssertIsEqual: {0} - {1} Equals {2}",
                              text,
                              one,
                              two);

            Assert.Equal(one,
                         two);
        }

        public static void AssertIsEquivalent(double value1,
                                              double value2,
                                              [NotNull] string text = "")
        {
            AssertIsEquivalent(value1,
                               value2,
                               Epsilon,
                               text);
        }

        public static void AssertIsEquivalent(double value1,
                                              double value2,
                                              double epsilon)
        {
            AssertIsEquivalent(value1,
                               value2,
                               epsilon,
                               string.Empty);
        }

        public static void AssertIsEquivalent(double value1,
                                              double value2,
                                              double epsilon,
                                              [NotNull] string text)
        {
            double abs = Math.Abs(value1 - value2);

            if ( double.IsNaN(abs) )
            {
                throw new ArgumentException(text + " - Absolute difference is NaN!");
            }

            if ( !( abs > epsilon ) )
            {
                return;
            }

            string message = string.Format(text + " Absolute difference {0} but epsilon is {1}!",
                                           abs,
                                           epsilon);

            throw new ArgumentException(message);
        }

        public static bool IsEquivalent(double value1,
                                        double value2)
        {
            return IsEquivalent(value1,
                                value2,
                                Epsilon);
        }

        public static bool IsEquivalent(double value1,
                                        double value2,
                                        double epsilon)
        {
            double abs = Math.Abs(value1 - value2);

            return !double.IsNaN(abs) && abs < epsilon;
        }
    }
}