from django.db import models
#define class with the  below component(self, id, x, y)
class GeoPoint():
   def __init__(self, id, x, y):
      self.ID = id
      self.X = x
      self.Y = y