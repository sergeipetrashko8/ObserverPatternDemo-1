using ObserverPatternDemo.Implemantation.Observable;
using ObserverPatternDemo.Utils;

namespace ObserverPatternDemo.Observer_Interface
{
    public abstract class Observer<T> : IObserver<T> where T : WeatherInfo
    {
        /// <summary>
        /// Handles an event.
        /// </summary>
        ///<param name="sender">The object that is to raised notifications.</param>
        ///<param name="info">The current notification information.</param>
        public abstract void Update(object sender, T info);

        /// <summary>
        ///     Subscribes this object to <see cref="IObservable{WeatherEventArgs}" /> object
        /// </summary>
        /// <param name="observable"><see cref="IObservable{T}"/> object</param>
        public void Subscribe(IObservable<T> observable)
        {
            Checker.CheckNullReference(observable, nameof(observable));
            observable.Register(this);
        }

        /// <summary>
        ///     Unsubscribes this object from <see cref="IObservable{WeatherEventArgs}" /> object
        /// </summary>
        /// <param name="observable"><see cref="IObservable{T}"/> object</param>
        public void Unsubscribe(IObservable<T> observable)
        {
            Checker.CheckNullReference(observable, nameof(observable));
            observable.Unregister(this);
        }
    }
}