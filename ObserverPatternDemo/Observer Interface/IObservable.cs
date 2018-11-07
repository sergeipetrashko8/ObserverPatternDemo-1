﻿namespace ObserverPatternDemo.Observer_Interface
{
    /// <summary>
    ///     Defines a provider for notification.
    /// </summary>
    /// <typeparam name="T">The object that provides notification information.</typeparam>
    public interface IObservable<T> where T : EventInfo
    {
        /// <summary>
        ///     Registers the observer
        /// </summary>
        /// <param name="observer">The object that is to receive notifications.</param>
        void Register(IObserver<T> observer);

        /// <summary>
        ///     Unregisters the observer
        /// </summary>
        /// <param name="observer">The object that is to receive notifications.</param>
        void Unregister(IObserver<T> observer);
    }
}