namespace LMS
{
    partial class Employee
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnedit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtpic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnedit);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(292, 146);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnedit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnedit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnedit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnedit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Image = global::LMS.Properties.Resources.edit_W;
            this.btnedit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnedit.Location = new System.Drawing.Point(231, 11);
            this.btnedit.Name = "btnedit";
            this.btnedit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnedit.Size = new System.Drawing.Size(50, 50);
            this.btnedit.TabIndex = 1;
            this.btnedit.TextOffset = new System.Drawing.Point(-1, 0);
            this.btnedit.UseTransparentBackground = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtpic
            // 
            this.txtpic.BackColor = System.Drawing.Color.Transparent;
            this.txtpic.Image = global::LMS.Properties.Resources.a_male2_propfile;
            this.txtpic.ImageRotate = 0F;
            this.txtpic.Location = new System.Drawing.Point(71, 69);
            this.txtpic.Name = "txtpic";
            this.txtpic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtpic.Size = new System.Drawing.Size(150, 150);
            this.txtpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtpic.TabIndex = 0;
            this.txtpic.TabStop = false;
            this.txtpic.UseTransparentBackground = true;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(16, 288);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(260, 25);
            this.txtemail.TabIndex = 1;
            this.txtemail.Text = "email";
            this.txtemail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJob
            // 
            this.txtJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJob.BackColor = System.Drawing.Color.Transparent;
            this.txtJob.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.ForeColor = System.Drawing.Color.Gray;
            this.txtJob.Location = new System.Drawing.Point(16, 260);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(260, 25);
            this.txtJob.TabIndex = 1;
            this.txtJob.Text = "job";
            this.txtJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.BackColor = System.Drawing.Color.Transparent;
            this.txtphone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.Gray;
            this.txtphone.Location = new System.Drawing.Point(16, 315);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(260, 25);
            this.txtphone.TabIndex = 1;
            this.txtphone.Text = "Contact";
            this.txtphone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(16, 235);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 25);
            this.txtName.TabIndex = 13;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtpic);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(292, 348);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnedit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtpic;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtJob;
        private System.Windows.Forms.Label txtphone;
        private System.Windows.Forms.Label txtName;
    }
}
