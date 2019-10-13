using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class2
/// </summary>
public class Class2
{
	public Class2()
	{
	}
    public DataView bindgridview()
    {

        String Q = "select * from dummy where username='" + System.Web.HttpContext.Current.Session["un"].ToString() + "'";
        String Connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        DataSet ds = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter(Q, Connstr);
        ad.Fill(ds, "dummy");
        DataView dv = new DataView();
        dv.Table = ds.Tables[0];
        return dv;
    }
}
