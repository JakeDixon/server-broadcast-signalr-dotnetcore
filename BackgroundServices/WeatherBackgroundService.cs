using Microsoft.Extensions.Hosting;
using signalr_server_broadcast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace signalr_server_broadcast.BackgroundServices
{
    public class WeatherBackgroundService : BackgroundService
    {
        private readonly Subject<WeatherModel> _subject = new Subject<WeatherModel>();
        private readonly Random _random = new Random();

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _subject.OnNext(new WeatherModel { Date = DateTime.Now, Location = "London", Temperature = _random.Next(-10, 40) });

                await Task.Delay(1000);
            }
        }

        public IObservable<WeatherModel> StreamWeather()
        {
            return _subject;
        }
    }
}
