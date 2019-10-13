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
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{

	}
    public DataView bindgridview()
    {
        String Q = "select distinct item_type from items";
        String Connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
        DataSet ds = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter(Q, Connstr);
        ad.Fill(ds, "items");
        DataView dv = new DataView();
        dv.Table = ds.Tables[0];
        return dv;
    }
}
