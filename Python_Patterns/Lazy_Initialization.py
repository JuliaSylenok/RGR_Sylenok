class PhotoManager:
    def __init__(self):
        self._photo_list = None

    @property
    def photo_list(self):
        if self._photo_list is None:
            self._photo_list = []
        return self._photo_list

    def add_photo(self, photo):
        self.photo_list.append(photo)
        print(f"Photo added: {photo}")

    def display_photos(self):
        print("Photos:")
        for photo in self.photo_list:
            print(photo)
