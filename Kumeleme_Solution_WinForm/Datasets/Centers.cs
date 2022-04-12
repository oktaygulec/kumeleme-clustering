using Kumeleme_Solution_WinForm.Models;
using System.Collections.Generic;

namespace Kumeleme_Solution_WinForm.Datasets
{
    public static class Centers
    {
        public static List<Center> Items { get; private set; }

        static Centers()
        {
            Items = new List<Center>();
        }

        public static void CreateCenters()
        {
            Items.Clear();
            foreach (var cluster in Clusters.Items)
                Items.Add(new Center(cluster));
        }
    }
}
