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
/// Summary description for Class4
/// </summary>
public class Class4
{
	public Class4()
	{
	}
    public DataView bindgridview()
    {
        String pid1 = System.Web.HttpContext.Current.Request.QueryString["id"];
        String Q = "select * from items where item_type='" + pid1 + "'";
        String Connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        DataSet ds = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter(Q, Connstr);
        ad.Fill(ds, "items");
        DataView dv = new DataView();
        dv.Table = ds.Tables[0];
        return dv;
    }
}
