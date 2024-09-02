namespace LMS.Models
{
    partial class frmRequestAdd
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
            this.txtReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.btncencel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtedate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtsdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReason
            // 
            this.txtReason.AutoRoundedCorners = true;
            this.txtReason.BorderRadius = 19;
            this.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.DefaultText = "";
            this.txtReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReason.Location = new System.Drawing.Point(39, 310);
            this.txtReason.Name = "txtReason";
            this.txtReason.PasswordChar = '\0';
            this.txtReason.PlaceholderText = "";
            this.txtReason.SelectedText = "";
            this.txtReason.Size = new System.Drawing.Size(518, 40);
            this.txtReason.TabIndex = 11;
            this.txtReason.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btncencel
            // 
            this.btncencel.AutoRoundedCorners = true;
            this.btncencel.BorderRadius = 21;
            this.btncencel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncencel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncencel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncencel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncencel.FillColor = System.Drawing.Color.RoyalBlue;
            this.btncencel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncencel.ForeColor = System.Drawing.Color.White;
            this.btncencel.Location = new System.Drawing.Point(449, 378);
            this.btncencel.Name = "btncencel";
            this.btncencel.Size = new System.Drawing.Size(108, 45);
            this.btncencel.TabIndex = 13;
            this.btncencel.Text = "Cencel";
            this.btncencel.Click += new System.EventHandler(this.btncencel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 21;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(335, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "휴가 시작일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "사유";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "휴가 유형";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "요청 양식";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtedate);
            this.guna2Panel1.Controls.Add(this.txtsdate);
            this.guna2Panel1.Controls.Add(this.cbType);
            this.guna2Panel1.Controls.Add(this.btncencel);
            this.guna2Panel1.Controls.Add(this.btnSave);
            this.guna2Panel1.Controls.Add(this.txtReason);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(600, 457);
            this.guna2Panel1.TabIndex = 18;
            // 
            // txtedate
            // 
            this.txtedate.AutoRoundedCorners = true;
            this.txtedate.BorderColor = System.Drawing.Color.Silver;
            this.txtedate.BorderRadius = 17;
            this.txtedate.BorderThickness = 1;
            this.txtedate.Checked = true;
            this.txtedate.FillColor = System.Drawing.Color.White;
            this.txtedate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtedate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtedate.Location = new System.Drawing.Point(307, 214);
            this.txtedate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtedate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtedate.Name = "txtedate";
            this.txtedate.Size = new System.Drawing.Size(250, 36);
            this.txtedate.TabIndex = 18;
            this.txtedate.TextOffset = new System.Drawing.Point(10, 0);
            this.txtedate.Value = new System.DateTime(2024, 8, 7, 14, 28, 51, 16);
            // 
            // txtsdate
            // 
            this.txtsdate.AutoRoundedCorners = true;
            this.txtsdate.BorderColor = System.Drawing.Color.Silver;
            this.txtsdate.BorderRadius = 17;
            this.txtsdate.BorderThickness = 1;
            this.txtsdate.Checked = true;
            this.txtsdate.FillColor = System.Drawing.Color.White;
            this.txtsdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtsdate.Location = new System.Drawing.Point(39, 214);
            this.txtsdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtsdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtsdate.Name = "txtsdate";
            this.txtsdate.Size = new System.Drawing.Size(250, 36);
            this.txtsdate.TabIndex = 18;
            this.txtsdate.TextOffset = new System.Drawing.Point(10, 0);
            this.txtsdate.Value = new System.DateTime(2024, 8, 7, 14, 28, 51, 16);
            // 
            // cbType
            // 
            this.cbType.AutoRoundedCorners = true;
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderRadius = 17;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.ItemHeight = 30;
            this.cbType.Location = new System.Drawing.Point(39, 130);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(250, 36);
            this.cbType.TabIndex = 16;
            this.cbType.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "휴가 종료일";
            // 
            // frmRequestAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 457);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmRequestAdd";
            this.Text = "frmRequestAdd";
            this.Load += new System.EventHandler(this.frmRequestAdd_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2TextBox txtReason;
        private Guna.UI2.WinForms.Guna2Button btncencel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtsdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtedate;
    }
}