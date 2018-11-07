using System;
using System.Threading;
using ObserverPatternDemo.Implemantation.Observable;
using ObserverPatternDemo.Implemantation.Observers;

namespace WeatherStation
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsReport conditionsReport = new CurrentConditionsReport(weatherData);
            StatisticReport statisticReport = new StatisticReport();

            weatherData.Register(statisticReport);

            Timer timer = new Timer(weatherData.GetDataFromSensorsAndNotify, null, 0, 1000);

            Console.ReadLine();
        }
    }
}