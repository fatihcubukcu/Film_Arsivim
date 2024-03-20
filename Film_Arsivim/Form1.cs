using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=BONDERENCO;Initial Catalog=FilmArsivim;Integrated Security=True");

        void filmler() { 
            SqlDataAdapter da= new SqlDataAdapter("Select * from TBLFILMLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFILMLER (AD, KATEGORI, LINK) values (@P1,@P2, @P3)" , 
                baglanti);
            komut.Parameters.AddWithValue("@P1", TxtFilmAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtKategori.Text);
            komut.Parameters.AddWithValue("@P3", TxtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film, listenize eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje FATİH ÇUBUKCU tarafından kodlandı.", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
