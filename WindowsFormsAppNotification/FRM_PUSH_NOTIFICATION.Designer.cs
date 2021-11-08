namespace WindowsFormsAppNotification
{
    partial class FRM_PUSH_NOTIFICATION
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReloadCombo = new System.Windows.Forms.Button();
            this.cboMail = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdOnce = new System.Windows.Forms.RadioButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTopics = new System.Windows.Forms.TextBox();
            this.btnGetDocument = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReloadCombo);
            this.groupBox1.Controls.Add(this.cboMail);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Controls.Add(this.lblResponse);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notifications";
            // 
            // btnReloadCombo
            // 
            this.btnReloadCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadCombo.Location = new System.Drawing.Point(529, 12);
            this.btnReloadCombo.Name = "btnReloadCombo";
            this.btnReloadCombo.Size = new System.Drawing.Size(19, 19);
            this.btnReloadCombo.TabIndex = 7;
            this.btnReloadCombo.Text = "R";
            this.btnReloadCombo.UseVisualStyleBackColor = true;
            this.btnReloadCombo.Click += new System.EventHandler(this.btnReloadCombo_Click);
            // 
            // cboMail
            // 
            this.cboMail.FormattingEnabled = true;
            this.cboMail.Location = new System.Drawing.Point(256, 11);
            this.cboMail.Name = "cboMail";
            this.cboMail.Size = new System.Drawing.Size(271, 21);
            this.cboMail.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdAll);
            this.groupBox3.Controls.Add(this.rdOnce);
            this.groupBox3.Location = new System.Drawing.Point(327, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 31);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Options";
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(173, 9);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(36, 17);
            this.rdAll.TabIndex = 0;
            this.rdAll.Text = "All";
            this.rdAll.UseVisualStyleBackColor = true;
            // 
            // rdOnce
            // 
            this.rdOnce.AutoSize = true;
            this.rdOnce.Checked = true;
            this.rdOnce.Location = new System.Drawing.Point(72, 9);
            this.rdOnce.Name = "rdOnce";
            this.rdOnce.Size = new System.Drawing.Size(89, 17);
            this.rdOnce.TabIndex = 0;
            this.rdOnce.TabStop = true;
            this.rdOnce.Text = "From Textbox";
            this.rdOnce.UseVisualStyleBackColor = true;
            this.rdOnce.CheckedChanged += new System.EventHandler(this.rdOnce_CheckedChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.Color.Blue;
            this.lblTimer.Location = new System.Drawing.Point(77, 1);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(141, 13);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "How Many Time Countdown";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(389, 74);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 24);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Push Once";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail";
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.Location = new System.Drawing.Point(470, 74);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 24);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get Data";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.Location = new System.Drawing.Point(6, 38);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(315, 60);
            this.lblResponse.TabIndex = 0;
            this.lblResponse.Text = "Response Messenge Code";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Notify Already Send";
            // 
            // txtTopics
            // 
            this.txtTopics.Location = new System.Drawing.Point(324, -2);
            this.txtTopics.Name = "txtTopics";
            this.txtTopics.Size = new System.Drawing.Size(176, 20);
            this.txtTopics.TabIndex = 4;
            this.txtTopics.Text = "phuoc.it@changshininc.com";
            this.txtTopics.Visible = false;
            // 
            // btnGetDocument
            // 
            this.btnGetDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetDocument.Location = new System.Drawing.Point(374, 141);
            this.btnGetDocument.Name = "btnGetDocument";
            this.btnGetDocument.Size = new System.Drawing.Size(100, 0);
            this.btnGetDocument.TabIndex = 3;
            this.btnGetDocument.Text = "Get Document";
            this.btnGetDocument.UseVisualStyleBackColor = true;
            this.btnGetDocument.Click += new System.EventHandler(this.btnGetDocument_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 112);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notify Queue";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(689, 79);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // FRM_PUSH_NOTIFICATION
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(577, 122);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTopics);
            this.Controls.Add(this.btnGetDocument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRM_PUSH_NOTIFICATION";
            this.Load += new System.EventHandler(this.CRUD_FRM_NOTIFY_NEW_VER_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnGetDocument;
        private System.Windows.Forms.TextBox txtTopics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdOnce;
        private System.Windows.Forms.ComboBox cboMail;
        private System.Windows.Forms.Button btnReloadCombo;
    }
}