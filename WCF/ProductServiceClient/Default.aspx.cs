using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            ProductServiceClient obj = new ProductServiceClient();
            DropDownList1.DataSource = obj.GetAllProducts();
            DropDownList1.DataTextField = "pname";
            DropDownList1.DataBind();
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
}