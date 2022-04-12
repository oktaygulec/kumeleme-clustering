
namespace Kumeleme_Solution_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.dgv_Clusters = new System.Windows.Forms.DataGridView();
            this.dgv_Centers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Datas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDurum = new System.Windows.Forms.ComboBox();
            this.btnVeriCikar = new System.Windows.Forms.Button();
            this.btnYeniVeriEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.clusterPointChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGrafikTamEkran = new System.Windows.Forms.Button();
            this.btnKumele = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.numKumeAdet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOrnekVeriGetir = new System.Windows.Forms.Button();
            this.btnAdimKumele = new System.Windows.Forms.Button();
            this.txtVeriOlustur = new System.Windows.Forms.TextBox();
            this.btnVeriOlustur = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clusters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Centers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterPointChart)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKumeAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Clusters
            // 
            this.dgv_Clusters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clusters.Location = new System.Drawing.Point(6, 19);
            this.dgv_Clusters.Name = "dgv_Clusters";
            this.dgv_Clusters.Size = new System.Drawing.Size(280, 144);
            this.dgv_Clusters.TabIndex = 17;
            // 
            // dgv_Centers
            // 
            this.dgv_Centers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Centers.Location = new System.Drawing.Point(6, 19);
            this.dgv_Centers.Name = "dgv_Centers";
            this.dgv_Centers.Size = new System.Drawing.Size(280, 138);
            this.dgv_Centers.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(318, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 41);
            this.label1.TabIndex = 56;
            this.label1.Text = "KÜMELEME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Datas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 351);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veriler";
            // 
            // dgv_Datas
            // 
            this.dgv_Datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datas.Location = new System.Drawing.Point(6, 19);
            this.dgv_Datas.Name = "dgv_Datas";
            this.dgv_Datas.Size = new System.Drawing.Size(276, 326);
            this.dgv_Datas.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Clusters);
            this.groupBox2.Location = new System.Drawing.Point(358, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 169);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kümeler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Centers);
            this.groupBox3.Location = new System.Drawing.Point(358, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 163);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Merkezler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cbDurum);
            this.groupBox5.Controls.Add(this.btnVeriCikar);
            this.groupBox5.Controls.Add(this.btnYeniVeriEkle);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtY);
            this.groupBox5.Controls.Add(this.txtX);
            this.groupBox5.Location = new System.Drawing.Point(28, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 187);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Yeni Veri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(199, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Durum";
            // 
            // cbDurum
            // 
            this.cbDurum.FormattingEnabled = true;
            this.cbDurum.Items.AddRange(new object[] {
            "İyi",
            "Kötü"});
            this.cbDurum.Location = new System.Drawing.Point(202, 45);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(70, 21);
            this.cbDurum.TabIndex = 2;
            // 
            // btnVeriCikar
            // 
            this.btnVeriCikar.BackColor = System.Drawing.Color.Firebrick;
            this.btnVeriCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeriCikar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriCikar.ForeColor = System.Drawing.Color.White;
            this.btnVeriCikar.Location = new System.Drawing.Point(14, 135);
            this.btnVeriCikar.Name = "btnVeriCikar";
            this.btnVeriCikar.Size = new System.Drawing.Size(258, 35);
            this.btnVeriCikar.TabIndex = 4;
            this.btnVeriCikar.Text = "ÇIKAR";
            this.btnVeriCikar.UseVisualStyleBackColor = false;
            this.btnVeriCikar.Click += new System.EventHandler(this.btnVeriCikar_Click);
            // 
            // btnYeniVeriEkle
            // 
            this.btnYeniVeriEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnYeniVeriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniVeriEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniVeriEkle.ForeColor = System.Drawing.Color.White;
            this.btnYeniVeriEkle.Location = new System.Drawing.Point(15, 94);
            this.btnYeniVeriEkle.Name = "btnYeniVeriEkle";
            this.btnYeniVeriEkle.Size = new System.Drawing.Size(258, 35);
            this.btnYeniVeriEkle.TabIndex = 3;
            this.btnYeniVeriEkle.Text = "EKLE";
            this.btnYeniVeriEkle.UseVisualStyleBackColor = false;
            this.btnYeniVeriEkle.Click += new System.EventHandler(this.btnYeniVeriEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(106, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(109, 46);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(70, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(14, 46);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(70, 20);
            this.txtX.TabIndex = 0;
            // 
            // clusterPointChart
            // 
            chartArea2.Name = "ChartArea1";
            this.clusterPointChart.ChartAreas.Add(chartArea2);
            this.clusterPointChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clusterPointChart.Location = new System.Drawing.Point(3, 16);
            this.clusterPointChart.Name = "clusterPointChart";
            this.clusterPointChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.clusterPointChart.Size = new System.Drawing.Size(479, 168);
            this.clusterPointChart.TabIndex = 12;
            this.clusterPointChart.Text = "chart1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnGrafikTamEkran);
            this.groupBox7.Controls.Add(this.clusterPointChart);
            this.groupBox7.Location = new System.Drawing.Point(358, 72);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(485, 187);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Küme Grafiği";
            // 
            // btnGrafikTamEkran
            // 
            this.btnGrafikTamEkran.BackColor = System.Drawing.Color.Navy;
            this.btnGrafikTamEkran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafikTamEkran.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnGrafikTamEkran.ForeColor = System.Drawing.Color.White;
            this.btnGrafikTamEkran.Location = new System.Drawing.Point(443, 146);
            this.btnGrafikTamEkran.Margin = new System.Windows.Forms.Padding(0);
            this.btnGrafikTamEkran.Name = "btnGrafikTamEkran";
            this.btnGrafikTamEkran.Size = new System.Drawing.Size(36, 36);
            this.btnGrafikTamEkran.TabIndex = 10;
            this.btnGrafikTamEkran.Text = "⛶";
            this.btnGrafikTamEkran.UseVisualStyleBackColor = false;
            this.btnGrafikTamEkran.Click += new System.EventHandler(this.btnGrafikTamEkran_Click);
            // 
            // btnKumele
            // 
            this.btnKumele.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKumele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKumele.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKumele.ForeColor = System.Drawing.Color.White;
            this.btnKumele.Location = new System.Drawing.Point(690, 392);
            this.btnKumele.Name = "btnKumele";
            this.btnKumele.Size = new System.Drawing.Size(153, 52);
            this.btnKumele.TabIndex = 6;
            this.btnKumele.Text = "KÜMELE";
            this.btnKumele.UseVisualStyleBackColor = false;
            this.btnKumele.Click += new System.EventHandler(this.btnKumele_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(690, 516);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(153, 52);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // numKumeAdet
            // 
            this.numKumeAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKumeAdet.Location = new System.Drawing.Point(690, 326);
            this.numKumeAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKumeAdet.Name = "numKumeAdet";
            this.numKumeAdet.Size = new System.Drawing.Size(153, 31);
            this.numKumeAdet.TabIndex = 5;
            this.numKumeAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(685, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Küme Sayısı";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Firebrick;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(690, 578);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(153, 52);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOrnekVeriGetir
            // 
            this.btnOrnekVeriGetir.BackColor = System.Drawing.Color.Tomato;
            this.btnOrnekVeriGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrnekVeriGetir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnekVeriGetir.ForeColor = System.Drawing.Color.White;
            this.btnOrnekVeriGetir.Location = new System.Drawing.Point(742, 16);
            this.btnOrnekVeriGetir.Name = "btnOrnekVeriGetir";
            this.btnOrnekVeriGetir.Size = new System.Drawing.Size(101, 41);
            this.btnOrnekVeriGetir.TabIndex = 11;
            this.btnOrnekVeriGetir.Text = "ÖRNEK VERİ";
            this.btnOrnekVeriGetir.UseVisualStyleBackColor = false;
            this.btnOrnekVeriGetir.Click += new System.EventHandler(this.btnTestVeriGetir_Click);
            // 
            // btnAdimKumele
            // 
            this.btnAdimKumele.BackColor = System.Drawing.Color.Orange;
            this.btnAdimKumele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdimKumele.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdimKumele.ForeColor = System.Drawing.Color.White;
            this.btnAdimKumele.Location = new System.Drawing.Point(690, 454);
            this.btnAdimKumele.Name = "btnAdimKumele";
            this.btnAdimKumele.Size = new System.Drawing.Size(153, 52);
            this.btnAdimKumele.TabIndex = 7;
            this.btnAdimKumele.Text = "ADIM ADIM KÜMELE";
            this.btnAdimKumele.UseVisualStyleBackColor = false;
            this.btnAdimKumele.Click += new System.EventHandler(this.btnAdimKumele_Click);
            // 
            // txtVeriOlustur
            // 
            this.txtVeriOlustur.Location = new System.Drawing.Point(28, 37);
            this.txtVeriOlustur.Name = "txtVeriOlustur";
            this.txtVeriOlustur.Size = new System.Drawing.Size(71, 20);
            this.txtVeriOlustur.TabIndex = 57;
            // 
            // btnVeriOlustur
            // 
            this.btnVeriOlustur.BackColor = System.Drawing.Color.Tomato;
            this.btnVeriOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeriOlustur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriOlustur.ForeColor = System.Drawing.Color.White;
            this.btnVeriOlustur.Location = new System.Drawing.Point(115, 9);
            this.btnVeriOlustur.Name = "btnVeriOlustur";
            this.btnVeriOlustur.Size = new System.Drawing.Size(163, 48);
            this.btnVeriOlustur.TabIndex = 58;
            this.btnVeriOlustur.Text = "RASTGELE VERİ OLUŞTUR";
            this.btnVeriOlustur.UseVisualStyleBackColor = false;
            this.btnVeriOlustur.Click += new System.EventHandler(this.btnVeriOlustur_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Veri Sayısı";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnYeniVeriEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 648);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVeriOlustur);
            this.Controls.Add(this.txtVeriOlustur);
            this.Controls.Add(this.btnAdimKumele);
            this.Controls.Add(this.btnOrnekVeriGetir);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numKumeAdet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKumele);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kümeleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clusters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Centers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterPointChart)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKumeAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Clusters;
        private System.Windows.Forms.DataGridView dgv_Centers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Datas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnVeriCikar;
        private System.Windows.Forms.Button btnYeniVeriEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.DataVisualization.Charting.Chart clusterPointChart;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnKumele;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.NumericUpDown numKumeAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOrnekVeriGetir;
        private System.Windows.Forms.Button btnGrafikTamEkran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDurum;
        private System.Windows.Forms.Button btnAdimKumele;
        private System.Windows.Forms.TextBox txtVeriOlustur;
        private System.Windows.Forms.Button btnVeriOlustur;
        private System.Windows.Forms.Label label6;
    }
}

