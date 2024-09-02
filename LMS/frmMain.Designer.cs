namespace LMS
{
    partial class frmMain
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDep = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnType = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnRequest = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).BeginInit();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btnDep);
            this.guna2Panel1.Controls.Add(this.btnType);
            this.guna2Panel1.Controls.Add(this.btnRequest);
            this.guna2Panel1.Controls.Add(this.btnEmployee);
            this.guna2Panel1.Controls.Add(this.btnDashboard);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(86, 450);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnDep
            // 
            this.btnDep.BorderRadius = 10;
            this.btnDep.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDep.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.btnDep.CheckedState.Image = global::LMS.Properties.Resources.department_W;
            this.btnDep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDep.FillColor = System.Drawing.Color.White;
            this.btnDep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDep.ForeColor = System.Drawing.Color.White;
            this.btnDep.Image = global::LMS.Properties.Resources.department;
            this.btnDep.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDep.Location = new System.Drawing.Point(15, 371);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(50, 50);
            this.btnDep.TabIndex = 1;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnType
            // 
            this.btnType.BorderRadius = 10;
            this.btnType.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnType.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.btnType.CheckedState.Image = global::LMS.Properties.Resources.categories_W;
            this.btnType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnType.FillColor = System.Drawing.Color.White;
            this.btnType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnType.ForeColor = System.Drawing.Color.White;
            this.btnType.Image = global::LMS.Properties.Resources.categories;
            this.btnType.ImageSize = new System.Drawing.Size(30, 30);
            this.btnType.Location = new System.Drawing.Point(15, 315);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(50, 50);
            this.btnType.TabIndex = 1;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.BorderRadius = 10;
            this.btnRequest.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRequest.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.btnRequest.CheckedState.Image = global::LMS.Properties.Resources.req_W;
            this.btnRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRequest.FillColor = System.Drawing.Color.White;
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Image = global::LMS.Properties.Resources.req;
            this.btnRequest.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRequest.Location = new System.Drawing.Point(15, 203);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(50, 50);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 10;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.btnEmployee.CheckedState.Image = global::LMS.Properties.Resources.employees_W;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.White;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::LMS.Properties.Resources.employees;
            this.btnEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployee.Location = new System.Drawing.Point(15, 259);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(50, 50);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.btnDashboard.CheckedState.Image = global::LMS.Properties.Resources.dashboard_W;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.White;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::LMS.Properties.Resources.dashboard;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(15, 147);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(50, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LMS";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Controls.Add(this.lblJob);
            this.guna2Panel2.Controls.Add(this.lblUser);
            this.guna2Panel2.Controls.Add(this.txtPic);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.btnMax);
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(86, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(714, 147);
            this.guna2Panel2.TabIndex = 0;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblJob.Location = new System.Drawing.Point(113, 71);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(67, 21);
            this.lblJob.TabIndex = 2;
            this.lblJob.Text = "Job Title";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUser.Location = new System.Drawing.Point(113, 50);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            // 
            // txtPic
            // 
            this.txtPic.Image = global::LMS.Properties.Resources.user_male_skin_type_5_96;
            this.txtPic.ImageRotate = 0F;
            this.txtPic.Location = new System.Drawing.Point(6, 29);
            this.txtPic.Name = "txtPic";
            this.txtPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtPic.Size = new System.Drawing.Size(100, 100);
            this.txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtPic.TabIndex = 1;
            this.txtPic.TabStop = false;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.LightGray;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(555, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.FillColor = System.Drawing.Color.LightGray;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(606, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(45, 29);
            this.btnMax.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CustomClick = true;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(657, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.label2);
            this.CenterPanel.Controls.Add(this.guna2PictureBox1);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(86, 147);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(714, 303);
            this.CenterPanel.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(111, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leave Management System";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.Image = global::LMS.Properties.Resources.Leave_Management_System_Dashboard2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(215, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(285, 257);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private Guna.UI2.WinForms.Guna2TileButton btnDashboard;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton btnEmployee;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2TileButton btnDep;
        private Guna.UI2.WinForms.Guna2TileButton btnType;
        private Guna.UI2.WinForms.Guna2TileButton btnRequest;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtPic;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}