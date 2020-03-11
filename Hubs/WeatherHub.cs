using Microsoft.AspNetCore.SignalR;
using signalr_server_broadcast.BackgroundServices;
using signalr_server_broadcast.Extensions;
using signalr_server_broadcast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace signalr_server_broadcast.Hubs
{
    public class WeatherHub : Hub
    {
        private readonly WeatherBackgroundService _weatherBackgroundService;
        public WeatherHub(WeatherBackgroundService weatherBackgroundService)
        {
            _weatherBackgroundService = weatherBackgroundService;
        }

        public ChannelReader<WeatherModel> StreamWeather()
        {
            return _weatherBackgroundService.StreamWeather().AsChannelReader(10);
        }
    }
}
