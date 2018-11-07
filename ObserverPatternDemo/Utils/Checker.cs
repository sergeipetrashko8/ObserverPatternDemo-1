using System;

namespace ObserverPatternDemo.Utils
{
    /// <summary>
    ///     Class implements some check methods
    /// </summary>
    public static class Checker
    {
        /// <summary>
        ///     Checks if object has null reference
        /// </summary>
        /// <param name="obj">Source <see cref="object" /></param>
        /// <param name="name"><see cref="string" /> name of object</param>
        /// <exception cref="ArgumentNullException">Throws when obj has null reference</exception>
        public static void CheckNullReference(object obj, string name)
        {
            if (ReferenceEquals(obj, null)) throw new ArgumentNullException(name);
        }

        /// <summary>
        ///     Checks if numeric variable has not negative value
        /// </summary>
        /// <param name="number"><see cref="int" /> number for checking</param>
        /// <param name="name"><see cref="string" /> name of numeric variable</param>
        /// <exception cref="ArgumentException">Throws when number has value less then zero</exception>
        public static void CheckNotNegativeValue(int number, string name)
        {
            if (number < 0) throw new ArgumentException($"{name} = {number} has less then zero value!");
        }

        /// <summary>
        ///     Checks if numeric variable has valid value for percents
        /// </summary>
        /// <param name="percents"><see cref="int" /> number for checking</param>
        /// <param name="name"><see cref="string" /> name of numeric variable</param>
        /// <exception cref="ArgumentException">Throws when number has invalid value for percents</exception>
        public static void CheckPercents(int percents, string name)
        {
            if (percents < 0 || percents > 100)
                throw new ArgumentException($"{name} = {percents} has invalid value for percents!");
        }
    }
}