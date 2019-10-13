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

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = Session["un"].ToString();
            Class3 cs3 = new Class3();
            GridView1.DataSource = cs3.bindgridview();
            GridView1.DataBind();
          

            //bindgridview();
        }
    }
       // void bindgridview()
   // {
        //String Q = "select * from dummy where username='" + Session["un"]+"'";
  //  String Connstr =ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
   // DataSet ds=new DataSet();
    //SqlDataAdapter ad = new SqlDataAdapter(Q,Connstr);
    //ad.Fill(ds,"dummy");
    //GridView1.DataSource=ds.Tables[0];
    //GridView1.DataBind();
    
    //}
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default4.aspx");
        }
}
