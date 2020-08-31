using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class GameDeclerat : System.Web.UI.Page
{
    SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-PQ6KTMRS\\SQLEXPRESS;Initial Catalog=Web;Integrated Security=True");

    String deger;
    protected void Page_Load(object sender, EventArgs e)
    {
         deger = Request.QueryString["veri"];
        if (deger == "19")
        {
            this.Tr20.Visible = false;
        }
        if (deger == "18")
        {
            this.Tr20.Visible = false;
            this.Tr19.Visible = false;
        }
        if (deger == "17")
        {
            this.Tr20.Visible = false;
            this.Tr19.Visible = false;
            this.Tr18.Visible = false;
        }
        if (deger == "16")
        {
            this.Tr20.Visible = false;
            this.Tr19.Visible = false;
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
        }
        if (deger == "15")
        {
            this.Tr20.Visible = false;
            this.Tr19.Visible = false;
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
        }
        if (deger == "14")
        {
            this.Tr20.Visible = false;
            this.Tr19.Visible = false;
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
            this.Tr15.Visible = false;
        }
        if (deger == "13")
        {
            this.Tr20.Visible = false;
            this.Tr19.Visible = false;
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
            this.Tr15.Visible = false;
            this.Tr14.Visible = false;
        }
        if (deger == "12")
        {
            this.Tr20.Visible = false;
            this.Tr19.Visible = false;
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
            this.Tr15.Visible = false;
            this.Tr14.Visible = false;
            this.Tr13.Visible = false;
        }
        if (deger == "11")
        {
            this.Tr20.Visible = false;
            this.Tr19.Visible = false;
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
            this.Tr15.Visible = false;
            this.Tr14.Visible = false;
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
        }
        if (deger == "10")
        {
            this.Tr20.Visible = false; 
            this.Tr19.Visible = false;
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
            this.Tr15.Visible = false;
            this.Tr14.Visible = false;
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
        }
        if (deger == "9")
        {
            this.Tr20.Visible = false; 
            this.Tr19.Visible = false; 
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
            this.Tr15.Visible = false;
            this.Tr14.Visible = false;
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
            this.Tr10.Visible = false;
        }
        if (deger == "8")
        {
            this.Tr20.Visible = false; this.Tr9.Visible = false;
            this.Tr19.Visible = false; 
            this.Tr18.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
            this.Tr15.Visible = false;
            this.Tr14.Visible = false;
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
            this.Tr10.Visible = false;
        }
        if (deger == "7")
        {
            this.Tr20.Visible = false; this.Tr9.Visible = false;
            this.Tr19.Visible = false; this.Tr8.Visible = false;
            this.Tr18.Visible = false; 
            this.Tr17.Visible = false; 
            this.Tr16.Visible = false; 
            this.Tr15.Visible = false; 
            this.Tr14.Visible = false; 
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
            this.Tr10.Visible = false;
        }
        if (deger == "6")
        {
            this.Tr20.Visible = false; this.Tr9.Visible = false;
            this.Tr19.Visible = false; this.Tr8.Visible = false;
            this.Tr18.Visible = false; this.Tr7.Visible = false;
            this.Tr17.Visible = false;
            this.Tr16.Visible = false;
            this.Tr15.Visible = false; 
            this.Tr14.Visible = false; 
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
            this.Tr10.Visible = false;
        }
        if (deger == "5")
        {
            this.Tr20.Visible = false; this.Tr9.Visible = false;
            this.Tr19.Visible = false; this.Tr8.Visible = false;
            this.Tr18.Visible = false; this.Tr7.Visible = false;
            this.Tr17.Visible = false; this.Tr6.Visible = false;
            this.Tr16.Visible = false; 
            this.Tr15.Visible = false; 
            this.Tr14.Visible = false; 
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
            this.Tr10.Visible = false;
        }
        if (deger == "4")
        {
            this.Tr20.Visible = false; this.Tr9.Visible = false;
            this.Tr19.Visible = false; this.Tr8.Visible = false;
            this.Tr18.Visible = false; this.Tr7.Visible = false;
            this.Tr17.Visible = false; this.Tr6.Visible = false;
            this.Tr16.Visible = false; this.Tr5.Visible = false;
            this.Tr15.Visible = false; 
            this.Tr14.Visible = false; 
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
            this.Tr10.Visible = false;
        }
        if (deger == "3")
        {
            this.Tr20.Visible = false; this.Tr9.Visible = false;
            this.Tr19.Visible = false; this.Tr8.Visible = false;
            this.Tr18.Visible = false; this.Tr7.Visible = false;
            this.Tr17.Visible = false; this.Tr6.Visible = false;
            this.Tr16.Visible = false; this.Tr5.Visible = false;
            this.Tr15.Visible = false; this.Tr4.Visible = false;
            this.Tr14.Visible = false; 
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
            this.Tr10.Visible = false;
        }
        if(deger == "2")
        {
            this.Tr20.Visible = false; this.Tr9.Visible = false;this.Tr19.Visible = false; this.Tr8.Visible = false;this.Tr18.Visible = false; this.Tr7.Visible = false;this.Tr17.Visible = false; this.Tr6.Visible = false;this.Tr16.Visible = false; this.Tr5.Visible = false;this.Tr15.Visible = false; this.Tr4.Visible = false;this.Tr14.Visible = false; this.Tr3.Visible = false;
            this.Tr13.Visible = false;
            this.Tr12.Visible = false;
            this.Tr11.Visible = false;
            this.Tr10.Visible = false;
        }

    }
    protected void Button5_Click(object sender, EventArgs e)
    {

    }
    protected void Button5_Click1(object sender, EventArgs e)
    {
        //for (int i = 1; i <= 20;i++ )
        //{
        //    this.("Tr"+i).Visible = false;
        //}
    }
    protected void Button5_Click2(object sender, EventArgs e)
    {
        Response.Redirect("MainPage.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Hesap.aspx?veri=" + deger);
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Hesap.aspx?veri=" + deger);
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        baglanti.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;

        //for (int i = 1; i <= 39; i++)
        //{
            
        //    TextBox tBox = new TextBox();
        //    tBox.ID= "TextBox" + i.ToString();
        //    TextBox textBox1 = new TextBox();
        //    textBox1.ID = "TextBox" + (i + 1).ToString();
        //    if (tBox.Text != "" && textBox1.Text != "")
        //    {
        //        cmd.CommandText = "INSERT INTO Team(teamname,discription) VALUES ('" + (tBox.ID).Text + "','" + (textBox1.ID).Text + "')";
        //        cmd.ExecuteNonQuery();
        //        cmd.Dispose();
        //    }
           
        //}

        if (TextBox1.Text != "" && TextBox2.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team(teamname,discription) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox3.Text != "" && TextBox4.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team(teamname,discription) VALUES ('" + TextBox3.Text + "','" + TextBox4.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox5.Text != "" && TextBox6.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team(teamname,discription) VALUES ('" + TextBox5.Text + "','" + TextBox6.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox7.Text != "" && TextBox8.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team(teamname,discription) VALUES ('" + TextBox7.Text + "','" + TextBox8.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox9.Text != "" && TextBox10.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team(teamname,discription) VALUES ('" + TextBox9.Text + "','" + TextBox10.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox11.Text != "" && TextBox12.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox11.Text + "','" + TextBox12.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox13.Text != "" && TextBox14.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox13.Text + "','" + TextBox14.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox15.Text != "" && TextBox16.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox15.Text + "','" + TextBox16.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox17.Text != "" && TextBox18.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox17.Text + "','" + TextBox18.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox19.Text != "" && TextBox20.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox19.Text + "','" + TextBox20.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox21.Text != "" && TextBox22.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox21.Text + "','" + TextBox22.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox23.Text != "" && TextBox24.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox23.Text + "','" + TextBox24.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox25.Text != "" && TextBox26.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox25.Text + "','" + TextBox26.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox27.Text != "" && TextBox28.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox27.Text + "','" + TextBox28.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox29.Text != "" && TextBox30.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox29.Text + "','" + TextBox30.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox31.Text != "" && TextBox32.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox31.Text + "','" + TextBox32.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox33.Text != "" && TextBox34.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox33.Text + "','" + TextBox34.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox35.Text != "" && TextBox36.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox35.Text + "','" + TextBox36.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox37.Text != "" && TextBox38.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox37.Text + "','" + TextBox38.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        if (TextBox39.Text != "" && TextBox40.Text != "")
        {
            cmd.CommandText = "INSERT INTO Team VALUES ('" + TextBox39.Text + "','" + TextBox40.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        baglanti.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

    }
}