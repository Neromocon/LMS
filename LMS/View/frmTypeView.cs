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
    public partial class frmTypeView : Sample
    {
        public frmTypeView()
        {
            InitializeComponent();
        }

        private void frmTypeView_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            frmTypeAdd frm = new frmTypeAdd();
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
            string qry = @"select typeID, type, num, description from tblType where type like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtype);
            lb.Items.Add(dgvallowed);
            lb.Items.Add(dgvdec);
            MainClass.loadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmTypeAdd frm = new frmTypeAdd();
            frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
            frm.txttype.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvtype"].Value);
            frm.txtallowed.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvallowed"].Value);
            frm.txtdes.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvdec"].Value);
            frm.ShowDialog();
            Loaddata();

        }
    }
}
