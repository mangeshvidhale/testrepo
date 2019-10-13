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
using System.Collections.Generic;

public partial class Default7 : System.Web.UI.Page
{
    String pid1;
    String S;
    String Connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        pid1 = Request.QueryString["id"];

        if (!IsPostBack)
        {
            Class4 cs4 = new Class4();
            GridView1.DataSource = cs4.bindgridview();
            GridView1.DataBind();
           
        }
    }

  


    protected void Purchase_Click(object sender, EventArgs e)
    {
       String str = "";
      if (Session["un"] == "")
      {
            Response.Redirect("main.aspx");
      }
      
       foreach (GridViewRow row1 in GridView1.Rows)
        {
           CheckBox checkbox = (CheckBox)row1.FindControl("cb1");
           
              if (checkbox.Checked)
               {

                   String Q1 = "insert into dummy values('" + Session["un"] + "'," + row1.Cells[1].Text + ",'" + row1.Cells[2].Text + "'," + row1.Cells[3].Text + "," +1+")";
                String Connstr1 =ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();
                SqlConnection con1 = new SqlConnection(Connstr1);
                con1.Open();
                  
                SqlCommand cmd1 = new SqlCommand(Q1,con1);
                cmd1.ExecuteNonQuery();
                Label1.Text = "record inserted";
                Response.Redirect("Default2.aspx");
              }
        }
           
        }
    }


