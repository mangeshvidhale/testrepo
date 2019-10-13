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

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label2.Text = Session["un"].ToString();
            TextBox4.Text = Calendar1.TodaysDate.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String Q1 = "insert into deliveryaddress values(NEWID(),'" + Session["un"] + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
        String Connstr1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        SqlConnection con1 = new SqlConnection(Connstr1);
        con1.Open();
        SqlCommand cmd1 = new SqlCommand(Q1, con1);
        cmd1.ExecuteNonQuery();
        Label1.Text = "Your order has been booked";
        //Response.Redirect("Default5.aspx");
        

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String Q2 = "insert into historydelivery select * from deliveryaddress where username='" + Session["un"] + "'";
        String Q3 = "insert into historydummy select username, itemcode, item_description, price, quantity,'" + TextBox4.Text + "' from dummy where username='" + Session["un"] + "'";
       String Connstr2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        String Connstr3 = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
       SqlConnection con2 = new SqlConnection(Connstr2);
        SqlConnection con3 = new SqlConnection(Connstr3);
       con2.Open();
        con3.Open();
       SqlCommand cmd2 = new SqlCommand(Q2, con2);
        SqlCommand cmd3 = new SqlCommand(Q3, con3);
        cmd2.ExecuteNonQuery();
        cmd3.ExecuteNonQuery();
        //Label1.Text = "Your order has been booked";
        Response.Redirect("Default5.aspx");
    }
}
