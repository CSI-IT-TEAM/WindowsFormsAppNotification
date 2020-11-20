namespace WindowsFormsAppNotification
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
            this.tbxResponse = new System.Windows.Forms.TextBox();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessenge = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPlant = new System.Windows.Forms.ComboBox();
            this.txtPlant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxResponse
            // 
            this.tbxResponse.Location = new System.Drawing.Point(88, 198);
            this.tbxResponse.Name = "tbxResponse";
            this.tbxResponse.Size = new System.Drawing.Size(351, 20);
            this.tbxResponse.TabIndex = 0;
            this.tbxResponse.TextChanged += new System.EventHandler(this.tbxResponse_TextChanged);
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.Location = new System.Drawing.Point(159, 224);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(280, 36);
            this.btnSendNotification.TabIndex = 1;
            this.btnSendNotification.Text = "Send";
            this.btnSendNotification.UseVisualStyleBackColor = true;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(88, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(351, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Andon Thông Báo";
            this.txtTitle.TextChanged += new System.EventHandler(this.tbxResponse_TextChanged);
            // 
            // txtMessenge
            // 
            this.txtMessenge.Location = new System.Drawing.Point(88, 147);
            this.txtMessenge.Name = "txtMessenge";
            this.txtMessenge.Size = new System.Drawing.Size(351, 20);
            this.txtMessenge.TabIndex = 0;
            this.txtMessenge.Text = "PV:50 Min: 40, Max: 46 ";
            this.txtMessenge.TextChanged += new System.EventHandler(this.tbxResponse_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSound);
            this.groupBox1.Location = new System.Drawing.Point(21, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound";
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Checked = true;
            this.chkSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSound.Location = new System.Drawing.Point(67, 15);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(59, 17);
            this.chkSound.TabIndex = 0;
            this.chkSound.Text = "Enable";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Messenge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Response";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Image";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(88, 173);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(351, 20);
            this.txtImage.TabIndex = 4;
            this.txtImage.Text = "https://lh3.googleusercontent.com/proxy/9uy4zdRhLneBVodgNVbFSCCiO8O4sTNrJ6JcawfW_" +
    "6zNOZv3m_2mlnW8jP6POxTUlQjbONPmEAQ2V4kQQ6IF3nxpSABvgudHeGMXMLHeQ5k";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Plant";
            // 
            // cboPlant
            // 
            this.cboPlant.FormattingEnabled = true;
            this.cboPlant.Location = new System.Drawing.Point(88, 14);
            this.cboPlant.Name = "cboPlant";
            this.cboPlant.Size = new System.Drawing.Size(121, 21);
            this.cboPlant.TabIndex = 6;
            // 
            // txtPlant
            // 
            this.txtPlant.Location = new System.Drawing.Point(88, 68);
            this.txtPlant.Name = "txtPlant";
            this.txtPlant.Size = new System.Drawing.Size(351, 20);
            this.txtPlant.TabIndex = 0;
            this.txtPlant.Text = "Plant H-1";
            this.txtPlant.TextChanged += new System.EventHandler(this.tbxResponse_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Plant";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(88, 94);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(351, 20);
            this.txtArea.TabIndex = 0;
            this.txtArea.Text = "Assembly";
            this.txtArea.TextChanged += new System.EventHandler(this.tbxResponse_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Area";
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(88, 120);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(351, 20);
            this.txtMachine.TabIndex = 0;
            this.txtMachine.Text = "Backpart Molding";
            this.txtMachine.TextChanged += new System.EventHandler(this.tbxResponse_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Machine";
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(225, 15);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(78, 20);
            this.txtTopic.TabIndex = 7;
            this.txtTopic.Text = "014";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 280);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.cboPlant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.txtMessenge);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPlant);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.tbxResponse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxResponse;
        private System.Windows.Forms.Button btnSendNotification;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessenge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPlant;
        private System.Windows.Forms.TextBox txtPlant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTopic;
    }
}

