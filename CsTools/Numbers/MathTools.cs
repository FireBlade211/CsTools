using System.Numerics;

namespace FireBlade.CsTools.Numbers
{
    /// <summary>
    /// Provides mathematical tools.
    /// </summary>
    public static class MathTools
    {
        /// <summary>
        /// Maps a value from the input range to the output range.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The value to map.</param>
        /// <param name="input">The input range.</param>
        /// <param name="output">The output range.</param>
        /// <returns><paramref name="val"/>, mapped from the <paramref name="input"/> range to the <paramref name="output"/> range.</returns>
        public static TNum Map<TNum>(TNum val, Range<TNum> input, Range<TNum> output) where TNum : INumber<TNum>
        {
            // Convert to double precision floating point for accuracy in fractional calculations
            // Use CreateTruncating to convert back to TNum at the end
            double inputMin = Convert.ToDouble(input.Minimum);
            double inputMax = Convert.ToDouble(input.Maximum);
            double outputMin = Convert.ToDouble(output.Minimum);
            double outputMax = Convert.ToDouble(output.Maximum);
            double value = Convert.ToDouble(val);

            double mapped = outputMin + (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin);

            return TNum.CreateTruncating(mapped);
        }

        /// <summary>
        /// Returns the true modulo of a number.
        /// Works with negative numbers correctly.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="value">The value to apply the modulus operator on.</param>
        /// <param name="modulus">The modulus to apply.</param>
        /// <returns>The <paramref name="modulus"/> remainder of <paramref name="value"/> after division.</returns>
        public static TNum Mod<TNum>(TNum value, TNum modulus) where TNum : INumber<TNum>
        {
            if (modulus == TNum.Zero)
                throw new DivideByZeroException();

            TNum result = value % modulus;

            // Adjust result if negative to behave like true modulo
            if (result < TNum.Zero)
                result += modulus;

            return result;
        }

        /// <summary>
        /// Checks if a number is odd.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The number to check.</param>
        /// <returns><see langword="true"/> if the value is odd; otherwise, <see langword="false"/>.</returns>
        public static bool IsOdd<TNum>(TNum val) where TNum : INumber<TNum>
        {
            return Mod(val, TNum.CreateTruncating(2)).CompareTo(0) != 0;
        }

        /// <summary>
        /// Checks if a number is even.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The number to check.</param>
        /// <returns><see langword="true"/> if the value is even; otherwise, <see langword="false"/>.</returns>
        public static bool IsEven<TNum>(TNum val) where TNum : INumber<TNum>
        {
            return Mod(val, TNum.CreateTruncating(2)).CompareTo(0) == 0;
        }
    }
}
