using Kumeleme_Solution_WinForm.Datasets;
using Kumeleme_Solution_WinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kumeleme_Solution_WinForm.Utils
{
    public static class Calculate
    {
        public static double Center(List<double> datas)
        {
            double sum = datas.Sum(x => x);
            double count = datas.Count;
            return sum / count;
        }

        public static double Distance(Center center, Data data)
        {
            double x = Math.Pow((center.X - data.X), 2);
            double y = Math.Pow((center.Y - data.Y), 2);
            return Math.Sqrt((x + y));
        }

        public static void FindState(Data data)
        {
            // Calculate the distances by given data
            List<Distance> distances = new List<Distance>();
            Center center = new Center("Center1", data.X, data.Y);
            foreach (var item in Datas.Items)
            {
                distances.Add(new Distance(center, item));
            }

            // Get minimum distances (k pieces)
            List<Distance> minDistances = new List<Distance>();
            int k = distances.Count < 4 ? distances.Count : 4; // How many distance are we getting in datas?

            for (int i = 0; i < k; i++)
            {
                minDistances.Add(distances.OrderBy(x => x.Value).ElementAt(i));
            }

            // Find most states and change data's state
            var iyi = minDistances.FindAll(x => x.Data.State == "İyi");
            var kotu = minDistances.FindAll(x => x.Data.State == "Kötü");

            data.State = iyi.Count > kotu.Count ? "İyi" : "Kötü";
        }

        public static void Cluster(bool iterate = true)
        {
            bool isUpdated = true;
            while (isUpdated)
            {
                isUpdated = false;
                for (int i = 0; i < Datas.Items.Count; i++)
                {
                    List<Distance> distances = new List<Distance>();

                    foreach (var item in Distances.Items)
                    {
                        distances.Add(item.Distances[i]);
                    }

                    Distance min = distances.FirstOrDefault(x => x.Value == distances.Min(y => y.Value));

                    string clusterName = "C" + min.Center.Name.Substring(1);
                    if (clusterName != Datas.Items[i].Cluster)
                    {
                        Datas.ChangeCluster(Datas.Items[i], clusterName);

                        isUpdated = true;
                    }
                    if (!iterate) isUpdated = false;
                }
            }
        }
    }
}
