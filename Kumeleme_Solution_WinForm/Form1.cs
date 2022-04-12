using Kumeleme_Solution_WinForm.Datasets;
using Kumeleme_Solution_WinForm.Models;
using Kumeleme_Solution_WinForm.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kumeleme_Solution_WinForm
{
    public partial class Form1 : Form
    {
        BindingSource dataBS = new BindingSource();
        BindingSource clusterBS = new BindingSource();
        BindingSource centerBS = new BindingSource();

        List<BindingSource> sources = new List<BindingSource>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Helpers.SetDGVStyles(dgv_Datas);
            Helpers.SetDGVStyles(dgv_Clusters);
            Helpers.SetDGVStyles(dgv_Centers);

            dataBS = Helpers.CreateBS(Datas.Items, dgv_Datas);
            clusterBS = Helpers.CreateBS(Clusters.Items, dgv_Clusters);
            centerBS = Helpers.CreateBS(Centers.Items, dgv_Centers);

            sources.Add(dataBS);
            sources.Add(clusterBS);
            sources.Add(centerBS);

            txtX.Focus();
        }

        private void btnYeniVeriEkle_Click(object sender, EventArgs e)
        {
            if (cbDurum.Enabled && cbDurum.SelectedItem == null)
            {
                MessageBox.Show("Durum seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double xData;
            double yData;

            bool isXValid = double.TryParse(txtX.Text, out xData);
            bool isYValid = double.TryParse(txtY.Text, out yData);

            if (isXValid == false || isYValid == false)
            {
                MessageBox.Show("Sadece sayı girişi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Data item = new Data(xData, yData);

            if (cbDurum.Enabled)
                item.State = cbDurum.SelectedItem as string;
            else
                Calculate.FindState(item);

            Datas.Add(item);

            Helpers.RefreshBSs(sources);

            if (item.Cluster != null)
            {
                clusterPointChart.Series[item.Cluster].Points.AddXY(item.X, item.Y);
                clusterPointChart.Series[item.Cluster].MarkerSize = 8;
                clusterPointChart.Series[item.Cluster].MarkerStyle = MarkerStyle.Circle;
            }

            txtX.Text = "";
            txtY.Text = "";

            txtX.Focus();
        }

        private void btnVeriCikar_Click(object sender, EventArgs e)
        {
            dataBS.RemoveCurrent();
            Clusters.RefreshClusters();

            Helpers.RefreshBSs(sources);
            Helpers.SetPointChart(clusterPointChart);
        }

        private void btnKumele_Click(object sender, EventArgs e)
        {
            cbDurum.Enabled = false;

            if ((dataBS.DataSource as List<Data>).Count < 1)
            {
                MessageBox.Show("En az bir veri eklemeniz gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numKumeAdet.Value < 1)
            {
                MessageBox.Show("En az bir küme eklemeniz gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numKumeAdet.Value > (dataBS.DataSource as List<Data>).Count)
            {
                MessageBox.Show("Küme sayısı, veri sayısından büyük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int counter = 1;

            foreach (var item in Datas.Items)
            {
                item.Cluster = "C" + counter;
                counter = counter == (int)numKumeAdet.Value ? 1 : counter + 1;
            }


            if (((int)numKumeAdet.Value != Centers.Items.Count) || Centers.Items.Count == 0)
            {
                Clusters.CreateClusters(Convert.ToInt16(numKumeAdet.Value));
                Centers.CreateCenters();
                Distances.CreateDistances();
            }
            Calculate.Cluster();
            Helpers.RefreshBSs(sources);
            Helpers.SetPointChart(clusterPointChart);
            
        }

        private void btnAdimKumele_Click(object sender, EventArgs e)
        {
            cbDurum.Enabled = false;

            if ((dataBS.DataSource as List<Data>).Count < 1)
            {
                MessageBox.Show("En az bir veri eklemeniz gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numKumeAdet.Value < 1)
            {
                MessageBox.Show("En az bir küme eklemeniz gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numKumeAdet.Value > (dataBS.DataSource as List<Data>).Count)
            {
                MessageBox.Show("Küme sayısı, veri sayısından büyük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(Clusters.Items.Count != (int)numKumeAdet.Value)
            {
                int counter = 1;

                foreach (var item in Datas.Items)
                {
                    item.Cluster = "C" + counter;
                    counter = counter == (int)numKumeAdet.Value ? 1 : counter + 1;
                }

                Clusters.CreateClusters(Convert.ToInt16(numKumeAdet.Value));
                Centers.CreateCenters();
                Distances.CreateDistances();
            }


            Calculate.Cluster(false);
            Helpers.RefreshBSs(sources);
            Helpers.SetPointChart(clusterPointChart);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cbDurum.Enabled = true;
            Centers.Items.Clear();
            Clusters.Items.Clear();
            Datas.Items.Clear();
            Distances.Items.Clear();

            clusterPointChart.Series.Clear();
            clusterPointChart.Legends.Clear();

            Helpers.RefreshBSs(sources);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTestVeriGetir_Click(object sender, EventArgs e)
        {
            cbDurum.Enabled = false;
            Datas.SetTestData();
            dataBS.DataSource = Datas.Items;

            Clusters.CreateClusters(2);
            Centers.CreateCenters();
            Distances.CreateDistances();

            Helpers.RefreshBSs(sources);
            Helpers.SetPointChart(clusterPointChart);
        }

        private void btnGrafikTamEkran_Click(object sender, EventArgs e)
        {
            if (clusterPointChart.Series.Count > 0)
            {
                Grafik_View gv = new Grafik_View();
                gv.Chart = clusterPointChart;
                gv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Herhangi bir veri yok...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVeriOlustur_Click(object sender, EventArgs e)
        {
            cbDurum.Enabled = false;
            Datas.SetRandomData(int.Parse(txtVeriOlustur.Text));
            dataBS.DataSource = Datas.Items;

            Clusters.CreateClusters(2);
            Centers.CreateCenters();
            Distances.CreateDistances();

            Helpers.RefreshBSs(sources);
            Helpers.SetPointChart(clusterPointChart);
        }
    }
}
