using Geowebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Geowebapi.Controllers
{
    public class GeoController : ApiController
    {
        public List<GeoPoint> Points = new List<GeoPoint>()
{
// import points to the list
                new GeoPoint() {ID = 1, X = 460221.80, Y = 4088755.54 },
                new GeoPoint() {ID = 2, X = 460230.86, Y = 4088751.13 },
                new GeoPoint() {ID = 3, X = 460231.03, Y = 4088749.14 },
                new GeoPoint() {ID = 4, X = 460232.26, Y = 4088746.41 },
                new GeoPoint() {ID = 5, X = 460234.89, Y = 4088746.18 },
                new GeoPoint() {ID = 6, X = 460237.36, Y = 4088746.50 },
                new GeoPoint() {ID = 7, X = 460241.06, Y = 4088746.99 },
                new GeoPoint() {ID = 8, X = 460242.13, Y = 4088742.55 },
                new GeoPoint() {ID = 9, X = 460242.09, Y = 4088742.03 },
                new GeoPoint() {ID = 10,X = 460242.45, Y = 4088740.87},
                new GeoPoint() {ID = 11,X = 460242.83, Y = 4088738.46 },
                new GeoPoint() {ID = 12,X = 460242.97, Y = 4088736.53 },
                new GeoPoint() {ID = 13,X = 460243.01, Y = 4088734.06 },
                new GeoPoint() {ID = 14,X = 460243.03, Y = 4088731.68 },
                new GeoPoint() {ID = 15,X = 460217.48, Y = 4088744.87 },

};
        //write function to get id that exist in list or database
        private GeoPoint getbyID(int id)
        {
            GeoPoint point = null;
            foreach (GeoPoint pt in Points)
            {
                if (pt.ID == id)
                {
                    point = new GeoPoint();
                    point = pt;
                }
            }
            return point;
        }
        
        public IHttpActionResult GetPointByID(int id)
        {
            GeoPoint point = getbyID(id);
            if (point == null)
                return NotFound();
            return Ok(point);
        }
        //write function to calculate distance between interest point and point with specefic id
        public IHttpActionResult GetDistance(double x, double y, int id)
        {
            GeoPoint point = getbyID(id);
            if (point == null)
                return NotFound();
            double distance = Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2));
            return Ok(distance);
        }

        //write function to calculate closest id with respect to interest point
        public IHttpActionResult GetClosestPoint(double x, double y)
        {
            GeoPoint closestPoint = null;
            double closestDistance = double.MaxValue;

            foreach (GeoPoint point in Points)
            {
                double distance = Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2));
                if (distance < closestDistance)
                {
                    closestPoint = point;
                    closestDistance = distance;
                }
            }

            if (closestPoint == null)
                return NotFound();

            return Ok(closestPoint.ID);
        }


    }
}
