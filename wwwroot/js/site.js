// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let connection = new signalR.HubConnectionBuilder().withUrl('/hubs/weather').build();
connection.start().then(() => connection.stream('StreamWeather').subscribe({
    next: (weather) => console.log(weather),
    error: (err) => console.error(err),
    complete: () => { }
})).catch((err) => console.error(err));
