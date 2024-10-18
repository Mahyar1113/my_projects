import sqlite3
import math

def calculate_distance(x1, y1, x2, y2):
    return math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2)

def find_closest_point(x, y):
    cursor.execute('''
        SELECT id, x, y
        FROM points
        ORDER BY ((x - ?) * (x - ?) + (y - ?) * (y - ?))
        LIMIT 1
    ''', (x, x, y, y))

    row = cursor.fetchone()
    if row:
        point_id, point_x, point_y = row
        return point_id
    else:
        return None

conn = sqlite3.connect('list of points.db')
cursor = conn.cursor()

x = float(input("input your point as x: "))
y = float(input("input your point as y: "))

closest_point_id = find_closest_point(x, y)
if closest_point_id is not None:
    print(f"The closest point ID is: {closest_point_id}")
else:
    print("No points found in the database.")

    

conn.close()