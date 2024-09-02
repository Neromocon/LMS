using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Models
{
    public partial class frmDepAdd : Sample
    {
        public frmDepAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void btncencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // 삽입
            {
                qry = @"Insert into tblDep(depName) Values (@depName)";
            }
            else // 수정
            {
                qry = @"Update tblDep Set depName = @depName where depID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@depName", txtDep.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MainClass.ResetControls(guna2Panel1);
                MessageBox.Show("성공적으로 저장되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                id = 0;
            }

            //bcz를 지우지 않는 컨트롤은 추가 후 삽입된 것처럼 패널에 없습니다
            //판넬에 잘라 붙이도록 하는 양식에 대한 컨트롤
        }

    }
}
