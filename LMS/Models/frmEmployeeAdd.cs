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

namespace LMS.Models
{
    public partial class frmEmployeeAdd : Sample
    {
        public frmEmployeeAdd()
        {
            InitializeComponent();
            //me design the form to save time
        }

        private void btncencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmEmployeeAdd_Load(object sender, EventArgs e)
        {
            string qry = "select depID 'id', depName 'name' from tblDep";
            MainClass.CBFill(qry, cbdep);

            if(id > 0)
            {
                LoadForEdit();
            }
            
        }
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string filPath = ofd.FileName;
                txtpic.Image = new Bitmap(filPath);
            }
        }

        public int id = 0;
        public int depid = 0;

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtpass.Text != txtconfirmpass.Text)//두 개의 비밀번호 파일에 동일한 비밀번호가 있는지 확인합니다
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbrole.SelectedIndex == -1)//직책가 선택 됬는지 확인
            {
                MessageBox.Show("직책을 선택해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string qry = "";

            if(id == 0)
            {
                qry = @"Insert into tblEmployee(EmpID,eName,Job,email,contact,Birth,department,gender
                        ,doj,status,pass,address,role,pic)
                        Values(@EmpID,@eName,@Job,@email,@contact,@Birth,@department,@gender,@doj
                        ,@status,@pass,@address,@role,@pic)";
            }
            else
            {
                qry = @"Update tblEmployee Set EmpID=@EmpID,eName=@eName,Job=@Job,email=@email,
                        contact=@contact,Birth=@Birth,department=@department,gender=@gender
                        ,doj=@doj,status=@status,pass=@pass,address=@address,
                        role=@role,pic=@pic where ID = @id";
            }

            Image temp = new Bitmap(txtpic.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Byte[] BtyArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@EmpID", txtempid.Text);
            ht.Add("@eName", txtname.Text);
            ht.Add("@Job", txtjob.Text);
            ht.Add("@email", txtemail.Text);
            ht.Add("@contact", txtcontact.Text);
            ht.Add("@Birth", txtbirth.Text);
            ht.Add("@department", cbdep.SelectedValue);
            ht.Add("@gender", cbgender.Text);
            ht.Add("@doj", txtdoj.Text);
            ht.Add("@status", cbstatus.Text);
            ht.Add("@pass", txtpass.Text);
            ht.Add("@address", txtaddress.Text);
            ht.Add("@role", cbrole.Text);
            ht.Add("@pic", BtyArray);

            if(MainClass.SQL(qry, ht) > 0)
            {
                MainClass.ResetControls(guna2Panel1);
                txtpic.Image = Properties.Resources.User_G;
                MessageBox.Show("성공적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                id = 0;
                depid = 0;
            }


        }

        private void LoadForEdit()
        {
            string qry = "Select * from tblEmployee where ID = " + id;
            DataTable dt = MainClass.GetData(qry);
            foreach(DataRow row in dt.Rows)
            {
                txtempid.Text = row["empID"].ToString();
                txtname.Text = row["eName"].ToString();
                txtjob.Text = row["Job"].ToString();
                txtemail.Text = row["email"].ToString();
                txtcontact.Text = row["contact"].ToString();
                txtbirth.Text = row["Birth"].ToString();
                cbdep.SelectedValue = Convert.ToInt32(row["department"].ToString());
                cbgender.Text = row["gender"].ToString();
                txtdoj.Text = row["doj"].ToString();
                cbstatus.Text = row["status"].ToString();
                txtpass.Text = row["pass"].ToString();
                txtconfirmpass.Text = row["pass"].ToString();
                txtaddress.Text = row["address"].ToString();
                cbrole.Text = row["role"].ToString();

                Byte[] imageArray;
                imageArray = (byte[])row["pic"];
                byte[] imageByteArray = imageArray;
                txtpic.Image = Image.FromStream(new MemoryStream(imageArray));

                
            }
        }

    }
}
