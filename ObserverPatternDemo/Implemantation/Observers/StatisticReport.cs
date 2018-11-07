using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatternDemo.Implemantation.Observable;
using ObserverPatternDemo.Observer_Interface;
using ObserverPatternDemo.Utils;

namespace ObserverPatternDemo.Implemantation.Observers
{
    /// <summary>
    ///     Class represents statistic information about weather
    /// </summary>
    public class StatisticReport : Observer<WeatherInfo>
    {
        private readonly List<string> _statisticList;

        #region Ctors

        /// <summary>
        ///     Constructor
        /// </summary>
        public StatisticReport()
        {
            _statisticList = new List<string>();
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="observable"><see cref="WeatherData" /> object</param>
        public StatisticReport(WeatherData observable) : this()
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
            _statisticList.Add(
                $"Date: {DateTime.Now} Weather Condition: \n\tHumidity: {info.Humidity / 100.0,5:P}   Pressure {info.Pressure,8:N}   Temperature {info.Temperature,8:N}");

            var result = new StringBuilder("Statistic Report\n");

            foreach (var report in _statisticList)
            {
                result.AppendLine($"\t{report}");
            }

            View.ToConsoleWriteLine(result.AppendLine().ToString());
        }
    }
}