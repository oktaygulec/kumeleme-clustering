using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kumeleme_Solution_WinForm
{
    public partial class Grafik_View : Form
    {
        public Chart Chart { get; set; }
        public Grafik_View()
        {
            InitializeComponent();
        }

        private void Grafik_View_Load(object sender, EventArgs e)
        {
            foreach (var item in Chart.Legends)
            {
                chart1.Legends.Add(item);
            }
            foreach (var item in Chart.Series)
            {
                chart1.Series.Add(item);
            }
        }
    }
}
