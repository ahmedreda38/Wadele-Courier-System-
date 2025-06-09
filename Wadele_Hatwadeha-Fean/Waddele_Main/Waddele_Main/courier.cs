using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;


namespace Waddele_Main
{
    public partial class courier : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public courier()
        {
            InitializeComponent();
        }

        private void courier_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Get_Pending_Order_IDs";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pendingorderid.Items.Add(dr[0]);
            }
            conn.Dispose();
        }

        private void pendingorderid_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Get_Order_By_ID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", pendingorderid.SelectedItem.ToString());

            cmd.Parameters.Add("p_customer_id", OracleDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_status", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_sender_location", OracleDbType.Varchar2, 255).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_receiver_location", OracleDbType.Varchar2, 255).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_package_type", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_delivery_time", OracleDbType.Date).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_payment_options", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            from.Text = cmd.Parameters["p_sender_location"].Value?.ToString();
            customer_id.Text = cmd.Parameters["p_customer_id"].Value?.ToString();
            statue.Text = cmd.Parameters["p_status"].Value?.ToString();
            date.Text= cmd.Parameters["p_delivery_time"].Value?.ToString();
            to.Text = cmd.Parameters["p_receiver_location"].Value?.ToString();
            type.Text = cmd.Parameters["p_package_type"].Value?.ToString();

            // Handle nullable delivery_time
            /*            object deliveryDate = cmd.Parameters["p_delivery_time"].Value;
                        date.Text = deliveryDate != DBNull.Value ? Convert.ToDateTime(deliveryDate).ToString("yyyy-MM-dd HH:mm") : "";
            */
            payment.Text = cmd.Parameters["p_payment_options"].Value?.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            OracleCommand c = new OracleCommand();
                        c.Connection = conn;
                        c.CommandText = "update orders set courier_id =:courierid,status =:statue where ID=:id";
                        c.CommandType = CommandType.Text;

                        c.Parameters.Add("courier_id", courier_id.Text);
                        c.Parameters.Add("statue", statue.Text);
                        c.Parameters.Add("id", pendingorderid.SelectedItem.ToString());
                        int r = c.ExecuteNonQuery();*/

            /*            OracleCommand c = new OracleCommand();
             *            
             *            
                        c.Connection = conn;
                        c.CommandText = "UPDATE orders SET courier_id = :courierid, status = :statue WHERE id = :id";
                        c.CommandType = CommandType.Text;

                        // Match parameter names *exactly in order*
                        c.Parameters.Add("courierid", OracleDbType.Int32).Value = Convert.ToInt32(courier_id.Text);
                        c.Parameters.Add("statue", OracleDbType.Varchar2).Value = statue.Text;
                        c.Parameters.Add("id", OracleDbType.Int32).Value = Convert.ToInt32(pendingorderid.SelectedItem.ToString());

                        int r = c.ExecuteNonQuery();
                        MessageBox.Show(r > 0 ? "Order updated." : "No order found.");*/

            if (int.TryParse(courier_id.Text, out int courierId) &&
            int.TryParse(pendingorderid.SelectedItem?.ToString(), out int orderId))
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "UPDATE orders SET courier_id = :courierid, status = 'picked up' WHERE id = :id";
                c.CommandType = CommandType.Text;

                c.Parameters.Add("courierid", OracleDbType.Int32).Value = courierId;
                c.Parameters.Add("id", OracleDbType.Int32).Value = orderId;

                int r = c.ExecuteNonQuery();
                MessageBox.Show(r > 0 ? "Order updated." : "No order found.");
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Courier ID and Order ID.");
            }
        }

        
    }
}
