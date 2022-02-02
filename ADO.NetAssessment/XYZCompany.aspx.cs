using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineFootWearStore.DataConnection;

namespace OnlineFootWearStore
{
    public partial class XYZCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div_property.Visible = false;
        }

        protected void btnselect_Click(object sender, EventArgs e)
        {
            FootWearDbConnection obj = new FootWearDbConnection();
            FootwearModel footwearModelObj = new FootwearModel();         
            footwearModelObj.Category = DropDownList1.SelectedValue;
            DataTable dt = new DataTable();
            dt = obj.SelectModel(footwearModelObj);
            gvDisplay.DataSource = dt;
            gvDisplay.DataBind();
            div_property.Visible = true;
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Session["value"] = txtProductCode.Text;
            Response.Redirect("FootwearOrder.aspx");
        }

        protected void btnStatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("StatusOfFootwear.aspx");
        }
    }
}