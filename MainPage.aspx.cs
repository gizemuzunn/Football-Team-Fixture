using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class MainPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int value = Convert.ToInt32(TextBox1.Text); 
        if(value <2 || value >20 )
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal2();", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("GameDecleration.aspx?veri="+TextBox1.Text);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("LastSeason.aspx");
    }
}