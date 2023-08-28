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
using System.Linq.Expressions;
using System.Data.Common;

namespace MarketOtomasyonu
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GF5TQSU\\SQLEXPRESS;Initial Catalog=Market;Integrated Security=True");
        DataTable tablo = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        void VeriGetir() 
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM MarketOtomasyonu", baglanti);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            

            baglanti.Open();
            adap.Fill(tablo);
            komut.ExecuteNonQuery();
            dgw_UrunListesi.DataSource = tablo;
            baglanti.Close();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dgw_UrunListesi_CellEnter(object sender, DataGridViewCellEventArgs e) 
        {
            try
            {
                txt_UrunNo.Text = dgw_UrunListesi.CurrentRow.Cells[0].Value.ToString();
                txt_UrunAdi.Text = dgw_UrunListesi.CurrentRow.Cells[1].Value.ToString();
                txt_urunkodu.Text = dgw_UrunListesi.CurrentRow.Cells[2].Value.ToString();
                txt_BoxSatisFiyati.Text = dgw_UrunListesi.CurrentRow.Cells[3].Value.ToString();
                txt_BoxGelisFiyati.Text = dgw_UrunListesi.CurrentRow.Cells[4].Value.ToString();
                comboBoxUrunTuru.Text = dgw_UrunListesi.CurrentRow.Cells[5].Value.ToString();
                txt_BoxSTT.Text = dgw_UrunListesi.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                 
            }
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            String sorgu = "INSERT INTO MarketOtomasyonu(UrunAdi,UrunNo, UrunKodu, UrunFiyati, UrunTuru,UrunSTT) VALUES (@ad,@no,@kodu,@fiyat,@turu,@STT)";
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
           
                komut.Parameters.AddWithValue("@ad", txt_UrunAdi.Text);
                komut.Parameters.AddWithValue("@kodu", Convert.ToInt32(txt_urunkodu.Text));
                komut.Parameters.AddWithValue("turu", comboBoxUrunTuru.Text);
                komut.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txt_BoxSatisFiyati.Text));
                komut.Parameters.AddWithValue("@STT", Convert.ToDateTime(txt_BoxSTT.Text));
                komut.Parameters.AddWithValue("@no", Convert.ToInt32(txt_UrunNo.Text));
            
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                VeriGetir();
                MessageBox.Show("Ürün Başarıyla Eklenmiş");

        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            String sorgu = "DELETE FROM MarketOtomasyonu WHERE UrunNo=@no";
            SqlCommand komut = new SqlCommand(sorgu,baglanti);

            komut.Parameters.AddWithValue("@no",Convert.ToInt32(txt_UrunNo.Text));
           
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();   
            VeriGetir();

            MessageBox.Show("Ürün Silme İşlemi Başarıyla Gerçekleşmiştir");
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {  
            
            String sorgu = "UPDATE MarketOtomasyonu SET UrunAdi=@ad,UrunNo=@no,UrunKodu=@kod, UrunFiyati=@fiyat, UrunTuru=@urunturu, UrunSTT=@stt WHERE UrunNo=@no";
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
           
                komut.Parameters.AddWithValue("@ad", txt_UrunAdi.Text);
                komut.Parameters.AddWithValue("@kod", Convert.ToInt32(txt_urunkodu.Text));
                komut.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txt_BoxSatisFiyati.Text));
                komut.Parameters.AddWithValue("@urunturu", comboBoxUrunTuru.Text);
                komut.Parameters.AddWithValue("@stt", Convert.ToDateTime(txt_BoxSTT.Text));
                komut.Parameters.AddWithValue("@no", Convert.ToInt32(txt_UrunNo.Text));

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                VeriGetir();

                MessageBox.Show("Ürün Güncelleme Başarıyla Gerçekleşmiştir");    
       }
        private void txt_UrunArama_TextChanged(object sender, EventArgs e) 
        {
            DataView dv = tablo.DefaultView;   
            dv.RowFilter = "UrunAdi LIKE'" + txt_UrunArama.Text + "%'"; 
          
            dgw_UrunListesi.DataSource = dv;

        }
    }
}
