﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference2;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ProductServiceClient obj = new ProductServiceClient();
        string pid = TextBox1.Text;
        GridView1.DataSource = obj.GetAllProductsByID(pid);
        GridView1.DataBind();

    }
}