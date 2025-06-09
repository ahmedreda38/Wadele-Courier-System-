using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Waddele_Main
{
    public partial class CUSTMOER_REPORT : Form
    {
        Customer_Orders_Details CR1;
        public CUSTMOER_REPORT()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR1 = new Customer_Orders_Details();

            foreach (ParameterDiscreteValue v in CR1.ParameterFields[0].DefaultValues)
            {
                comboBox_Name.Items.Add(v.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR1.SetParameterValue(0, comboBox_Name.Text);
            crystalReportViewer1.ReportSource = CR1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            COURIER_REPORT move_to_Form2 = Application.OpenForms["COURIER_REPORT"] as COURIER_REPORT;
            if (move_to_Form2 == null)
            {
                move_to_Form2 = new COURIER_REPORT();
                move_to_Form2.Show();
            }
            else
                move_to_Form2.BringToFront();
        }
    }
}
