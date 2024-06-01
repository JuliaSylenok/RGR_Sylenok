import threading
import time

class PhotoProcessor:
    def __init__(self):
        self._lock = threading.Lock()

    def process_photo(self, photo):
        with self._lock:
            print(f"Processing photo: {photo}")
            time.sleep(2)
            print(f"Photo processed: {photo}")
