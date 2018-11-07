using System;
using System.Collections.Generic;
using System.Threading;
using ObserverPatternDemo.Utils;

namespace ObserverPatternDemo.Implemantation.Observable
{
    /// <summary>
    ///     Class of weather information
    /// </summary>
    public class WeatherData : Observer_Interface.IObservable<WeatherInfo>
    {
        #region Fields

        private readonly List<Observer_Interface.IObserver<WeatherInfo>> _observers;

        #endregion

        /// <summary>
        ///     Constructor
        /// </summary>
        public WeatherData()
        {
            _observers = new List<Observer_Interface.IObserver<WeatherInfo>>();
        }

        /// <summary>
        ///     Notifies <see cref="Observer_Interface.IObserver{T}" /> objects with information from <see cref="WeatherInfo" />
        ///     object
        /// </summary>
        /// <param name="info"><see cref="WeatherInfo" /> object</param>
        /// <exception cref="System.ArgumentNullException">Throws when sender or info has null reference</exception>
        /// <param name="sender"><see cref="Observer_Interface.IObservable{T}" /> object that is to raised notifications.</param>
        protected virtual void Notify(object sender, WeatherInfo info)
        {
            Checker.CheckNullReference(sender, nameof(sender));
            Checker.CheckNullReference(info, nameof(info));

            foreach (var observer in _observers)
            {
                observer.Update(this, info);
            }
        }

        /// <summary>
        ///     Register <see cref="Observer_Interface.IObserver{T}" /> object for notifying
        /// </summary>
        /// <param name="observer"><see cref="Observer_Interface.IObserver{T}" /> object</param>
        /// <exception cref="System.ArgumentNullException">Throws when observer null reference</exception>
        public void Register(Observer_Interface.IObserver<WeatherInfo> observer)
        {
            Checker.CheckNullReference(observer, nameof(observer));
            _observers.Add(observer);
        }

        /// <summary>
        ///     Unregister <see cref="Observer_Interface.IObserver{T}" /> object from notifying
        /// </summary>
        /// <param name="observer"><see cref="Observer_Interface.IObserver{T}" /> object</param>
        /// <exception cref="System.ArgumentNullException">Throws when observer null reference</exception>
        public void Unregister(Observer_Interface.IObserver<WeatherInfo> observer)
        {
            Checker.CheckNullReference(observer, nameof(observer));
            _observers.Remove(observer);
        }

        #region WeaterData sensors emulators

        /// <summary>
        ///     Generate random parameters of weather characteristics and triggers Update event 
        /// </summary>
        /// <param name="obj"></param>
        public void GetDataFromSensorsAndNotify(object obj)
        {
            var random = new Random();

            var weatherInfo = new WeatherInfo()
            {
                Humidity = random.Next(0, 100),
                Pressure = random.Next(0, 100),
                Temperature = random.Next(-30, 35)
            };

            Notify(this, weatherInfo);
        }

        #endregion
    }
}