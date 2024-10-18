from WAPI.models import GeoPoint
from django.http import JsonResponse, HttpResponse
import math
#function1:it returns id of point in list and use it in next functions
def get_by_id(id):
    result = GeoPoint(-1, 0, 0)
    point1 = GeoPoint(1, 460221.80, 4088755.54)
    point2 = GeoPoint(2, 460230.86, 4088751.13)
    point3 = GeoPoint(3, 460231.03, 4088749.14)
    point4 = GeoPoint(4, 460232.26, 4088746.41)
    points = [point1, point2, point3, point4]

    for pt in points:
        if pt.ID == id:
            result = pt
    return result
#function2:calculate distanse between points in the list and point with x,y
def get_distance(x, y, id):
    point = get_by_id(id)
    distance = math.sqrt(math.pow(point.X - x, 2) + math.pow(point.Y - y, 2))
    return distance
#function3:calculate closest point in the list with respect to interesrt point
def get_closest_point(x, y):
    points = [
        GeoPoint(1, 460221.80, 4088755.54),
        GeoPoint(2, 460230.86, 4088751.13),
        GeoPoint(3, 460231.03, 4088749.14),
        GeoPoint(4, 460232.26, 4088746.41)
    ]
    closest_point = None
    min_distance = float('inf')

    for point in points:
        distance = math.sqrt((point.X - x) ** 2 + (point.Y - y) ** 2)
        if distance < min_distance:
            min_distance = distance
            closest_point = point

    return closest_point



##action1:it return id of point in the list or database
def GetPointByID(request, id):
    point = get_by_id(id)
    data = {'ID': point.ID, 'X': point.X, 'Y': point.Y}
    return JsonResponse(data)
##action2:it invoke distance between interest point and points in the list
def GetDistance(request, x, y, id):
    distance = get_distance(x, y, id)
    return HttpResponse(distance)
##action3: it invoke closest point id  ( x,y(optional) ) in our list
def GetClosestPoint(request, x, y):
    closest_point = get_closest_point(x, y)
    data = {'ID': closest_point.ID, 'X': closest_point.X, 'Y': closest_point.Y}
    return JsonResponse(data)