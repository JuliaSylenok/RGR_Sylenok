using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_RGR
{
    // Concurrency Pattern - Monitor
    public class PhotoProcessor
    {
        private object _lock = new object();

        public void ProcessPhoto(string photo)
        {
            lock (_lock)
            {
                Console.WriteLine($"Processing photo: {photo}");
                Thread.Sleep(2000);
                Console.WriteLine($"Photo processed: {photo}");
            }
        }
    }
}