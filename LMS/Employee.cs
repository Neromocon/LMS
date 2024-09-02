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

namespace LMS
{
    public partial class Employee : UserControl
    {
        public event EventHandler onSelect = null;
        public Employee()
        {
            InitializeComponent();

            //컨트롤을 수정할 속성
            //이벤트 컨트롤
        }

        public int id = 0;

        public string eName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string eJob
        {
            get { return txtJob.Text; }
            set { txtJob.Text = value; }
        }
        public string eEmail
        {
            get { return txtemail.Text; }
            set { txtemail.Text = value; }
        }
        public string ePhone
        {
            get { return txtphone.Text; }
            set { txtphone.Text = value; }
        }

        public Image eImage
        {
            get { return txtpic.Image; }
            set { txtpic.Image = value; }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            frmEmployeeAdd frm = new frmEmployeeAdd();
            frm.id = id;
            frm.ShowDialog();
            btn_Click(sender, e);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
