// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let connection = new signalR.HubConnectionBuilder().withUrl('/hubs/weather').build();
connection.start().then(() => connection.stream('StreamWeather').subscribe({
    next: (weather) => {
        document.querySelector(".location").innerHTML = weather.location;
        document.querySelector(".temperature").innerHTML = weather.temperature;
        document.querySelector(".date").innerHTML = weather.date;
    },
    error: (err) => console.error(err),
    complete: () => { }
})).catch((err) => console.error(err));
