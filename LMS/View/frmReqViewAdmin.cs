using LMS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.View
{
    public partial class frmReqViewAdmin : Sample
    {
        public frmReqViewAdmin()
        {
            InitializeComponent();            
        }

        private void frmReqViewAdmin_Load(object sender, EventArgs e)
        {
            Loaddata();
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

        private void Loaddata()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry = "SELECT * From tblRequest r INNER JOIN tblEmployee e on e.ID = r.empID INNER JOIN tblType t on t.typeID = r.typeID where eName like '%" + txtSearch.Text + "%' and reqStatus = 'Pending'";
            DataTable dt = MainClass.GetData(qry);

            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Byte[] imageArray = (byte[])row["pic"];
                    byte[] imageByteArray = imageArray;

                    AddItems(row["reqID"].ToString(),
                            row["eName"].ToString(),
                            row["Job"].ToString(),
                            row["reqfrom"].ToString(),
                            row["reqto"].ToString(),
                            row["type"].ToString(),
                            Image.FromStream(new MemoryStream(imageArray)));
                }
            }
        }

        public void AddItems(string id, string name, string job, string sdate, string edate, string typeName, Image img)
        {
            var w = new Request()
            {
                eName = name,
                eJob = job,
                sdate = sdate,
                edate = edate,
                Leavetype = typeName,
                eImage = img,
                id = Convert.ToInt32(id)
            };
            flowLayoutPanel1.Controls.Add(w);
            w.onSelectApprove += (ss, ee) =>//승인 버튼을 누르면 승인할 수 있도록 상태를 갱신함 
            {
                if (DialogResult.Yes == MessageBox.Show("이 요청을 승인하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    var wdg = (Request)ss;
                    string qry = "Update tblRequest SET reqStatus = 'Approved' where reqID = " + wdg.id + "";
                    Hashtable ht = new Hashtable();
                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("요청이 성공적으로 승인되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }

                    Loaddata();
                }
            };
            w.onSelectReject += (ss, ee) =>//거절 버튼을 누르면 거절할 수 있도록 상태를 갱신함
            {
                if (DialogResult.Yes == MessageBox.Show("이 요청을 거절하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    var wdg = (Request)ss;
                    string qry = "Update tblRequest SET reqStatus = 'Rejected' where reqID = " + wdg.id + "";
                    Hashtable ht = new Hashtable();
                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("요청이 성공적으로 거절되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }

                    Loaddata();
                }
            };

        }

    }
}
