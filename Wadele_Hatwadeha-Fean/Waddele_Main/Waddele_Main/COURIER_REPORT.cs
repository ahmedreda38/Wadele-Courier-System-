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
    public partial class COURIER_REPORT : Form
    {
        couriers_data cr2;
        public COURIER_REPORT()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cr2 = new couriers_data();
            foreach (ParameterDiscreteValue v in cr2.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr2.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUSTMOER_REPORT move_to_Form1 = Application.OpenForms["CUSTMOER_REPORT"] as CUSTMOER_REPORT;
            if (move_to_Form1 == null)
            {
                move_to_Form1 = new CUSTMOER_REPORT();
                move_to_Form1.Show();
            }
            else
                move_to_Form1.BringToFront();
        }
    }
}
