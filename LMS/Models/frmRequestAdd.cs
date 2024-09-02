using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Models
{
    public partial class frmRequestAdd : Sample
    {        
        public frmRequestAdd()
        {
            InitializeComponent();            
        }
        private void frmRequestAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select typeID 'id', type 'name' from tblType";
            MainClass.CBFill(qry, cbType);
        }

        private void btncencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if(id == 0)
            {
                qry = @"Insert into tblRequest (reqDate, empID, typeID, reqfrom, reqto, reqStatus, reqReason)
                        Values (@reqDate, @empID, @typeID, @reqfrom, @reqto, @reqStatus, @reqReason)";
            }
            else
            {
                qry = @"Update tblRequest SET empID = @empID, tpyeID = @typeID, reqfrom = @reqfrom, 
                        reqto = @reqto, reqStatus = @reqStatus, reqReason = @reqReason where reqID = @id";
            }
            //reqDate = @reqDate, 
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@empID", MainClass.USERID);
            ht.Add("@typeID", Convert.ToInt32(cbType.SelectedValue));
            ht.Add("@reqfrom", Convert.ToDateTime(txtsdate.Text).ToString("yyyy-MM-dd"));
            ht.Add("@reqto", Convert.ToDateTime(txtedate.Text).ToString("yyyy-MM-dd"));
            ht.Add("@reqStatus", "Pending");
            ht.Add("@reqReason", txtReason.Text);
            ht.Add("@reqDate", DateTime.Now.ToString("yyyy-MM-dd"));

            if (MainClass.SQL(qry, ht) > 0)
            {
                MainClass.ResetControls(guna2Panel1);
                MessageBox.Show("성공적으로 저장되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                id = 0;
            }

        }


    }
}
