namespace TicketsRevenueCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_CC = new System.Windows.Forms.NumericUpDown();
            this.tb_CB = new System.Windows.Forms.NumericUpDown();
            this.tb_CA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_CC_res = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_CB_res = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_CA_res = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_CC);
            this.groupBox1.Controls.Add(this.tb_CB);
            this.groupBox1.Controls.Add(this.tb_CA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(34, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(407, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // tb_CC
            // 
            this.tb_CC.Location = new System.Drawing.Point(175, 181);
            this.tb_CC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tb_CC.Name = "tb_CC";
            this.tb_CC.Size = new System.Drawing.Size(180, 31);
            this.tb_CC.TabIndex = 3;
            this.tb_CC.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
            // 
            // tb_CB
            // 
            this.tb_CB.Location = new System.Drawing.Point(175, 144);
            this.tb_CB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tb_CB.Name = "tb_CB";
            this.tb_CB.Size = new System.Drawing.Size(180, 31);
            this.tb_CB.TabIndex = 2;
            this.tb_CB.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
            // 
            // tb_CA
            // 
            this.tb_CA.Location = new System.Drawing.Point(175, 107);
            this.tb_CA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tb_CA.Name = "tb_CA";
            this.tb_CA.Size = new System.Drawing.Size(180, 31);
            this.tb_CA.TabIndex = 1;
            this.tb_CA.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.MaximumSize = new System.Drawing.Size(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class of seats";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_total);
            this.groupBox2.Controls.Add(this.tb_CC_res);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_CB_res);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_CA_res);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(528, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(407, 232);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class C:";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(181, 180);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(174, 31);
            this.tb_total.TabIndex = 3;
            this.tb_total.TabStop = false;
            // 
            // tb_CC_res
            // 
            this.tb_CC_res.Location = new System.Drawing.Point(181, 134);
            this.tb_CC_res.Name = "tb_CC_res";
            this.tb_CC_res.ReadOnly = true;
            this.tb_CC_res.Size = new System.Drawing.Size(174, 31);
            this.tb_CC_res.TabIndex = 3;
            this.tb_CC_res.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Class B:";
            // 
            // tb_CB_res
            // 
            this.tb_CB_res.Location = new System.Drawing.Point(181, 97);
            this.tb_CB_res.Name = "tb_CB_res";
            this.tb_CB_res.ReadOnly = true;
            this.tb_CB_res.Size = new System.Drawing.Size(174, 31);
            this.tb_CB_res.TabIndex = 2;
            this.tb_CB_res.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Class A:";
            // 
            // tb_CA_res
            // 
            this.tb_CA_res.Location = new System.Drawing.Point(181, 60);
            this.tb_CA_res.Name = "tb_CA_res";
            this.tb_CA_res.ReadOnly = true;
            this.tb_CA_res.Size = new System.Drawing.Size(174, 31);
            this.tb_CA_res.TabIndex = 0;
            this.tb_CA_res.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate Revenue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 72);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 72);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox tb_CC_res;
        private Label label6;
        private TextBox tb_CB_res;
        private Label label7;
        private TextBox tb_CA_res;
        private Label label8;
        private TextBox tb_total;
        private Button button1;
        private Button button2;
        private Button button3;
        private NumericUpDown tb_CC;
        private NumericUpDown tb_CB;
        private NumericUpDown tb_CA;
    }
}