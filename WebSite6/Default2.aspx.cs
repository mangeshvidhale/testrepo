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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = Session["un"].ToString();

            Class2 cs2 = new Class2();
            GridView1.DataSource = cs2.bindgridview();
           GridView1.DataBind();
            //bindgridview();
        }
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;

        Class2 cs2 = new Class2();
        GridView1.DataSource = cs2.bindgridview();
        GridView1.DataBind();

       // bindgridview();

    }
   //void bindgridview()
   // {
        //String Q = "select * from dummy where username='" + Session["un"]+"'";
    //String Connstr =ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
    //DataSet ds=new DataSet();
    //SqlDataAdapter ad = new SqlDataAdapter(Q,Connstr);
    //ad.Fill(ds,"dummy");
    //GridView1.DataSource=ds.Tables[0];
    //GridView1.DataBind();
    //}
   protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
   {
       GridView1.EditIndex = e.NewEditIndex;

       Class2 cs2 = new Class2();
       GridView1.DataSource = cs2.bindgridview();
       GridView1.DataBind();
       //bindgridview();
   }
   protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
   {
       int idx = e.RowIndex;
       GridViewRow row1=GridView1.Rows[idx];
       String itemcode = row1.Cells[0].Text;
       TextBox quantity = (TextBox)row1.Cells[3].Controls[0];
       String Q1 = "update dummy set quantity ='" + quantity.Text + "' where itemcode=" + itemcode;
       String Connstr1 =ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
       SqlConnection con1 = new SqlConnection(Connstr1);
       con1.Open();
       SqlCommand cmd1 = new SqlCommand(Q1,con1);
       cmd1.ExecuteNonQuery();
       GridView1.EditIndex = -1;


       Class2 cs2 = new Class2();
       GridView1.DataSource = cs2.bindgridview();
       GridView1.DataBind();
      // bindgridview();
   }
   protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
   {
       int idx1 = e.RowIndex;
       GridViewRow row1 = GridView1.Rows[idx1];
       String itemcode = row1.Cells[0].Text;
     
       String Q2 = "delete from dummy where itemcode=" + itemcode;
       String Connstr2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
       SqlConnection con2 = new SqlConnection(Connstr2);
       con2.Open();
       SqlCommand cmd1 = new SqlCommand(Q2, con2);
       cmd1.ExecuteNonQuery();

       Class2 cs2 = new Class2();
       GridView1.DataSource = cs2.bindgridview();
       GridView1.DataBind();
       //bindgridview();
   }
   protected void Button1_Click(object sender, EventArgs e)
   {
       Response.Redirect("Default3.aspx");
   }
}
