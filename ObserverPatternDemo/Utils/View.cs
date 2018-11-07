using System;

namespace ObserverPatternDemo.Utils
{
    /// <summary>
    ///     Class implements view for some data
    /// </summary>
    public static class View
    {
        /// <summary>
        ///     Writes message in console
        /// </summary>
        /// <param name="message"><see cref="string" /> message</param>
        public static void ToConsoleWriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}