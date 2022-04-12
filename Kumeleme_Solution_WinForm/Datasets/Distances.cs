using Kumeleme_Solution_WinForm.Models;
using System.Collections.Generic;
using System.Linq;

namespace Kumeleme_Solution_WinForm.Datasets
{
    public static class Distances
    {
        public static List<DistanceGroup> Items { get; set; }

        static Distances()
        {
            Items = new List<DistanceGroup>();
        }

        public static void CreateDistances()
        {
            Items.Clear();
            foreach (var center in Centers.Items)
            {
                List<Distance> distances = new List<Distance>();

                foreach (var data in Datas.Items)
                    distances.Add(new Distance(center, data));

                Items.Add(new DistanceGroup { Name = center.Name, Distances = distances });
            }
        }

        public static void NewDistance(Distance distance)
        {
            foreach (var item in Items)
            {
                if(item.Name == distance.Center.Name)
                {
                    item.Distances.Add(distance);
                    break;
                }
            }
        }

        public static Distance FindMinDistance(Data data)
        {
            Center center = new Center("newItemCenter", data.X, data.Y);

            List<Distance> distances = new List<Distance>();

            foreach (var item in Datas.Items)
            {
                distances.Add(new Distance(center, item));
            }

            Distance minDistance = distances.OrderBy(x => x.Value).FirstOrDefault();

            return minDistance;
        }
    }
}
