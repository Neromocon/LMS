using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Models
{
    public partial class frmTypeAdd : Sample
    {
        public frmTypeAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public virtual void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if(id  == 0) // 삽입
            {
                qry = @"Insert into tblType(type, description, num) Values (@type, @description, @num)";
            }
            else // 수정
            {
                qry = @"Update tblType Set type = @type, description = @description, num = @num where typeID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@type", txttype.Text);
            ht.Add("@description", txtdes.Text);
            ht.Add("@num", Convert.ToInt32(txtallowed.Text));

            if(MainClass.SQL(qry, ht) > 0)
            {
                MainClass.ResetControls(guna2Panel1);
                MessageBox.Show("성공적으로 저장되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                id = 0;
            }

        }

        public virtual void btncencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
