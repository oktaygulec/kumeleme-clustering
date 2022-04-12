using Kumeleme_Solution_WinForm.Datasets;
using System.Collections.Generic;

namespace Kumeleme_Solution_WinForm.Models
{
    public class Cluster
    {
        public string Name { get; set; }
        public List<Data> Datas { get; set; }
        public string DataNames { get; private set; }
        public string DataX { get; private set; }
        public string DataY { get; private set; }

        public Cluster(List<Data> datas)
        {
            int count = (Clusters.Items == null ? 1 : Clusters.Items.Count + 1);

            Name = "C" + count;
            Datas = new List<Data>();

            foreach (var item in datas)
            {
                if (item.Cluster == Name)
                {
                    Datas.Add(item);
                    DataNames += item.Name + " ";
                    DataX += item.X.ToString() + " ";
                    DataY += item.Y.ToString() + " ";
                }
            }
        }
    }
}
