class IPhotoObserver:
    def update(self, photo):
        pass


class PhotoObserver(IPhotoObserver):
    def update(self, photo):
        print(f"New photo received: {photo}")
