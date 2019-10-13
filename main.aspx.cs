using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    if (Session["un"] == "")
     {
        Response.Redirect("Home.aspx");
      }
       else
        Label1.Text = "welcome"+Session["un"].ToString();
    String Q = "select * from dummy where username='" + System.Web.HttpContext.Current.Session["un"].ToString() + "'";
    String Connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
    SqlConnection con = new SqlConnection(Connstr);
    con.Open();
    SqlCommand cmd = new SqlCommand(Q, con);
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
        Label2.Text = "you have added to your cart the following items";
        this.GridView1.DataSource = dr;
        this.GridView1.DataBind();

    }
    else
    {
        Label2.Text = "Your cart is empty. Click on menu to select your item";
    }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();

    }
}
