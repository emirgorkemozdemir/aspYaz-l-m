using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspYazılım
{
    public partial class Personelİslemleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullanici_girisli_mi"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                SqlConnectionClass.connection.Open();

                SqlCommand command_list = new SqlCommand("SELECT * FROM personel", SqlConnectionClass.connection);

                SqlDataAdapter da = new SqlDataAdapter(command_list);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DataList1.DataSource = dt;
                DataList1.DataBind();

                SqlConnectionClass.connection.Close();
            }       
        }

        protected void GoToAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("PersonelEkle.aspx");
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            SqlConnectionClass.connection.Open();

            SqlCommand command_list = new SqlCommand("SELECT * FROM personel WHERE telefon LIKE @pfilter OR email LIKE @pfilter", SqlConnectionClass.connection);
            command_list.Parameters.AddWithValue("@pfilter","%"+tboxFilter.Text+"%");

            SqlDataAdapter da = new SqlDataAdapter(command_list);

            DataTable dt = new DataTable();

            da.Fill(dt);

            DataList1.DataSource = dt;
            DataList1.DataBind();

            SqlConnectionClass.connection.Close();
        }

        protected void tboxFilter_TextChanged(object sender, EventArgs e)
        {
            SqlConnectionClass.connection.Open();

            SqlCommand command_list = new SqlCommand("SELECT * FROM personel WHERE telefon LIKE @pfilter OR email LIKE @pfilter", SqlConnectionClass.connection);
            command_list.Parameters.AddWithValue("@pfilter", "%" + tboxFilter.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(command_list);

            DataTable dt = new DataTable();

            da.Fill(dt);

            DataList1.DataSource = dt;
            DataList1.DataBind();

            SqlConnectionClass.connection.Close();
        }
    }
}