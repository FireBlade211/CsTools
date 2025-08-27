using System.Numerics;

namespace FireBlade.CsTools.Numbers
{
    /// <summary>
    /// Represents a range of numbers.
    /// </summary>
    /// <typeparam name="TNum">The number type.</typeparam>
    public class Range<TNum> where TNum : INumber<TNum>
    {
        internal TNum _min;
        internal TNum _max;

        /// <summary>
        /// Gets or sets the minimum value of the <see cref="Range{TNum}"/>.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public TNum Minimum
        {
            get => _min;
            set
            {
                if (value > _max)
                {
                    throw new ArgumentOutOfRangeException(nameof(Minimum), "The minimum value is larger than the maximum value.");
                }

                _min = value;
            }
        }
        /// <summary>
        /// Gets or sets the maximum value of the <see cref="Range{TNum}"/>.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public TNum Maximum
        {
            get => _max;
            set
            {
                if (value < _min)
                {
                    throw new ArgumentOutOfRangeException(nameof(Minimum), "The minimum value is larger than the maximum value.");
                }

                _max = value;
            }
        }

        // not using primary constructors because we need seperate documentation
        /// <summary>
        /// Creates a new instance of the <see cref="Range{TNum}"/> class.
        /// </summary>
        #pragma warning disable CS8618
        public Range(TNum min, TNum max)
        {
            _min = min;
            _max = max;
        }
#pragma warning restore

        /// <summary>
        /// Checks if the specified number is in the range.
        /// </summary>
        /// <param name="val">The value to test.</param>
        /// <returns><see langword="true"/> if the value is in range; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The minimum value is larger than the maximum value.</exception>
        public bool IsInRange(TNum val) => val.IsInRange(this);

        /// <summary>
        /// Gets the difference between the <see cref="Maximum"/> value and the <see cref="Minimum"/> value.
        /// </summary>
        public TNum Length => _max - _min;
    }
}
