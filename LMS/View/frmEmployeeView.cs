using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.View
{
    public partial class frmEmployeeView : Sample
    {
        public frmEmployeeView()
        {
            InitializeComponent();
        }

        private void frmEmployeeView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeAdd frm = new frmEmployeeAdd();
            frm.ShowDialog();
            LoadData();
        }


        private void AddItems(string id, string name, string job, string email, string phone, Image img)
        {
            var w = new Employee()
            {
                eName = name,
                eJob = job,
                eEmail = email,
                ePhone = phone,
                eImage = img,
                id = Convert.ToInt32(id)
            };
            flowLayoutPanel1.Controls.Add(w);
            w.onSelect += (ss, ee) =>
            {
                LoadData();
            };

        }

        private void LoadData() 
        {
            flowLayoutPanel1.Controls.Clear();//패널에 존재하는 기존의 것들을 지움
            string qry = "Select * from tblEmployee where eName like '%" + txtSearch.Text + "%'";
            DataTable dt = MainClass.GetData(qry);//데이터를 얻음

            if(dt.Rows.Count >= 1 )
            {
                //직원 정보를 하나씩 불러옴
                foreach(DataRow row in dt.Rows )
                {
                    Byte[] imageArray = (byte[])row["pic"];
                    byte[] imageByteArray = imageArray;

                    AddItems(row["ID"].ToString(),
                        row["eName"].ToString(),
                        row["Job"].ToString(),
                        row["email"].ToString(),
                        row["contact"].ToString(),
                        Image.FromStream(new MemoryStream(imageArray)));
                }
            }
        }

    }
}
