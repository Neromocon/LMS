namespace LMS
{
    partial class Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtpic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtname = new System.Windows.Forms.Label();
            this.btnapprove = new Guna.UI2.WinForms.Guna2Button();
            this.btnreject = new Guna.UI2.WinForms.Guna2Button();
            this.txtjob = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtedate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdays = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtpic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(252, 102);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // txtpic
            // 
            this.txtpic.BackColor = System.Drawing.Color.Transparent;
            this.txtpic.Image = ((System.Drawing.Image)(resources.GetObject("txtpic.Image")));
            this.txtpic.ImageRotate = 0F;
            this.txtpic.Location = new System.Drawing.Point(79, 50);
            this.txtpic.Name = "txtpic";
            this.txtpic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtpic.Size = new System.Drawing.Size(100, 100);
            this.txtpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtpic.TabIndex = 2;
            this.txtpic.TabStop = false;
            this.txtpic.UseTransparentBackground = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(3, 145);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 24);
            this.txtname.TabIndex = 3;
            this.txtname.Text = "username";
            this.txtname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnapprove
            // 
            this.btnapprove.AutoRoundedCorners = true;
            this.btnapprove.BorderRadius = 19;
            this.btnapprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnapprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnapprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnapprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnapprove.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnapprove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnapprove.ForeColor = System.Drawing.Color.White;
            this.btnapprove.Location = new System.Drawing.Point(21, 407);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(97, 40);
            this.btnapprove.TabIndex = 4;
            this.btnapprove.Text = "Approve";
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // btnreject
            // 
            this.btnreject.AutoRoundedCorners = true;
            this.btnreject.BorderRadius = 19;
            this.btnreject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreject.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnreject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnreject.ForeColor = System.Drawing.Color.White;
            this.btnreject.Location = new System.Drawing.Point(135, 407);
            this.btnreject.Name = "btnreject";
            this.btnreject.Size = new System.Drawing.Size(97, 40);
            this.btnreject.TabIndex = 4;
            this.btnreject.Text = "Reject";
            this.btnreject.Click += new System.EventHandler(this.btnreject_Click);
            // 
            // txtjob
            // 
            this.txtjob.ForeColor = System.Drawing.Color.Gray;
            this.txtjob.Location = new System.Drawing.Point(3, 171);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(252, 24);
            this.txtjob.TabIndex = 3;
            this.txtjob.Text = "Job";
            this.txtjob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Request Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsdate
            // 
            this.txtsdate.AutoSize = true;
            this.txtsdate.ForeColor = System.Drawing.Color.Gray;
            this.txtsdate.Location = new System.Drawing.Point(17, 257);
            this.txtsdate.Name = "txtsdate";
            this.txtsdate.Size = new System.Drawing.Size(85, 20);
            this.txtsdate.TabIndex = 5;
            this.txtsdate.Text = "25-04-2024";
            this.txtsdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Start Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtedate
            // 
            this.txtedate.AutoSize = true;
            this.txtedate.ForeColor = System.Drawing.Color.Gray;
            this.txtedate.Location = new System.Drawing.Point(147, 257);
            this.txtedate.Name = "txtedate";
            this.txtedate.Size = new System.Drawing.Size(85, 20);
            this.txtedate.TabIndex = 5;
            this.txtedate.Text = "25-04-2024";
            this.txtedate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Number of Days";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdays
            // 
            this.txtdays.AutoSize = true;
            this.txtdays.ForeColor = System.Drawing.Color.Gray;
            this.txtdays.Location = new System.Drawing.Point(17, 320);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(17, 20);
            this.txtdays.TabIndex = 5;
            this.txtdays.Text = "2";
            this.txtdays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Leave Type";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttype
            // 
            this.txttype.AutoSize = true;
            this.txttype.ForeColor = System.Drawing.Color.Gray;
            this.txttype.Location = new System.Drawing.Point(17, 372);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(35, 20);
            this.txttype.TabIndex = 5;
            this.txttype.Text = "Sick";
            this.txttype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txtedate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnreject);
            this.Controls.Add(this.btnapprove);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpic);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Request";
            this.Size = new System.Drawing.Size(252, 460);
            this.Load += new System.EventHandler(this.Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtpic;
        private System.Windows.Forms.Label txtname;
        private Guna.UI2.WinForms.Guna2Button btnapprove;
        private Guna.UI2.WinForms.Guna2Button btnreject;
        private System.Windows.Forms.Label txtjob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtsdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtedate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtdays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txttype;
    }
}
