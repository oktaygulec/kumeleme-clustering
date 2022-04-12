using Kumeleme_Solution_WinForm.Utils;
using System.Collections.Generic;

namespace Kumeleme_Solution_WinForm.Models
{
    public class Center
    {
        public string Name { get; set; }
        public double X { get; private set; }
        public double Y { get; private set; }

        public Center(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public Center(Cluster cluster)
        {
            string count = (cluster.Name.Substring(1));
            Name = "M" + count;

            List<double> xDatas = new List<double>();
            List<double> yDatas = new List<double>();

            foreach (var item in cluster.Datas)
            {
                xDatas.Add(item.X);
                yDatas.Add(item.Y);
            }

            X = Calculate.Center(xDatas);
            Y = Calculate.Center(yDatas);
        }
    }
}
