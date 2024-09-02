using Guna.UI2.WinForms;
using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.View
{
    public partial class frmDepView : Sample
    {
        public frmDepView()
        {
            InitializeComponent();
        }

        private void frmDepView_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            frmDepAdd frm = new frmDepAdd();
            frm.ShowDialog();
            Loaddata();
        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Loaddata();
        }


        // 데이터그리드뷰의 데이터 불러오기
        private void Loaddata()
        {
            string qry = @"select depID, depName from tblDep where depName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvDep);
            MainClass.loadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDepAdd frm = new frmDepAdd();
            frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
            frm.txtDep.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvDep"].Value);            
            frm.ShowDialog();
            Loaddata();
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDepAdd frm = new frmDepAdd();
            frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
            frm.txtDep.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvDep"].Value);
            frm.ShowDialog();
            Loaddata();
        }
    }
}
