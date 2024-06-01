using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_RGR
{
    // Structural Pattern - Proxy
    public interface IPhotoViewer
    {
        void DisplayPhoto();
    }

    public class PhotoViewer : IPhotoViewer
    {
        private string _photo;

        public PhotoViewer(string photo)
        {
            _photo = photo;
        }

        public void DisplayPhoto()
        {
            Console.WriteLine($"Displaying photo: {_photo}");
        }
    }

    public class ProxyPhotoViewer : IPhotoViewer
    {
        private readonly string _photo;
        private PhotoViewer _photoViewer;

        public ProxyPhotoViewer(string photo)
        {
            _photo = photo;
        }

        public void DisplayPhoto()
        {
            if (_photoViewer == null)
            {
                _photoViewer = new PhotoViewer(_photo);
            }
            _photoViewer.DisplayPhoto();
        }
    }

}