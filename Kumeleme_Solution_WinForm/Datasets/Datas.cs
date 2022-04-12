using Kumeleme_Solution_WinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kumeleme_Solution_WinForm.Datasets
{
    public static class Datas
    {
        public static List<Data> Items { get; private set; }

        static Datas()
        {
            Items = new List<Data>();
        }

        public static void SetTestData()
        {
            #region Data With Cluster
            //Items = new List<Data>
            //{
            //    new Data { Name = "X1", X = 3, Y = 8, Cluster = "C1" },
            //    new Data { Name = "X2", X = 7, Y = 4, Cluster = "C2" },
            //    new Data { Name = "X3", X = 5, Y = 1, Cluster = "C2" },
            //    new Data { Name = "X4", X = 6, Y = 3, Cluster = "C2" },
            //    new Data { Name = "X5", X = 4, Y = 9, Cluster = "C1" },
            //    new Data { Name = "X6", X = 6, Y = 2, Cluster = "C2" },
            //    new Data { Name = "X7", X = 3, Y = 3, Cluster = "C2" },
            //    new Data { Name = "X8", X = 1, Y = 6, Cluster = "C1" },
            //    new Data { Name = "X9", X = 5, Y = 5, Cluster = "C2" },
            //    new Data { Name = "X10", X = 6, Y = 4, Cluster = "C2" },
            //    new Data { Name = "X11", X = 7, Y = 3, Cluster = "C2" },
            //    new Data { Name = "X12", X = 8, Y = 2, Cluster = "C2" },
            //    new Data { Name = "X13", X = 5, Y = 1, Cluster = "C2" },
            //    new Data { Name = "X14", X = 4, Y = 5, Cluster = "C1" },
            //    new Data { Name = "X15", X = 3, Y = 6, Cluster = "C1" },
            //    new Data { Name = "X16", X = 2, Y = 7, Cluster = "C1" },
            //    new Data { Name = "X17", X = 1, Y = 8, Cluster = "C1" },
            //    new Data { Name = "X18", X = 2, Y = 9, Cluster = "C1" },
            //    new Data { Name = "X19", X = 3, Y = 5, Cluster = "C1" },
            //    new Data { Name = "X20", X = 4, Y = 2, Cluster = "C2" },
            //    new Data { Name = "X21", X = 5, Y = 3, Cluster = "C2" },
            //    new Data { Name = "X22", X = 6, Y = 1, Cluster = "C2" },
            //    new Data { Name = "X23", X = 7, Y = 5, Cluster = "C2" },
            //    new Data { Name = "X24", X = 8, Y = 4, Cluster = "C2" },
            //    new Data { Name = "X25", X = 9, Y = 3, Cluster = "C2" },
            //};
            #endregion

            Items.Clear();
            List<double> xs = new List<double> { 3, 7, 5, 6, 4, 6, 3, 1, 5, 6, 7, 8, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<double> ys = new List<double> { 8, 4, 1, 3, 9, 2, 3, 6, 5, 4, 3, 2, 1, 5, 6, 7, 8, 9, 5, 2, 3, 1, 5, 4, 3 };
            List<string> states = new List<string> { "İyi", "İyi", "Kötü", "İyi", "Kötü", "Kötü", "Kötü", "İyi", "Kötü", "Kötü", "İyi", "İyi", "İyi", "Kötü", "İyi", "Kötü", "Kötü", "İyi", "Kötü", "Kötü", "İyi", "Kötü", "İyi", "İyi", "İyi"};
            int counter = 1;
            
            for (int i = 0; i < 25; i++)
            {
                Data item = new Data(xs[i], ys[i]);
                item.Cluster = "C" + counter;
                item.State = states[i];
                counter = counter == 2 ? 1 : counter + 1;

                Add(item);
            }

        }

        public static void SetRandomData(int count)
        {
            int counter = 1;
            Items.Clear();
            List<string> states = new List<string> { "İyi", "Kötü" };

            Random r1 = new Random();
            Random r2 = new Random();

            for (int i = 0; i < count; i++)
            {
                Data item = new Data(r1.NextDouble() * 10, r2.NextDouble() * 10);
                item.Cluster = "C" + counter;
                item.State = states[r1.Next(0, 2)];
                counter = counter == 2 ? 1 : counter + 1;

                Add(item);
            }
        }

        public static void Add(Data newData)
        {
            if (String.IsNullOrWhiteSpace(newData.Cluster))
            {
                Distance distance = Distances.FindMinDistance(newData);
                
                if(distance != null)
                {
                    Distances.NewDistance(distance);

                    newData.Cluster = distance.Data.Cluster;
                }
            }
            else
            {
                Clusters.AddNewDataToExistingCluster(newData);
            }

            Items.Add(newData);

            Clusters.RefreshClusters();
            Distances.CreateDistances();
        }

        public static void ChangeCluster(Data data, string clusterName)
        {
            Items.FirstOrDefault(x => x == data).Cluster = clusterName;
            Clusters.RefreshClusters();
            Centers.CreateCenters();
            Distances.CreateDistances();
        }
    }
}
