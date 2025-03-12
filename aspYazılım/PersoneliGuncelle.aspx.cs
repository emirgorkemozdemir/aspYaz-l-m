using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspYazılım
{
    public partial class PersoneliGuncelle : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["kullanici_girisli_mi"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                // sayfanın ilk yüklenmesi postback olmaz. postback bir tuşa basılırsa ve sayfa yenilenirse çalışır
                if (!Page.IsPostBack)
                {
                    string secili_id = Request.QueryString["id"].ToString();

                    SqlConnectionClass.connection.Open();

                    SqlCommand command_select = new SqlCommand("SELECT * FROM personel WHERE id = @pid", SqlConnectionClass.connection);
                    command_select.Parameters.AddWithValue("@pid", secili_id);

                    SqlDataReader reader = command_select.ExecuteReader();

                    while (reader.Read())
                    {
                        tboxAd.Text = reader[1].ToString();
                        tboxSoyad.Text = reader[2].ToString();
                        tboxTelefon.Text = reader[3].ToString();
                        tboxEmail.Text = reader[4].ToString();
                        tboxPozisyon.Text = reader[5].ToString();
                        tboxMaas.Text = reader[6].ToString();
                        tboxAktiflik.Text = reader[8].ToString();
                    }

                    reader.Close();
                    SqlConnectionClass.connection.Close();
                }
               
            }
          
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string secili_id = Request.QueryString["id"].ToString();

            SqlConnectionClass.connection.Open();

            SqlCommand command_update = new SqlCommand("UPDATE personel SET ad = @pad , soyad =@psoyad , telefon = @ptel , email =@pmail , pozisyon = @ppozisyon , maas = @pmaas, aktif_durum = @paktiflik WHERE id = @pid",SqlConnectionClass.connection);

            command_update.Parameters.AddWithValue("@pad",tboxAd.Text);
            command_update.Parameters.AddWithValue("@psoyad",tboxSoyad.Text);
            command_update.Parameters.AddWithValue("@ptel",tboxTelefon.Text);
            command_update.Parameters.AddWithValue("@pmail",tboxEmail.Text);
            command_update.Parameters.AddWithValue("@ppozisyon",tboxPozisyon.Text);
            command_update.Parameters.AddWithValue("@pmaas",Convert.ToDecimal(tboxMaas.Text));
            command_update.Parameters.AddWithValue("@paktiflik", tboxAktiflik.Text);
            command_update.Parameters.AddWithValue("@pid", secili_id);

            command_update.ExecuteNonQuery();

            SqlConnectionClass.connection.Close();

            Response.Redirect("Personelİslemleri.aspx");
        }
    }
}