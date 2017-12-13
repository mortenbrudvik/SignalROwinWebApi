# Combining SignalR and ASP.NET Web Api (OWIN) 

A simple example how to use Signal R with ASP.NET Web Api to broadcast changes back to all clients connected to the service.
 

## Building

Build code with Visual Studio 2015 or newer.

## Example of setting up a client to listen for SignalR events

Create a Console project and copy and paste in the code below.

````
var connection = new HubConnection("http://localhost:9000/signalr");
var messageHub = connection.CreateHubProxy("messageHub");

connection.Start().ContinueWith(task =>
{
    if (task.IsFaulted)
        Console.Out.WriteLine("There was an error opening the connection:{0}", task.Exception.GetBaseException());
    else
        Console.Out.WriteLine("Connected");
}).Wait();

messageHub.On<string>("messageRecieved", message =>
{
    Console.Out.WriteLine(message);
});

Console.ReadKey();

connection.Stop();
````