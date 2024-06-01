class IPhotoViewer:
    def display_photo(self):
        pass


class PhotoViewer(IPhotoViewer):
    def __init__(self, photo):
        self._photo = photo

    def display_photo(self):
        print(f"Displaying photo: {self._photo}")


class ProxyPhotoViewer(IPhotoViewer):
    def __init__(self, photo):
        self._photo = photo
        self._photo_viewer = None

    def display_photo(self):
        if self._photo_viewer is None:
            self._photo_viewer = PhotoViewer(self._photo)
        self._photo_viewer.display_photo()
