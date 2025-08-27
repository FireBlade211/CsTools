using System.Numerics;

namespace FireBlade.CsTools.Numbers
{
    /// <summary>
    /// Extends number types such as <see cref="int"/>, <see cref="float"/>, or <see cref="double"/>.
    /// </summary>
    public static class NumberExtensions
    {
        /// <summary>
        /// Checks if the specified number is in a range.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The value to test.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns><see langword="true"/> if the value is in range; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public static bool IsInRange<TNum>(this TNum val, TNum min, TNum max) where TNum : INumber<TNum>
        {
            if (min > max)
                throw new ArgumentOutOfRangeException(nameof(min), "Min is larger than max.");

            return val >= min && val <= max;
        }

        /// <summary>
        /// Checks if the specified number is in a range.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The value to test.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns><see langword="true"/> if the value is in range; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public static bool IsInRange<TNum>(this TNum val, int min, int max) where TNum : INumber<TNum>
        {
            return IsInRange(val, TNum.CreateTruncating(min), TNum.CreateTruncating(max));
        }

        /// <summary>
        /// Checks if the specified number is in a range.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The value to test.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns><see langword="true"/> if the value is in range; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public static bool IsInRange<TNum>(this TNum val, float min, float max) where TNum : INumber<TNum>
        {
            return IsInRange(val, TNum.CreateTruncating(min), TNum.CreateTruncating(max));
        }

        /// <summary>
        /// Checks if the specified number is in a range.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The value to test.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns><see langword="true"/> if the value is in range; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public static bool IsInRange<TNum>(this TNum val, double min, double max) where TNum : INumber<TNum>
        {
            return IsInRange(val, TNum.CreateTruncating(min), TNum.CreateTruncating(max));
        }

        /// <summary>
        /// Checks if the specified number is in a range.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The value to test.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns><see langword="true"/> if the value is in range; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public static bool IsInRange<TNum>(this TNum val, decimal min, decimal max) where TNum : INumber<TNum>
        {
            return IsInRange(val, TNum.CreateTruncating(min), TNum.CreateTruncating(max));
        }

        /// <summary>
        /// Checks if the specified number is in a range.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="val">The value to test.</param>
        /// <param name="range">The range to check the value against.</param>
        /// <returns><see langword="true"/> if the value is in range; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public static bool IsInRange<TNum>(this TNum val, Range<TNum> range) where TNum : INumber<TNum>
        {
            return IsInRange(val, range.Minimum, range.Maximum);
        }
    }
}