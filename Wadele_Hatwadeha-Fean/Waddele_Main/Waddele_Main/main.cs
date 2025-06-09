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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        //admin
        private void button1_Click(object sender, EventArgs e)
        {
            Admin Admin = new Admin();
            Admin.ShowDialog();
        }

        //customer
        private void button2_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            courier courier = new courier();   
            courier.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CUSTMOER_REPORT cstmr = new CUSTMOER_REPORT();
            cstmr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            COURIER_REPORT courr = new COURIER_REPORT();
            courr.ShowDialog();
        }
    }
}
