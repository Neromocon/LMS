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
    public partial class Request : UserControl
    {
        //버튼 클릭 승인 또는 거부에 대한 두 개의 이벤트

        public event EventHandler onSelectApprove = null;
        public event EventHandler onSelectReject = null;

        public Request()
        {
            InitializeComponent();
        }


        //속성 추가

        public int id { get; set; }
        public string eName
        {
            get { return txtname.Text; }
            set { txtname.Text = value; }
        }
        public string eJob
        {
            get { return txtjob.Text; }
            set { txtjob.Text = value; }
        }
        public string sdate
        {
            get { return txtsdate.Text; }
            set { txtsdate.Text = value; }
        }
        public string edate
        {
            get { return txtedate.Text; }
            set { txtedate.Text = value; }
        }
        public Image eImage
        {
            get { return txtpic.Image; }
            set { txtpic.Image = value; }
        }
        public string Leavetype
        {
            get { return txttype.Text; }
            set { txttype.Text = value; }
        }

        private void Request_Load(object sender, EventArgs e)
        {
            //두 날짜의 차이를 계산 함.
            //두 날짜를 모두 포함해야 하기에 날짜를 뺀 후 +1을 해준다.
            txtdays.Text = ((Convert.ToDateTime(txtedate.Text) - Convert.ToDateTime(txtsdate.Text)).TotalDays + 1).ToString();            
        }

        //클릭 이벤트
        private void btnapprove_Click(object sender, EventArgs e)
        {
            onSelectApprove?.Invoke(this, e);
        }

        private void btnreject_Click(object sender, EventArgs e)
        {
            onSelectReject?.Invoke(this, e);
        }
    }
}
