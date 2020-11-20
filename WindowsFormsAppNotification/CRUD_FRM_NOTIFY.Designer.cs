namespace WindowsFormsAppNotification
{
    partial class CRUD_FRM_NOTIFY
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnZalo = new System.Windows.Forms.Button();
            this.btnSlack = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnZalo);
            this.groupBox1.Controls.Add(this.btnSlack);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Controls.Add(this.lblResponse);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notifications";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnZalo
            // 
            this.btnZalo.Location = new System.Drawing.Point(458, 11);
            this.btnZalo.Name = "btnZalo";
            this.btnZalo.Size = new System.Drawing.Size(75, 44);
            this.btnZalo.TabIndex = 1;
            this.btnZalo.Text = "Zalo Post";
            this.btnZalo.UseVisualStyleBackColor = true;
            this.btnZalo.Click += new System.EventHandler(this.btnZalo_Click);
            // 
            // btnSlack
            // 
            this.btnSlack.Location = new System.Drawing.Point(539, 11);
            this.btnSlack.Name = "btnSlack";
            this.btnSlack.Size = new System.Drawing.Size(75, 44);
            this.btnSlack.TabIndex = 1;
            this.btnSlack.Text = "Slack Post";
            this.btnSlack.UseVisualStyleBackColor = true;
            this.btnSlack.Click += new System.EventHandler(this.btnSlack_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(620, 11);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 44);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get Data";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(154, 42);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(34, 13);
            this.lblResponse.TabIndex = 0;
            this.lblResponse.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(154, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 281);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Today";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(689, 256);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.Color.Blue;
            this.lblTimer.Location = new System.Drawing.Point(15, 363);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(141, 13);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "How Many Time Countdown";
            // 
            // CRUD_FRM_NOTIFY
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(725, 402);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CRUD_FRM_NOTIFY";
            this.Text = "CRUD_FRM_NOTIFY";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnSlack;
        private System.Windows.Forms.Button btnZalo;
    }
}