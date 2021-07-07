using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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

        public static List<System.Drawing.Rectangle> GetXml(string filename)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filename);
            XmlNodeList nodes = xmlDocument.GetElementsByTagName("bndbox");
            List<System.Drawing.Rectangle> lRectangles = new List<System.Drawing.Rectangle>();
            foreach(XmlNode xmlNode in nodes)
            {
                XmlNode xmin = xmlNode["xmin"];
                float tlx = float.Parse(xmin.InnerText);
                XmlNode ymin = xmlNode["ymin"];
                float tly = float.Parse(ymin.InnerText);
                XmlNode xmax = xmlNode["xmax"];
                float brx = float.Parse(xmax.InnerText);
                XmlNode ymax = xmlNode["ymax"];
                float bry = float.Parse(ymax.InnerText);
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle((int)tlx, (int)tly, (int)(brx - tlx), (int)(bry -tly));
                lRectangles.Add(rectangle);
            }
            return lRectangles;
        }

    }
}
