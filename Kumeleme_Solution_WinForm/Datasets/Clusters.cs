using Kumeleme_Solution_WinForm.Models;
using System.Collections.Generic;
using System.Linq;

namespace Kumeleme_Solution_WinForm.Datasets
{
    public static class Clusters
    {
        public static List<Cluster> Items { get; private set; }

        static Clusters()
        {
            Items = new List<Cluster>();
        }

        public static void CreateClusters(int count)
        {
            Items.Clear();
            for (int i = 0; i < count; i++)
                Items.Add(new Cluster(Datas.Items));
        }

        public static void RefreshClusters()
        {
            int count = Items.Count;
            CreateClusters(count);
        }

        public static void AddNewDataToExistingCluster(Data newData)
        {
            foreach (var cluster in Items)
            {
                if (cluster.Name == newData.Cluster)
                {
                    cluster.Datas.Add(newData);
                    break;
                }
            }
        }

        public static List<Data> GetSpecificClusterDatas(Data data)
        {
            List<Data> datas = new List<Data>();

            foreach (var item in Items)
            {
                if (data.Cluster == item.Name)
                {
                    datas.Add(data);
                }
            }

            return datas;
        }

        public static Cluster GetClusterByName(string name)
        {
            return Items.FirstOrDefault(x => x.Name == name);
        }
    }
}
