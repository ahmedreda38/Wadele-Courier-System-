namespace Waddele_Main
{
    partial class courier
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pendingorderid = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.TextBox();
            this.statue = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.courier_id = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.TextBox();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pendingorderid
            // 
            this.pendingorderid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pendingorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.pendingorderid.FormattingEnabled = true;
            this.pendingorderid.Location = new System.Drawing.Point(758, 88);
            this.pendingorderid.Margin = new System.Windows.Forms.Padding(2);
            this.pendingorderid.Name = "pendingorderid";
            this.pendingorderid.Size = new System.Drawing.Size(195, 32);
            this.pendingorderid.TabIndex = 0;
            this.pendingorderid.SelectedIndexChanged += new System.EventHandler(this.pendingorderid_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(387, 422);
            this.type.Margin = new System.Windows.Forms.Padding(2);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(76, 20);
            this.type.TabIndex = 1;
            // 
            // statue
            // 
            this.statue.Location = new System.Drawing.Point(387, 379);
            this.statue.Margin = new System.Windows.Forms.Padding(2);
            this.statue.Name = "statue";
            this.statue.Size = new System.Drawing.Size(76, 20);
            this.statue.TabIndex = 2;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(387, 327);
            this.to.Margin = new System.Windows.Forms.Padding(2);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(76, 20);
            this.to.TabIndex = 3;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(387, 282);
            this.from.Margin = new System.Windows.Forms.Padding(2);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(76, 20);
            this.from.TabIndex = 4;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(676, 282);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(76, 20);
            this.date.TabIndex = 5;
            // 
            // courier_id
            // 
            this.courier_id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.courier_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courier_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.courier_id.Location = new System.Drawing.Point(215, 90);
            this.courier_id.Margin = new System.Windows.Forms.Padding(2);
            this.courier_id.Name = "courier_id";
            this.courier_id.Size = new System.Drawing.Size(148, 29);
            this.courier_id.TabIndex = 6;
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(676, 327);
            this.payment.Margin = new System.Windows.Forms.Padding(2);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(76, 20);
            this.payment.TabIndex = 7;
            // 
            // customer_id
            // 
            this.customer_id.Location = new System.Drawing.Point(676, 379);
            this.customer_id.Margin = new System.Windows.Forms.Padding(2);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(76, 20);
            this.customer_id.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Waddele_Main.Properties.Resources.red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 25.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(437, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Accept Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Show pending orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pick-up location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "reciever location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 413);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(524, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delivery Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "payment method";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Enter your ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(524, 370);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "customer id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(409, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 64);
            this.label10.TabIndex = 19;
            this.label10.Text = "Order Details";
            // 
            // courier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Waddele_Main.Properties.Resources.white;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 605);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.courier_id);
            this.Controls.Add(this.date);
            this.Controls.Add(this.from);
            this.Controls.Add(this.to);
            this.Controls.Add(this.statue);
            this.Controls.Add(this.type);
            this.Controls.Add(this.pendingorderid);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "courier";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.courier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pendingorderid;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox statue;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox courier_id;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}