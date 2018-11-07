using ObserverPatternDemo.Implemantation.Observable;
using ObserverPatternDemo.Observer_Interface;
using ObserverPatternDemo.Utils;

namespace ObserverPatternDemo.Implemantation.Observers
{
    /// <summary>
    ///     Class represents statistic information about weather
    /// </summary>
    public class CurrentConditionsReport : Observer<WeatherInfo>
    {
        #region Ctors

        /// <summary>
        ///     Constructor
        /// </summary>
        public CurrentConditionsReport()
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="observable"><see cref="WeatherData" /> object</param>
        public CurrentConditionsReport(WeatherData observable)
        {
            Checker.CheckNullReference(observable, nameof(observable));
            observable.Register(this);
        }

        #endregion

        /// <summary>
        ///     Handles an event.
        /// </summary>
        /// <param name="sender">The object that is to raised notifications.</param>
        /// <param name="info">The current notification information.</param>
        public override void Update(object sender, WeatherInfo info)
        {
            View.ToConsoleWriteLine(
                $"Current Weather Condition Report: \nHumidity: {info.Humidity / 100.0,5:P}   Pressure {info.Pressure,8:N}   Temperature {info.Temperature,8:N}\n");
        }
    }
}