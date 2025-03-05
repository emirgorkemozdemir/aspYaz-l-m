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
    }
}