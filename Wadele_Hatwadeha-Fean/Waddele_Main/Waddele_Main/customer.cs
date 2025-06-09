using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waddele_Main
{
    public partial class customer : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;


        public customer()
        {
            InitializeComponent();
        }

    

        private void cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select package_type, status, sender_location, receiver_location, delivery_time, payment_options from orders where ID = :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_ID.SelectedItem.ToString());
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                type.Text = reader[0].ToString();
                statue.Text = reader[1].ToString();
                senderl.Text = reader[2].ToString();
                recieverl.Text = reader[3].ToString();
                textBox1.Text = reader[4].ToString();
                comboBoxPayment.Text = reader[5].ToString();

            }
            reader.Close();

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();

                // Step 1: Get customer ID from name
                OracleCommand getIdCmd = new OracleCommand("SELECT id FROM Customers WHERE name = :name", conn);
                getIdCmd.Parameters.Add("name", OracleDbType.Varchar2).Value = customer_id.Text.Trim();

                object result = getIdCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Customer not found.");
                    return;
                }

                int customerId = Convert.ToInt32(result);

                // Step 2: Insert the order using retrieved customer ID
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO Orders 
            (status, package_type, customer_id, sender_location, receiver_location, delivery_time, payment_options) 
            VALUES 
            (:status, :package_type, :customer_id, :slocation, :rlocation, :delivery_time, :payment)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("status", OracleDbType.Varchar2).Value = "pending";
                cmd.Parameters.Add("package_type", OracleDbType.Varchar2).Value = type.Text.Trim();
                cmd.Parameters.Add("customer_id", OracleDbType.Int32).Value = customerId;
                cmd.Parameters.Add("slocation", OracleDbType.Varchar2).Value = senderl.Text.Trim();
                cmd.Parameters.Add("rlocation", OracleDbType.Varchar2).Value = recieverl.Text.Trim();
                cmd.Parameters.Add("delivery_time", OracleDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("payment", OracleDbType.Varchar2).Value = comboBoxPayment.Text.Trim();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order inserted successfully.");
                    cmb_ID.Items.Add(customerId.ToString()); // Optional
                }
                else
                {
                    MessageBox.Show("Insert failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand checkCmd = new OracleCommand();
                checkCmd.Connection = conn;
                checkCmd.CommandText = "SELECT name FROM Customers WHERE name = :name";
                checkCmd.Parameters.Add("name", OracleDbType.Varchar2).Value = customer_id.Text.Trim();

                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    label7.Text = "Welcome " + result.ToString() + " We are here to deliver anything";

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT o.id FROM Orders o JOIN Customers c ON o.customer_id = c.id WHERE c.name = :id";
                    cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = customer_id.Text.Trim();
                    cmd.CommandType = CommandType.Text;

                    OracleDataReader dr = cmd.ExecuteReader();
                    cmb_ID.Items.Clear(); 
                    while (dr.Read())
                    {
                        cmb_ID.Items.Add(dr[0]);
                    }
                    dr.Close();
                }
                else
                {
                    label7.Text = "Customer not found.";
                    cmb_ID.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void customer_Load(object sender, EventArgs e)
        {
            comboBoxPayment.Items.Add("Cash on Delivery");
            comboBoxPayment.Items.Add("Fawry");
            comboBoxPayment.Items.Add("Credit Card");
            comboBoxPayment.Items.Add("Vodafone Cash");
            comboBoxPayment.SelectedIndex = 0;
        }

    }
}
