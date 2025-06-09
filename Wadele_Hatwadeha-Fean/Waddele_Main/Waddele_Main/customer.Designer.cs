namespace Waddele_Main
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ID = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.TextBox();
            this.statue = new System.Windows.Forms.TextBox();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.Label();
            this.senderl = new System.Windows.Forms.TextBox();
            this.recieverl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackgroundImage = global::Waddele_Main.Properties.Resources.blue;
            this.btn_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Insert.Font = new System.Drawing.Font("Sakkal Majalla", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Insert.Location = new System.Drawing.Point(698, 445);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(234, 41);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Request Order delivery";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(68, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "All orders id\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(68, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Package_type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(68, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "statues";
            // 
            // cmb_ID
            // 
            this.cmb_ID.FormattingEnabled = true;
            this.cmb_ID.Location = new System.Drawing.Point(267, 243);
            this.cmb_ID.Name = "cmb_ID";
            this.cmb_ID.Size = new System.Drawing.Size(121, 21);
            this.cmb_ID.TabIndex = 6;
            this.cmb_ID.SelectedIndexChanged += new System.EventHandler(this.cmb_ID_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(267, 279);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 20);
            this.type.TabIndex = 7;
            // 
            // statue
            // 
            this.statue.Location = new System.Drawing.Point(267, 315);
            this.statue.Name = "statue";
            this.statue.Size = new System.Drawing.Size(121, 20);
            this.statue.TabIndex = 8;
            // 
            // customer_id
            // 
            this.customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.customer_id.Location = new System.Drawing.Point(394, 80);
            this.customer_id.Margin = new System.Windows.Forms.Padding(2);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(235, 38);
            this.customer_id.TabIndex = 9;
            // 
            // customerid
            // 
            this.customerid.AutoSize = true;
            this.customerid.BackColor = System.Drawing.Color.Transparent;
            this.customerid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerid.Font = new System.Drawing.Font("Sans Serif Collection", 10.25F, System.Drawing.FontStyle.Bold);
            this.customerid.ForeColor = System.Drawing.Color.DarkRed;
            this.customerid.Image = ((System.Drawing.Image)(resources.GetObject("customerid.Image")));
            this.customerid.Location = new System.Drawing.Point(123, 80);
            this.customerid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(213, 37);
            this.customerid.TabIndex = 11;
            this.customerid.Text = "Enter your Name:";
            // 
            // senderl
            // 
            this.senderl.Location = new System.Drawing.Point(267, 349);
            this.senderl.Margin = new System.Windows.Forms.Padding(2);
            this.senderl.Name = "senderl";
            this.senderl.Size = new System.Drawing.Size(121, 20);
            this.senderl.TabIndex = 12;
            // 
            // recieverl
            // 
            this.recieverl.Location = new System.Drawing.Point(267, 383);
            this.recieverl.Margin = new System.Windows.Forms.Padding(2);
            this.recieverl.Name = "recieverl";
            this.recieverl.Size = new System.Drawing.Size(121, 20);
            this.recieverl.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(68, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "reciever location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(68, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "your lacation";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Waddele_Main.Properties.Resources.blue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Sakkal Majalla", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(698, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "show your Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 417);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 416);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(68, 417);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Delivering date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 21.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(210, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 39);
            this.label7.TabIndex = 26;
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Location = new System.Drawing.Point(267, 465);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(123, 21);
            this.comboBoxPayment.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(68, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Select Payment Option";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(715, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 29;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Waddele_Main.Properties.Resources.red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recieverl);
            this.Controls.Add(this.senderl);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.statue);
            this.Controls.Add(this.type);
            this.Controls.Add(this.cmb_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Insert);
            this.DoubleBuffered = true;
            this.Name = "customer";
            this.Text = "Waddele - customer";
            this.Load += new System.EventHandler(this.customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ID;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox statue;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.Label customerid;
        private System.Windows.Forms.TextBox senderl;
        private System.Windows.Forms.TextBox recieverl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}