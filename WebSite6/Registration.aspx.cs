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
        registration1();
    }

    void registration1()
    {
        String Connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        SqlConnection con = new SqlConnection(Connstr);
        con.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.Connection = con;
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandText = "insertrecord";
        cmd1.Parameters.AddWithValue("@customerID", int.Parse(TextBox1.Text));
        cmd1.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@address", TextBox3.Text);
        cmd1.Parameters.AddWithValue("@city", TextBox4.Text);
        cmd1.Parameters.AddWithValue("@country", TextBox5.Text);
        cmd1.Parameters.AddWithValue("@pincode", TextBox6.Text);
        cmd1.Parameters.AddWithValue("@phone", int.Parse(TextBox7.Text));
        cmd1.Parameters.AddWithValue("@username", TextBox8.Text);
        cmd1.Parameters.AddWithValue("@password", TextBox9.Text);
        cmd1.ExecuteNonQuery();
        Response.Redirect("Home.aspx");
      
    }
}
