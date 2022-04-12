using Kumeleme_Solution_WinForm.Datasets;

namespace Kumeleme_Solution_WinForm.Models
{
    public class Data
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Cluster { get; set; }
        public string State { get; set; }

        public Data(double x, double y)
        {
            int count = Datas.Items.Count == 0 ? 1 : Datas.Items.Count + 1;
            Name = "X" + count;
            X = x;
            Y = y;
        }
    }
}
