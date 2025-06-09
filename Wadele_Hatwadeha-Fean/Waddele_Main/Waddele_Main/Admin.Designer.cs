namespace Waddele_Main
{
    partial class Admin
    {
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
            this.radio_customers = new System.Windows.Forms.RadioButton();
            this.radio_couriers = new System.Windows.Forms.RadioButton();
            this.radio_orders = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save_edits_button = new System.Windows.Forms.Button();
            this.Loading_button = new System.Windows.Forms.Button();
            this.Company_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radio_customers
            // 
            this.radio_customers.AutoSize = true;
            this.radio_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.radio_customers.ForeColor = System.Drawing.Color.Gainsboro;
            this.radio_customers.Location = new System.Drawing.Point(39, 148);
            this.radio_customers.Name = "radio_customers";
            this.radio_customers.Size = new System.Drawing.Size(150, 26);
            this.radio_customers.TabIndex = 0;
            this.radio_customers.TabStop = true;
            this.radio_customers.Text = "Edit Customers";
            this.radio_customers.UseVisualStyleBackColor = true;
            // 
            // radio_couriers
            // 
            this.radio_couriers.AutoSize = true;
            this.radio_couriers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.radio_couriers.ForeColor = System.Drawing.Color.Gainsboro;
            this.radio_couriers.Location = new System.Drawing.Point(340, 148);
            this.radio_couriers.Name = "radio_couriers";
            this.radio_couriers.Size = new System.Drawing.Size(132, 26);
            this.radio_couriers.TabIndex = 1;
            this.radio_couriers.TabStop = true;
            this.radio_couriers.Text = "Edit Couriers";
            this.radio_couriers.UseVisualStyleBackColor = true;
            // 
            // radio_orders
            // 
            this.radio_orders.AutoSize = true;
            this.radio_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.radio_orders.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radio_orders.Location = new System.Drawing.Point(637, 148);
            this.radio_orders.Name = "radio_orders";
            this.radio_orders.Size = new System.Drawing.Size(119, 26);
            this.radio_orders.TabIndex = 2;
            this.radio_orders.TabStop = true;
            this.radio_orders.Text = "Edit Orders";
            this.radio_orders.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 493);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 30.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(215, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome Administrator!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Papyrus", 16.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin Panel :";
            // 
            // Save_edits_button
            // 
            this.Save_edits_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.Save_edits_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_edits_button.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_edits_button.ForeColor = System.Drawing.Color.White;
            this.Save_edits_button.Image = global::Waddele_Main.Properties.Resources.red;
            this.Save_edits_button.Location = new System.Drawing.Point(779, 443);
            this.Save_edits_button.Name = "Save_edits_button";
            this.Save_edits_button.Size = new System.Drawing.Size(193, 65);
            this.Save_edits_button.TabIndex = 6;
            this.Save_edits_button.Text = "Save edits";
            this.Save_edits_button.UseVisualStyleBackColor = false;
            this.Save_edits_button.Click += new System.EventHandler(this.Save_edits_button_Click);
            // 
            // Loading_button
            // 
            this.Loading_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.Loading_button.BackgroundImage = global::Waddele_Main.Properties.Resources.red;
            this.Loading_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loading_button.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading_button.ForeColor = System.Drawing.Color.White;
            this.Loading_button.Location = new System.Drawing.Point(779, 342);
            this.Loading_button.Name = "Loading_button";
            this.Loading_button.Size = new System.Drawing.Size(193, 65);
            this.Loading_button.TabIndex = 7;
            this.Loading_button.Text = "Load Information";
            this.Loading_button.UseVisualStyleBackColor = false;
            this.Loading_button.Click += new System.EventHandler(this.Loading_button_Click);
            // 
            // Company_name
            // 
            this.Company_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.Company_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Company_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Company_name.Font = new System.Drawing.Font("Arabic Typesetting", 50F, System.Drawing.FontStyle.Bold);
            this.Company_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Company_name.Image = global::Waddele_Main.Properties.Resources.red;
            this.Company_name.Location = new System.Drawing.Point(779, 9);
            this.Company_name.Name = "Company_name";
            this.Company_name.Padding = new System.Windows.Forms.Padding(15);
            this.Company_name.Size = new System.Drawing.Size(193, 121);
            this.Company_name.TabIndex = 8;
            this.Company_name.Text = "ودّيلي";
            this.Company_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 16.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(33, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose a Table to Load ->";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Company_name);
            this.Controls.Add(this.Loading_button);
            this.Controls.Add(this.Save_edits_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radio_orders);
            this.Controls.Add(this.radio_couriers);
            this.Controls.Add(this.radio_customers);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.RadioButton radio_customers;
        private System.Windows.Forms.RadioButton radio_couriers;
        private System.Windows.Forms.RadioButton radio_orders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save_edits_button;
        private System.Windows.Forms.Button Loading_button;
        private System.Windows.Forms.Label Company_name;
        private System.Windows.Forms.Label label4;

        #endregion
    }
}