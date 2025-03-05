using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspYazılım
{
    public partial class PersoneliSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string selected_id = Request.QueryString["id"].ToString();

            SqlConnectionClass.connection.Open();

            SqlCommand command_delete = new SqlCommand("DELETE FROM personel WHERE id = @pid",SqlConnectionClass.connection);

            command_delete.Parameters.AddWithValue("@pid", selected_id);

            command_delete.ExecuteNonQuery();

            SqlConnectionClass.connection.Close();

            Response.Redirect("Personelİslemleri.aspx");
        }
    }
}