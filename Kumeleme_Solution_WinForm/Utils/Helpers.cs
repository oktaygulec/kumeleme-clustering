using Kumeleme_Solution_WinForm.Datasets;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kumeleme_Solution_WinForm.Utils
{
    public static class Helpers
    {
        public static void SetPointChart(Chart chart)
        {
            chart.Series.Clear();
            chart.Legends.Clear();

            chart.Legends.Add("Kümeler");
            chart.Legends["Kümeler"].Title = "Kümeler";
            chart.Legends["Kümeler"].Docking = Docking.Left;

            chart.Legends.Add("Merkezler");
            chart.Legends["Merkezler"].Title = "Merkezler";
            chart.Legends["Merkezler"].Docking = Docking.Right;

            foreach (var item in Clusters.Items)
            {
                chart.Series.Add(item.Name);
                chart.Series[item.Name].ChartType = SeriesChartType.Point;
                chart.Series[item.Name].Legend = "Kümeler";
            }

            foreach (var item in Datas.Items)
            {
                chart.Series[item.Cluster].Points.AddXY(item.X, item.Y);
                chart.Series[item.Cluster].MarkerSize = 8;
                chart.Series[item.Cluster].MarkerStyle = MarkerStyle.Circle;
            }

            foreach (var item in Centers.Items)
            {
                chart.Series.Add(item.Name);
                chart.Series[item.Name].ChartType = SeriesChartType.Point;
                chart.Series[item.Name].Legend = "Merkezler";

                chart.Series[item.Name].Points.AddXY(item.X, item.Y);
                chart.Series[item.Name].MarkerSize = 10;
                chart.Series[item.Name].MarkerStyle = MarkerStyle.Circle;
                chart.Series[item.Name].MarkerColor = Color.Red;
            }
        }

        public static void SetDGVStyles(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = Color.White;
            dgv.ReadOnly = true;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static BindingSource CreateBS(object Items, DataGridView dgv)
        {
            BindingSource source = new BindingSource();
            source.DataSource = Items;
            dgv.DataSource = source;
            return source;
        }

        public static void RefreshBSs(List<BindingSource> sources)
        {
            foreach (var item in sources)
            {
                item.ResetBindings(false);
            }
        }
    }
}
