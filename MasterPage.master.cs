using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // bindgridview();
            Class1 cl = new Class1();
            GridView1.DataSource = cl.bindgridview();
            GridView1.DataBind();
        }
    }
    //void bindgridview()
    //{
      //  String Q = "select distinct item_type from items";
       // String Connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
       // DataSet ds = new DataSet();
       // SqlDataAdapter ad = new SqlDataAdapter(Q, Connstr);
       // ad.Fill(ds,"items");
       // GridView1.DataSource = ds.Tables[0];
       // GridView1.DataBind();
   // }
}
