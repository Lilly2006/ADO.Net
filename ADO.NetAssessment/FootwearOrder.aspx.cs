using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineFootWearStore.DataConnection;

namespace OnlineFootWearStore
{
    public partial class FootwearOrder : System.Web.UI.Page
    {
        FootwearModel obj1 = new FootwearModel();
        FootWearDbConnection obj = new FootWearDbConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            FootWearDbConnection obj = new FootWearDbConnection();
           
            if (!IsPostBack)
            {
                lblProductcode.Text = "" + Session["value"];
                obj1.Product_Code = Convert.ToInt32(Session["value"]);
                OrderFootwear Order = obj.FilterData(obj1);

                lblProductname.Text = Order.ProductName;
                lblcost.Text = Order.Cost.ToString();
            }

        }

       

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            OrderFootwear order = new OrderFootwear();
            order.ProductCode = Convert.ToInt32(lblProductcode.Text);
            order.ProductName = lblProductname.Text;
            order.Cost = Convert.ToInt32(lblcost.Text);
            order.Quantity = Convert.ToInt32(txtQuantity.Text);
            order.TotalAmount = Convert.ToInt32(lblTotal_Amount.Text);
            string msg = obj.Payment(order);
            Response.Write($"<script>alert('{msg}')</script>");
        }

        protected void btnCost_Click(object sender, EventArgs e)
        {

            obj1.Product_Code = Convert.ToInt32(Session["value"]);

            OrderFootwear order = obj.FilterData(obj1);
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            lblTotal_Amount.Text = Convert.ToString(order.Cost * Quantity);
        }
    }
}