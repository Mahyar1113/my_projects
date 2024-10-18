using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Collections.Generic;

namespace Geowebservice
{
    public class GeoPoint
    {
        public int ID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class GeoService
    {
        public List<GeoPoint> Points { get; set; }

        public GeoService()
        {
            Points = new List<GeoPoint>()
            {// import points to the list
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
        }
        //write function to get id that exist in list or database
        public GeoPoint GetById(int id)
        {
            GeoPoint point = null;
            foreach (GeoPoint pt in Points)
            {
                if (pt.ID == id)
                {
                    point = pt;
                    break;
                }
            }
            return point;
        }
    }
    




}