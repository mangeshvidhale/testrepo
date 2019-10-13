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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

     loginview1();

       
    }
    void loginview1()
    {
        String Q = "select username, password from customers where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
        String Connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        SqlConnection con = new SqlConnection(Connstr);
        con.Open();
        SqlCommand cmd = new SqlCommand(Q, con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            // FormsAuthentication.RedirectFromLoginPage(TextBox1.Text,false);
            Response.Redirect("main.aspx?id=" + TextBox1.Text);
        }
        else
        {
            Label1.Text = "pls login";
        }
    }
}
