namespace Week15
{
    partial class Form2
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
            this.checkBoxdiscount = new System.Windows.Forms.CheckBox();
            this.buttoncalculate = new System.Windows.Forms.Button();
            this.labelsubtotal = new System.Windows.Forms.Label();
            this.labeltax = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxdiscount
            // 
            this.checkBoxdiscount.AutoSize = true;
            this.checkBoxdiscount.Location = new System.Drawing.Point(40, 44);
            this.checkBoxdiscount.Name = "checkBoxdiscount";
            this.checkBoxdiscount.Size = new System.Drawing.Size(98, 24);
            this.checkBoxdiscount.TabIndex = 0;
            this.checkBoxdiscount.Text = "Discount";
            this.checkBoxdiscount.UseVisualStyleBackColor = true;
            // 
            // buttoncalculate
            // 
            this.buttoncalculate.Location = new System.Drawing.Point(40, 144);
            this.buttoncalculate.Name = "buttoncalculate";
            this.buttoncalculate.Size = new System.Drawing.Size(111, 40);
            this.buttoncalculate.TabIndex = 1;
            this.buttoncalculate.Text = "CALCULATE";
            this.buttoncalculate.UseVisualStyleBackColor = true;
            // 
            // labelsubtotal
            // 
            this.labelsubtotal.AutoSize = true;
            this.labelsubtotal.Location = new System.Drawing.Point(260, 44);
            this.labelsubtotal.Name = "labelsubtotal";
            this.labelsubtotal.Size = new System.Drawing.Size(69, 20);
            this.labelsubtotal.TabIndex = 2;
            this.labelsubtotal.Text = "Subtotal";
            // 
            // labeltax
            // 
            this.labeltax.AutoSize = true;
            this.labeltax.Location = new System.Drawing.Point(260, 73);
            this.labeltax.Name = "labeltax";
            this.labeltax.Size = new System.Drawing.Size(34, 20);
            this.labeltax.TabIndex = 3;
            this.labeltax.Text = "Tax";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(260, 99);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(72, 20);
            this.labelDiscount.TabIndex = 4;
            this.labelDiscount.Text = "Discount";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(260, 153);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(44, 20);
            this.LabelTotal.TabIndex = 5;
            this.LabelTotal.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = ".....";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "......";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = ".....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = ".....";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labeltax);
            this.Controls.Add(this.labelsubtotal);
            this.Controls.Add(this.buttoncalculate);
            this.Controls.Add(this.checkBoxdiscount);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxdiscount;
        private System.Windows.Forms.Button buttoncalculate;
        private System.Windows.Forms.Label labelsubtotal;
        private System.Windows.Forms.Label labeltax;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}