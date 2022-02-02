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
    public partial class StatusOfFootwear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FootWearDbConnection con = new FootWearDbConnection();

            DataTable dt = new DataTable();

            dt = con.Status();

            GVStatus.DataSource = dt;

            GVStatus.DataBind();
        }

       
    }
}