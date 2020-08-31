using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class LastSeason : System.Web.UI.Page
{
    SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-PQ6KTMRS\\SQLEXPRESS;Initial Catalog=Web;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            cnn.Open();
            string query = "Select * From Team";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }
        finally
        {
            cnn.Close();
        }
    }
}