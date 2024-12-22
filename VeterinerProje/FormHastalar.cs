using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace VeterinerProje
{
    public partial class FormHastalar : Form
    {
        public FormHastalar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;" +
           "Database=dbveterinerklinik;user ID=postgres;password=121006");

        private void BtnHastaVeSahipler_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hasta_ve_sahibi_bilgileri()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnHastaveRandevu_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hastalar_ve_randevular()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnHastaYas_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hasta_yaslari()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}