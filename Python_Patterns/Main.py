import threading
from Lazy_Initialization import PhotoManager
from Proxy import ProxyPhotoViewer
from Observer import PhotoObserver
from Monitor import PhotoProcessor

def main():
    print("Creational Pattern - Lazy Initialization")
    photo_manager = PhotoManager()
    photo_manager.add_photo("Family")
    photo_manager.add_photo("Friends")
    photo_manager.add_photo("Vacation")
    photo_manager.display_photos()

    print("Structural Pattern - Proxy")
    photo_viewer = ProxyPhotoViewer("Nature")
    photo_viewer.display_photo()

    print("Behavioral Pattern - Observer")
    photo_observer = PhotoObserver()
    photo_manager.add_photo("Family")
    photo_observer.update("Friends")

    print("Concurrency Pattern - Monitor")
    photo_processor = PhotoProcessor()

    threading.Thread(target=photo_processor.process_photo, args=("Sunset",)).start()
    photo_processor.process_photo("Beach")

if __name__ == "__main__":
    main()
