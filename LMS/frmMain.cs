using LMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmMain : Sample
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();

            //사용자가 관리자인지 확인

            if(MainClass.ROLE.ToLower() != "admin")
            {
                btnDep.Visible = false;
                btnType.Visible = false;
                btnEmployee.Visible = false;
                //다른 사용자가 부서 또는 유형 또는 새 직원을 추가할 수 없게 함
            }

            txtPic.Image = MainClass.IMG;
            lblUser.Text = MainClass.USER;
            lblJob.Text = MainClass.JOB;
        }

        private void AddControl(Form F)
        {
            CenterPanel.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(F);
            F.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControl(new frmDashboard());            
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            AddControl(new frmTypeView());
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            AddControl(new frmDepView());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            AddControl(new frmEmployeeView());
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //직원과 관리자에 대한 두 가지로 나눠 사용
            if (MainClass.ROLE.ToLower() == "admin")
            {
                AddControl(new frmReqViewAdmin());
            }
            else 
            {
                AddControl(new frmRequestView());
            }
            
        }
    }
}
