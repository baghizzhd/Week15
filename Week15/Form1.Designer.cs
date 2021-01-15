namespace Week15
{
    partial class Form1
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
            this.labelJUDUL = new System.Windows.Forms.Label();
            this.labelITEMS = new System.Windows.Forms.Label();
            this.listBoxITEM = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonMAKANAN = new System.Windows.Forms.RadioButton();
            this.radioButtonMINUMAN = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTOK = new System.Windows.Forms.Label();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonCHECKOUT = new System.Windows.Forms.Button();
            this.buttonBUY = new System.Windows.Forms.Button();
            this.labelHARGA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonminumannormal = new System.Windows.Forms.RadioButton();
            this.radioButtonminumanJumbo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelJUDUL
            // 
            this.labelJUDUL.AutoSize = true;
            this.labelJUDUL.Font = new System.Drawing.Font("Myriad Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJUDUL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelJUDUL.Location = new System.Drawing.Point(329, 9);
            this.labelJUDUL.Name = "labelJUDUL";
            this.labelJUDUL.Size = new System.Drawing.Size(111, 47);
            this.labelJUDUL.TabIndex = 0;
            this.labelJUDUL.Text = "BU DEWI";
            // 
            // labelITEMS
            // 
            this.labelITEMS.AutoSize = true;
            this.labelITEMS.Location = new System.Drawing.Point(223, 68);
            this.labelITEMS.Name = "labelITEMS";
            this.labelITEMS.Size = new System.Drawing.Size(58, 20);
            this.labelITEMS.TabIndex = 1;
            this.labelITEMS.Text = "ITEMS";
            // 
            // listBoxITEM
            // 
            this.listBoxITEM.FormattingEnabled = true;
            this.listBoxITEM.ItemHeight = 20;
            this.listBoxITEM.Location = new System.Drawing.Point(13, 91);
            this.listBoxITEM.Name = "listBoxITEM";
            this.listBoxITEM.Size = new System.Drawing.Size(268, 344);
            this.listBoxITEM.TabIndex = 2;
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.ItemHeight = 20;
            this.listBoxHarga.Location = new System.Drawing.Point(299, 91);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(129, 344);
            this.listBoxHarga.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "MENU";
            // 
            // radioButtonMAKANAN
            // 
            this.radioButtonMAKANAN.AutoSize = true;
            this.radioButtonMAKANAN.Location = new System.Drawing.Point(434, 98);
            this.radioButtonMAKANAN.Name = "radioButtonMAKANAN";
            this.radioButtonMAKANAN.Size = new System.Drawing.Size(100, 24);
            this.radioButtonMAKANAN.TabIndex = 5;
            this.radioButtonMAKANAN.TabStop = true;
            this.radioButtonMAKANAN.Text = "Makanan";
            this.radioButtonMAKANAN.UseVisualStyleBackColor = true;
            this.radioButtonMAKANAN.CheckedChanged += new System.EventHandler(this.radioButtonMAKANAN_CheckedChanged);
            // 
            // radioButtonMINUMAN
            // 
            this.radioButtonMINUMAN.AutoSize = true;
            this.radioButtonMINUMAN.Location = new System.Drawing.Point(554, 98);
            this.radioButtonMINUMAN.Name = "radioButtonMINUMAN";
            this.radioButtonMINUMAN.Size = new System.Drawing.Size(99, 24);
            this.radioButtonMINUMAN.TabIndex = 6;
            this.radioButtonMINUMAN.TabStop = true;
            this.radioButtonMINUMAN.Text = "Minuman";
            this.radioButtonMINUMAN.UseVisualStyleBackColor = true;
            this.radioButtonMINUMAN.CheckedChanged += new System.EventHandler(this.radioButtonMINUMAN_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(483, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTOK
            // 
            this.labelTOK.AutoSize = true;
            this.labelTOK.Location = new System.Drawing.Point(641, 150);
            this.labelTOK.Name = "labelTOK";
            this.labelTOK.Size = new System.Drawing.Size(61, 20);
            this.labelTOK.TabIndex = 8;
            this.labelTOK.Text = "Harga :";
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(253, 441);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(83, 32);
            this.buttonDELETE.TabIndex = 9;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonCHECKOUT
            // 
            this.buttonCHECKOUT.Location = new System.Drawing.Point(514, 431);
            this.buttonCHECKOUT.Name = "buttonCHECKOUT";
            this.buttonCHECKOUT.Size = new System.Drawing.Size(205, 42);
            this.buttonCHECKOUT.TabIndex = 10;
            this.buttonCHECKOUT.Text = "CHECKOUT";
            this.buttonCHECKOUT.UseVisualStyleBackColor = true;
            this.buttonCHECKOUT.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBUY
            // 
            this.buttonBUY.Location = new System.Drawing.Point(452, 361);
            this.buttonBUY.Name = "buttonBUY";
            this.buttonBUY.Size = new System.Drawing.Size(122, 42);
            this.buttonBUY.TabIndex = 11;
            this.buttonBUY.Text = "BUY";
            this.buttonBUY.UseVisualStyleBackColor = true;
            this.buttonBUY.Click += new System.EventHandler(this.buttonBUY_Click);
            // 
            // labelHARGA
            // 
            this.labelHARGA.AutoSize = true;
            this.labelHARGA.Location = new System.Drawing.Point(708, 150);
            this.labelHARGA.Name = "labelHARGA";
            this.labelHARGA.Size = new System.Drawing.Size(65, 20);
            this.labelHARGA.TabIndex = 12;
            this.labelHARGA.Text = "..............";
            this.labelHARGA.EnabledChanged += new System.EventHandler(this.radioButtonMAKANAN_CheckedChanged);
            this.labelHARGA.Click += new System.EventHandler(this.labelHARGA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Size";
            // 
            // radioButtonminumannormal
            // 
            this.radioButtonminumannormal.AutoSize = true;
            this.radioButtonminumannormal.Location = new System.Drawing.Point(447, 250);
            this.radioButtonminumannormal.Name = "radioButtonminumannormal";
            this.radioButtonminumannormal.Size = new System.Drawing.Size(84, 24);
            this.radioButtonminumannormal.TabIndex = 14;
            this.radioButtonminumannormal.TabStop = true;
            this.radioButtonminumannormal.Text = "Normal";
            this.radioButtonminumannormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonminumanJumbo
            // 
            this.radioButtonminumanJumbo.AutoSize = true;
            this.radioButtonminumanJumbo.Location = new System.Drawing.Point(553, 250);
            this.radioButtonminumanJumbo.Name = "radioButtonminumanJumbo";
            this.radioButtonminumanJumbo.Size = new System.Drawing.Size(82, 24);
            this.radioButtonminumanJumbo.TabIndex = 15;
            this.radioButtonminumanJumbo.TabStop = true;
            this.radioButtonminumanJumbo.Text = "Jumbo";
            this.radioButtonminumanJumbo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.radioButtonminumanJumbo);
            this.Controls.Add(this.radioButtonminumannormal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHARGA);
            this.Controls.Add(this.buttonBUY);
            this.Controls.Add(this.buttonCHECKOUT);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.labelTOK);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButtonMINUMAN);
            this.Controls.Add(this.radioButtonMAKANAN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxITEM);
            this.Controls.Add(this.labelITEMS);
            this.Controls.Add(this.labelJUDUL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJUDUL;
        private System.Windows.Forms.Label labelITEMS;
        private System.Windows.Forms.ListBox listBoxITEM;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonMAKANAN;
        private System.Windows.Forms.RadioButton radioButtonMINUMAN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelTOK;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonCHECKOUT;
        private System.Windows.Forms.Button buttonBUY;
        private System.Windows.Forms.Label labelHARGA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonminumannormal;
        private System.Windows.Forms.RadioButton radioButtonminumanJumbo;
    }
}

