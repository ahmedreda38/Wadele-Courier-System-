using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Waddele_Main
{
    public partial class Admin : Form
    {
        
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Admin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Loading_button_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string cmdstr = "";

            if (radio_couriers.Checked)
            {
                cmdstr = "select * from Couriers";
            }
            else if (radio_orders.Checked)
            {
                cmdstr = "select * from Orders";
            }
            else if (radio_customers.Checked)
            {
                cmdstr = "select * from Customers";
            }

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Save_edits_button_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

    }
}
