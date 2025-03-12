using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspYazılım
{
    public partial class PersonelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullanici_girisli_mi"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnectionClass.connection.Open();

            SqlCommand command_insert = new SqlCommand("INSERT INTO personel (ad, soyad, telefon, email, pozisyon, maas, aktif_durum,ise_giris_tarihi) VALUES (@pad, @psoyad, @ptel, @pmail, @ppozisyon, @pmaas, @paktiflik,@ptarih)", SqlConnectionClass.connection);

            command_insert.Parameters.AddWithValue("@pad", tboxAd.Text);
            command_insert.Parameters.AddWithValue("@psoyad", tboxSoyad.Text);
            command_insert.Parameters.AddWithValue("@ptel", tboxTelefon.Text);
            command_insert.Parameters.AddWithValue("@pmail", tboxEmail.Text);
            command_insert.Parameters.AddWithValue("@ppozisyon", tboxPozisyon.Text);
            command_insert.Parameters.AddWithValue("@pmaas", Convert.ToDecimal(tboxMaas.Text));
            command_insert.Parameters.AddWithValue("@paktiflik", tboxAktiflik.Text);
            command_insert.Parameters.AddWithValue("@ptarih", DateTime.Now);


            command_insert.ExecuteNonQuery();

            SqlConnectionClass.connection.Close();

            Response.Redirect("Personelİslemleri.aspx");
        }
    }
}