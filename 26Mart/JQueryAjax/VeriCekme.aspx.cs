using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        var isim=Request["isim"];
        var soyisim = Request["soyisim"];
        Response.Write("Merhaba " +isim+" "+soyisim);  //aspx?isim=yonca&&soyisim=coşkun yaptıgımızda merhaba yonca coşkun gelir
    }
}