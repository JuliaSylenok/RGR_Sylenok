
using System;
using System.Threading;
using Lab_RGR;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creational Pattern - Lazy Initialization");

        // Creational Pattern - Lazy Initialization
        var photoManager = new PhotoManager();

        photoManager.AddPhoto("Family");
        photoManager.AddPhoto("Friends");
        photoManager.AddPhoto("Vacation");

        photoManager.DisplayPhotos();

        Console.WriteLine("Structural Pattern - Proxy");

        // Structural Pattern - Proxy
        IPhotoViewer photoViewer = new ProxyPhotoViewer("Nature");
        photoViewer.DisplayPhoto();
        Console.WriteLine("Behavioral Pattern - Observer");

        // Behavioral Pattern - Observer
        var photoObserver = new PhotoObserver();
        photoManager.AddPhoto("Family");
        photoObserver.Update("Friends");

        Console.WriteLine("Concurrency Pattern - Monitor");

        // Concurrency Pattern - Monitor
        var photoProcessor = new PhotoProcessor();

        ThreadPool.QueueUserWorkItem(_ =>
        {
            photoProcessor.ProcessPhoto("Sunset");
        });
        photoProcessor.ProcessPhoto("Beach");


        Console.ReadLine();
    }

}