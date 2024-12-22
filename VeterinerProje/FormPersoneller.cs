using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerProje
{
    public partial class FormPersoneller : Form
    {
        public FormPersoneller()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;"+
            "Database=dbveterinerklinik;user ID=postgres;password=121006");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personeller";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           
                // Girdileri kontrol et
                if (string.IsNullOrWhiteSpace(TxtID.Text))
                {
                    MessageBox.Show("Personel ID alanı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtAd.Text))
                {
                    MessageBox.Show("Ad alanı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtSoyad.Text))
                {
                    MessageBox.Show("Soyad alanı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtGorev.Text))
                {
                    MessageBox.Show("Tür alanı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtTelefon.Text))
                {
                    MessageBox.Show("Telefon alanı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Veritabanı işlemleri
                baglanti.Open();

                NpgsqlCommand komut = new NpgsqlCommand("insert into personeller (id,ad,soyad,personel_tur,telefon,baslangictarih,cikistarih)" +
                    " values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);

                komut.Parameters.AddWithValue("@p1", int.Parse(TxtID.Text));
                komut.Parameters.AddWithValue("@p2", TxtAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p4", TxtGorev.Text);
                komut.Parameters.AddWithValue("@p5", TxtTelefon.Text);
                komut.Parameters.AddWithValue("@p6", baslangicTarih.Value);

                if (cikisTarih.Checked)
                {
                    komut.Parameters.AddWithValue("@p7", cikisTarih.Value);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p7", DBNull.Value);
                }

                komut.ExecuteNonQuery(); // Değişiklikleri veritabanına yansıt
                baglanti.Close();

                MessageBox.Show("Personel kaydı başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void BtnIDAra_Click(object sender, EventArgs e)

        {
            try
            {
                
                baglanti.Open();

                
                string sorgu = "SELECT * FROM personeller WHERE id = @p1";

                
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", int.Parse(TxtID.Text)); 

                
                NpgsqlDataReader reader = komut.ExecuteReader();

                
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("ad");
                dt.Columns.Add("soyad");
                dt.Columns.Add("personel_tur");
                dt.Columns.Add("telefon");
                dt.Columns.Add("baslangictarih");
                dt.Columns.Add("cikistarih");

                if (reader.Read()) // Eğer kayıt bulunursa
                {
                    
                    DataRow row = dt.NewRow();
                    row["id"] = reader["id"];
                    row["ad"] = reader["ad"];
                    row["soyad"] = reader["soyad"];
                    row["personel_tur"] = reader["personel_tur"];
                    row["telefon"] = reader["telefon"];
                    row["baslangictarih"] = reader["baslangictarih"];
                    row["cikistarih"] = reader["cikistarih"] != DBNull.Value ? reader["cikistarih"] : DBNull.Value;

                    dt.Rows.Add(row); 
                    dataGridView1.DataSource = dt; 

                    MessageBox.Show("Aranan personel bulundu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Aranan personel bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.DataSource = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                baglanti.Close();
            }
        }


        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From personeller where id=@p1 ",baglanti );
            komut2.Parameters.AddWithValue("@p1",int.Parse(TxtID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Personel silme işlemi başarılı şekilde gerçekleşti.", "Bilgi",MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
        }

        private void BtnGüncelleme_Click(object sender, EventArgs e)
        {
            baglanti.Open() ;
            NpgsqlCommand komut3 = new NpgsqlCommand("Update personeller set " +
                "ad=@p1,soyad=@p2,personel_tur=@p3,telefon=@p4,baslangictarih=@p5,cikistarih=@p6 where id=@p7", baglanti);
            
            komut3.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut3.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut3.Parameters.AddWithValue("@p3", TxtGorev.Text);
            komut3.Parameters.AddWithValue("@p4", TxtTelefon.Text);
            komut3.Parameters.AddWithValue("@p5", baslangicTarih.Value);
            if (cikisTarih.Checked)
            {
                komut3.Parameters.AddWithValue("@p6", cikisTarih.Value);
            }
            else
            {
                komut3.Parameters.AddWithValue("@p6", DBNull.Value);
            }
            komut3.Parameters.AddWithValue("@p7", int.Parse(TxtID.Text));
            

            komut3.ExecuteNonQuery();
            MessageBox.Show("Personel güncelleme işlemi başarılı şekilde gerçekleşti.","Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning );

            baglanti.Close();
        }

        private void BtnEneskiPersonel_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from en_eski_baslangic_tarihi()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
