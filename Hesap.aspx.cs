using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hesap : System.Web.UI.Page
{
    static ulong faktoriyel(ulong a)
    {
        ulong sonuc = 1;
        for (ulong i = 1; i <= a; i++)
        {
            sonuc = i * sonuc;
        }
        return sonuc;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        String deger = Request.QueryString["veri"];
        Label1.Text = deger;
        ulong takimsayisi = Convert.ToUInt32(deger);
        ulong macsayisi = faktoriyel(takimsayisi) / (faktoriyel(2) * faktoriyel(takimsayisi - 2));
        Label2.Text = macsayisi.ToString();
    }
}