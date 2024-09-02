using Guna.UI2.WinForms;
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
    public partial class frmLogin : Sample
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtemail.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("이메일과 비밀번호를 입력해주세요.");
                return;
            }

            if(MainClass.UserDetails(txtemail.Text, txtpass.Text) == true)
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("이메일과 비밀번호를 확인해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //btnLogin_Click(sender, e);
                if (MainClass.UserDetails(txtemail.Text, txtpass.Text) == false)
                {
                    guna2MessageDialog1.Show("이메일과 비밀번호를 다시 한 번 확인해 주세요.");
                    return;
                }
                else
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                }
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //btnLogin_Click(sender, e);
                if (MainClass.UserDetails(txtemail.Text, txtpass.Text) == false)
                {
                    guna2MessageDialog1.Show("이메일과 비밀번호를 다시 한 번 확인해 주세요.");
                    return;
                }
                else
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
