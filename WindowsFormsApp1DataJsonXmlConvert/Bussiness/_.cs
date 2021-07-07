using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1DataJsonXmlConvert.Geometry;

namespace WindowsFormsApp1DataJsonXmlConvert.Bussiness
{
    class _
    {
        public static Stack<List<Point>> GetPointsFromJsonFile(string fileName)
        {
            string json = File.ReadAllText(fileName);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            var objCount = jsonObj["objects"].Count;
            Stack<List<Point>> stac = new Stack<List<Point>>(); 
            for (int i = 0; i < objCount; i++)
            {
                var polygon = jsonObj["objects"][i]["polygon"];
                var polgonCount = polygon.Count;
                List<Point> points = new List<Point>();
                for (int j = 0; j < polgonCount; j++)
                {
                    var poin = polygon[j];
                    int x = poin[0];
                    int y = poin[1];
                    Point p = new Point(x, y);
                    points.Add(p);
                }
                stac.Push(points);
            }
            return stac;
        }

    }
}
