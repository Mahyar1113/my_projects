using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;



namespace Geowebservice
{
    //[WebService(Namespace = "http://example.com/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class Geo : WebService
    {
        //WebMethod1:invoke point with spesefic id from list
        [WebMethod]
        public GeoPoint GetPointByID(int id)
        {
            GeoService geoService = new GeoService();
            GeoPoint point = geoService.GetById(id);
            return point;
        }
        //WebMethod2:calculate distance between interest point and point with specefic id
        [WebMethod]
        public double GetDistance(double x, double y, int id)
        {
            GeoService geoService = new GeoService();
            GeoPoint point = geoService.GetById(id);
            if (point != null)
            {
                return Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2));
            }
            return 0;
        }
        //WebMethod3:calculate closest id with respect to interest point and show id
        [WebMethod]
        public GeoPoint GetClosestPosition(double importX, double importY)
        {
            GeoService geoService = new GeoService();

            GeoPoint closestPoint = null;
            double minDistance = double.MaxValue;

            foreach (GeoPoint point in geoService.Points)
            {
                double distance = Math.Sqrt(Math.Pow(point.X - importX, 2) + Math.Pow(point.Y - importY, 2));
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestPoint = point;
                }
            }

            return closestPoint;
        }
    

        



    }
}
