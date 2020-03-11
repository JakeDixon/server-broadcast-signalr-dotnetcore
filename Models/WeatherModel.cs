using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signalr_server_broadcast.Models
{
    public class WeatherModel
    {
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
        public string Location { get; set; }
    }
}
