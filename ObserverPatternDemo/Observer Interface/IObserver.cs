﻿using ObserverPatternDemo.Implemantation.Observable;

namespace ObserverPatternDemo.Observer_Interface
{
    /// <summary>
    /// Defines a receiver of notifications.
    /// </summary>
    /// <typeparam name="T">The object that provides notification information.</typeparam>
    public interface IObserver<T> where T : EventInfo
    {
        /// <summary>
        /// Handles an event.
        /// </summary>
        ///<param name="sender">The object that is to raised notifications.</param>
        ///<param name="info">The current notification information.</param>
        void Update(object sender, T info);

        /// <summary>
        ///     Subscribes this object to <see cref="IObservable{WeatherEventArgs}" /> object
        /// </summary>
        /// <param name="observable"><see cref="IObservable{T}"/> object</param>
        void Subscribe(IObservable<T> observable);

        /// <summary>
        ///     Unsubscribes this object from <see cref="IObservable{WeatherEventArgs}" /> object
        /// </summary>
        /// <param name="observable"><see cref="IObservable{T}"/> object</param>
        void Unsubscribe(IObservable<T> observable);
    }
}