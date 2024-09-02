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
    public partial class frmRequestView : Sample
    {
        public frmRequestView()
        {
            InitializeComponent();
        }

        private void frmRequestView_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            string qry = @"SELECT r.reqID, strftime('%d-%m-%Y', r.reqDate), r.empID, e.eName, r.typeID, t.type, strftime('%d-%m-%Y', r.reqfrom),
                    strftime('%d-%m-%Y', r.reqto), reqReason, r.reqStatus From tblRequest r
                    INNER JOIN tblEmployee e on e.ID = r.empID
                    INNER JOIN tblType t on t.typeID = r.typeID
                    where e.eName like '%" + txtSearch.Text + "%' and r.empID = " + MainClass.USERID + "";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvdate);
            lb.Items.Add(dgvempid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvtypeid);
            lb.Items.Add(dgvtype);
            lb.Items.Add(dgvfrom);
            lb.Items.Add(dgvto);
            lb.Items.Add(dgvreason);
            lb.Items.Add(dgvstatus);

            MainClass.loadData(qry, guna2DataGridView1, lb);
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            frmRequestAdd frm = new frmRequestAdd();
            frm.ShowDialog();
            Loaddata();
        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
