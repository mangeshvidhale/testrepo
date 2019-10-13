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
using CrystalDecisions.CrystalReports.Engine;

public partial class Default5 : System.Web.UI.Page
{
    ReportDocument rep;
    DataSet1 ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        String Q1 = "select * from deliveryaddress where username='" + Session["un"] + "'";
        String Connstr1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        SqlConnection con1 = new SqlConnection(Connstr1);
        con1.Open();
        SqlCommand cmd1 = new SqlCommand(Q1, con1);
        SqlDataReader dr = cmd1.ExecuteReader();
        if(dr.Read())
        {
        Label2.Text=dr[0].ToString();
        }
        String Q2 = "select sum(price *quantity) from dummy where username='" + Session["un"] + "'";
        String Connstr2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        SqlConnection con2 = new SqlConnection(Connstr2);
        con2.Open();
        SqlCommand cmd2 = new SqlCommand(Q2, con2);
        SqlDataReader dr1 = cmd2.ExecuteReader();
        if (dr1.Read())
        {
            Label3.Text = "you need to pay Rs" + dr1[0].ToString();
        }

        ds = new DataSet1();
        rep = new ReportDocument();
        String Q3 = "select itemcode, item_description, price, quantity from dummy where username='" + Session["un"] + "'";
        String Connstr3 = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        SqlDataAdapter ad = new SqlDataAdapter(Q3,Connstr3);
        ad.Fill(ds,"dummy");
        rep.Load(@"C:/Documents and Settings/garima/My Documents/Visual Studio 2008/WebSite6/CrystalReport.rpt");
        rep.SetDataSource(ds);
        CrystalReportViewer1.ReportSource = rep;
        CrystalReportViewer1.DataBind();


    }
   
}
