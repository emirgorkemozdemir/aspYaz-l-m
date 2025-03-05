using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspYazılım
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnectionClass.connection.Open();

            SqlCommand command_login = new SqlCommand("SELECT * FROM kullanici WHERE kullanici_adi = @pka AND sifre = @ppass",SqlConnectionClass.connection);

            command_login.Parameters.AddWithValue("@pka",tboxUsername.Text.ToLower().Trim());
            command_login.Parameters.AddWithValue("@ppass",Sha256Class.ComputeSha256Hash(tboxPassword.Text));

            SqlDataReader data_reader = command_login.ExecuteReader();

            if (data_reader.HasRows == true)
            {
                while (data_reader.Read())
                {
                    Session["kullanici_id"] = data_reader[0].ToString();
                    Session["kullanici_adi"] = data_reader[1].ToString(); 
                    Session["kullanici_rol"] = data_reader[3].ToString();
                    Session["kullanici_girisli_mi"] ="true";
                }
                data_reader.Close();
                SqlConnectionClass.connection.Close();
                Response.Write("Giriş başarılı");
                Response.Redirect("Personelİslemleri.aspx");
            }
            else
            {
                data_reader.Close();
                SqlConnectionClass.connection.Close();
                Response.Write("Giriş başarısız");
            }
        }
    }
}