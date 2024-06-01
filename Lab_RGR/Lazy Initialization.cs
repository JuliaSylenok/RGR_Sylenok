using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_RGR
{
    // Creational Pattern - Lazy Initialization
    public class PhotoManager
    {
        private List<string> _photoList;

        public List<string> PhotoList
        {
            get
            {
                if (_photoList == null)
                {
                    _photoList = new List<string>();
                }
                return _photoList;
            }
        }

        public void AddPhoto(string photo)
        {
            PhotoList.Add(photo);
            Console.WriteLine($"Photo added: {photo}");
        }

        public void DisplayPhotos()
        {
            Console.WriteLine("Photos:");
            foreach (var photo in PhotoList)
            {
                Console.WriteLine(photo);
            }
        }
    }
}