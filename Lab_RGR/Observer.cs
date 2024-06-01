using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_RGR
{
    // Behavioral Pattern - Observer
    public interface IPhotoObserver
    {
        void Update(string photo);
    }

    public class PhotoObserver : IPhotoObserver
    {
        public void Update(string photo)
        {
            Console.WriteLine($"New photo received: {photo}");
        }
    }
}