namespace Film_Arsivim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFilmler = new System.Windows.Forms.GroupBox();
            this.gbEkran = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbYeniFilm = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFilmAd = new System.Windows.Forms.TextBox();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnTamEkran = new System.Windows.Forms.Button();
            this.BtnHakkımızda = new System.Windows.Forms.Button();
            this.BtnRenkDegistir = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbFilmler.SuspendLayout();
            this.gbEkran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbYeniFilm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 86);
            this.panel1.TabIndex = 0;
            // 
            // gbFilmler
            // 
            this.gbFilmler.Controls.Add(this.dataGridView1);
            this.gbFilmler.Location = new System.Drawing.Point(316, 104);
            this.gbFilmler.Name = "gbFilmler";
            this.gbFilmler.Size = new System.Drawing.Size(291, 504);
            this.gbFilmler.TabIndex = 1;
            this.gbFilmler.TabStop = false;
            this.gbFilmler.Text = "FİLMLER";
            // 
            // gbEkran
            // 
            this.gbEkran.Controls.Add(this.webBrowser1);
            this.gbEkran.Location = new System.Drawing.Point(605, 104);
            this.gbEkran.Name = "gbEkran";
            this.gbEkran.Size = new System.Drawing.Size(629, 501);
            this.gbEkran.TabIndex = 2;
            this.gbEkran.TabStop = false;
            this.gbEkran.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(623, 480);
            this.webBrowser1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbYeniFilm
            // 
            this.gbYeniFilm.Controls.Add(this.groupBox1);
            this.gbYeniFilm.Controls.Add(this.BtnKaydet);
            this.gbYeniFilm.Controls.Add(this.TxtLink);
            this.gbYeniFilm.Controls.Add(this.label3);
            this.gbYeniFilm.Controls.Add(this.TxtKategori);
            this.gbYeniFilm.Controls.Add(this.label2);
            this.gbYeniFilm.Controls.Add(this.TxtFilmAd);
            this.gbYeniFilm.Controls.Add(this.label1);
            this.gbYeniFilm.Location = new System.Drawing.Point(13, 104);
            this.gbYeniFilm.Name = "gbYeniFilm";
            this.gbYeniFilm.Size = new System.Drawing.Size(297, 504);
            this.gbYeniFilm.TabIndex = 3;
            this.gbYeniFilm.TabStop = false;
            this.gbYeniFilm.Text = "YENİ FİLM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // TxtFilmAd
            // 
            this.TxtFilmAd.Location = new System.Drawing.Point(77, 31);
            this.TxtFilmAd.Name = "TxtFilmAd";
            this.TxtFilmAd.Size = new System.Drawing.Size(209, 22);
            this.TxtFilmAd.TabIndex = 1;
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(77, 65);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(209, 22);
            this.TxtKategori.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori:";
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(77, 101);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(209, 22);
            this.TxtLink.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Link:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Lime;
            this.BtnKaydet.FlatAppearance.BorderSize = 50;
            this.BtnKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(77, 129);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(209, 32);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCikis);
            this.groupBox1.Controls.Add(this.BtnRenkDegistir);
            this.groupBox1.Controls.Add(this.BtnHakkımızda);
            this.groupBox1.Controls.Add(this.BtnTamEkran);
            this.groupBox1.Location = new System.Drawing.Point(6, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 296);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İŞLEMLER";
            // 
            // BtnTamEkran
            // 
            this.BtnTamEkran.FlatAppearance.BorderSize = 50;
            this.BtnTamEkran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnTamEkran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnTamEkran.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTamEkran.Location = new System.Drawing.Point(33, 75);
            this.BtnTamEkran.Name = "BtnTamEkran";
            this.BtnTamEkran.Size = new System.Drawing.Size(209, 32);
            this.BtnTamEkran.TabIndex = 7;
            this.BtnTamEkran.Text = "TAM EKRAN";
            this.BtnTamEkran.UseVisualStyleBackColor = true;
            // 
            // BtnHakkımızda
            // 
            this.BtnHakkımızda.FlatAppearance.BorderSize = 50;
            this.BtnHakkımızda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnHakkımızda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnHakkımızda.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHakkımızda.Location = new System.Drawing.Point(33, 113);
            this.BtnHakkımızda.Name = "BtnHakkımızda";
            this.BtnHakkımızda.Size = new System.Drawing.Size(209, 32);
            this.BtnHakkımızda.TabIndex = 8;
            this.BtnHakkımızda.Text = "HAKKIMIZDA";
            this.BtnHakkımızda.UseVisualStyleBackColor = true;
            this.BtnHakkımızda.Click += new System.EventHandler(this.BtnHakkımızda_Click);
            // 
            // BtnRenkDegistir
            // 
            this.BtnRenkDegistir.FlatAppearance.BorderSize = 50;
            this.BtnRenkDegistir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRenkDegistir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnRenkDegistir.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRenkDegistir.Location = new System.Drawing.Point(33, 151);
            this.BtnRenkDegistir.Name = "BtnRenkDegistir";
            this.BtnRenkDegistir.Size = new System.Drawing.Size(209, 32);
            this.BtnRenkDegistir.TabIndex = 9;
            this.BtnRenkDegistir.Text = "RENK DEĞİŞTİR";
            this.BtnRenkDegistir.UseVisualStyleBackColor = true;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Red;
            this.BtnCikis.FlatAppearance.BorderSize = 50;
            this.BtnCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnCikis.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(33, 189);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(209, 32);
            this.BtnCikis.TabIndex = 10;
            this.BtnCikis.Text = "ÇIKIŞ YAP";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(285, 483);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1245, 612);
            this.Controls.Add(this.gbYeniFilm);
            this.Controls.Add(this.gbEkran);
            this.Controls.Add(this.gbFilmler);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gbFilmler.ResumeLayout(false);
            this.gbEkran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbYeniFilm.ResumeLayout(false);
            this.gbYeniFilm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbFilmler;
        private System.Windows.Forms.GroupBox gbEkran;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox gbYeniFilm;
        private System.Windows.Forms.TextBox TxtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnRenkDegistir;
        private System.Windows.Forms.Button BtnHakkımızda;
        private System.Windows.Forms.Button BtnTamEkran;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

