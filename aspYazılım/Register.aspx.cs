using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspYazılım
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public bool Kullanici_Adi_Var_Mi()
        {
            SqlConnectionClass.connection.Open();

            SqlCommand command = new SqlCommand("SELECT kullanici_adi FROM kullanici WHERE kullanici_adi = @pka",SqlConnectionClass.connection);

            command.Parameters.AddWithValue("@pka",tboxUsername.Text);

            SqlDataReader data_reader = command.ExecuteReader();


            if (data_reader.HasRows== true)
            {
                data_reader.Close();
                SqlConnectionClass.connection.Close();
                return true;
            }
            else
            {
                data_reader.Close();
                SqlConnectionClass.connection.Close();
                return false;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Kullanici_Adi_Var_Mi() == false)
            {
                SqlConnectionClass.connection.Open();

                SqlCommand command_insert = new SqlCommand("INSERT INTO kullanici (kullanici_adi, sifre,rol) VALUES (@pka,@ppass,@prol)", SqlConnectionClass.connection);
                command_insert.Parameters.AddWithValue("@pka", tboxUsername.Text);
                command_insert.Parameters.AddWithValue("@ppass", Sha256Class.ComputeSha256Hash(tboxPassword.Text));
                command_insert.Parameters.AddWithValue("@prol", 2);

                command_insert.ExecuteNonQuery();

                SqlConnectionClass.connection.Close();
            }
            else
            {
                Response.Write("Bu kullanıcı adı alınmıştır");
            }
        }

   
    }
}