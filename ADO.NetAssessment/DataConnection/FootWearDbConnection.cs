using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineFootWearStore.DataConnection
{
    public class FootWearDbConnection
    {
        string sqlConnectionstr = "Data Source=100.72.130.5;Initial Catalog=Training;Persist Security Info=True;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";

        public DataTable SelectModel(FootwearModel footwearModel)
        {
            SqlConnection obj = new SqlConnection(sqlConnectionstr);
            SqlDataAdapter sqlobj = new SqlDataAdapter($"select Product_Code,Product_Name,Cost from XYZStore where Category = '{footwearModel.Category}'", obj);
            DataTable dt = new DataTable();
            sqlobj.Fill(dt);
            return dt;
        }

        public OrderFootwear FilterData(FootwearModel footwearModel)
        {
            OrderFootwear Order = new OrderFootwear();
            SqlConnection obj = new SqlConnection(sqlConnectionstr);
            SqlDataAdapter sqlobj = new SqlDataAdapter($"select * from XYZStore where Product_Code = {footwearModel.Product_Code} ", obj);
            DataTable dt = new DataTable();
            sqlobj.Fill(dt);
            Order.ProductCode= Convert.ToInt32(dt.Rows[0][0]);
            Order.ProductName = dt.Rows[0][1].ToString();
            Order.Cost = Convert.ToInt32(dt.Rows[0][2]);
            return Order;
        }
        public string Payment(OrderFootwear orderFootwear)
        {
            SqlConnection obj = new SqlConnection(sqlConnectionstr);
            obj.Open();
            SqlCommand cmd = new SqlCommand($"insert into FootWearStore values({orderFootwear.ProductCode},'{orderFootwear.ProductName}',{orderFootwear.Cost},{orderFootwear.Quantity},{orderFootwear.TotalAmount})", obj); ;
            cmd.ExecuteNonQuery();
            obj.Close();
            return "Saved Succesfully";
        }
        public DataTable Status()
        {
            SqlConnection con = new SqlConnection(sqlConnectionstr);
            SqlDataAdapter da = new SqlDataAdapter("select * from FootWearStore", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}