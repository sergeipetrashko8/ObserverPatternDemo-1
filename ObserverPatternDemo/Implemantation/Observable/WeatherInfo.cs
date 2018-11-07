using ObserverPatternDemo.Observer_Interface;

namespace ObserverPatternDemo.Implemantation.Observable
{
    /// <summary>
    ///     Class is a container of weather information
    /// </summary>
    public class WeatherInfo : EventInfo
    {
        /// <summary>
        ///     Information about temperature
        /// </summary>
        public int Temperature { get; set; }

        /// <summary>
        ///     Information about humidity
        /// </summary>
        public int Humidity { get; set; }

        /// <summary>
        ///     Information about pressure
        /// </summary>
        public int Pressure { get; set; }
    }
}