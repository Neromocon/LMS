using LMS.Models;
using LMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using Microsoft.Win32.SafeHandles;

namespace LMS
{
    public partial class frmDashboard : Sample
    {        
        private List<int> inputIds = new List<int>();


        public frmDashboard()
        {
            InitializeComponent();
            LoadInitialData();
        }

        // 데이터 입력 후 호출
        public void AddData(int id)
        {
            // 데이터 입력 처리 (예를 들어 데이터베이스에 추가)

            // ID를 목록에 추가
            inputIds.Add(id);

            // 데이터그리드뷰 업데이트
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            LoadData(inputIds);
        }
        private void LoadInitialData()
        {
            // 전체 요청 ID 목록을 가져옵니다.
            List<int> ids = GetAllRequestIds();

            // 요청 ID 목록에 따라 데이터를 로드합니다.
            LoadData(ids);
        }
        private void guna2DataGridView1_Height(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
            {
                // 첫 번째 열의 값을 기준으로 높이 설정
                var cellValue = guna2DataGridView1.Rows[i].Cells[0].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int value))
                {
                    if(value > 0)
                    {
                        guna2DataGridView1.Rows[i].Height = 80;
                    }
                    else
                    {
                        guna2DataGridView1.Rows[i].Height = 50;
                    }
                }
               
            }
            
        }

        //private void LoadData(int id)
        //{
        //    // SQL 쿼리 문자열을 설정
        //    string qry = "SELECT * FROM tblRequest r " +
        //                 "INNER JOIN tblEmployee e ON e.ID = r.empID " +
        //                 "INNER JOIN tblType t ON t.typeID = r.typeID " +
        //                 "WHERE r.reqID = @id";

        //    // 데이터베이스에서 데이터를 가져오는 방법
        //    using (var conn = new SQLiteConnection("Data Source=\\Database\\LMS.db"))
        //    {
        //        conn.Open();
        //        using (var cmd = new SQLiteCommand(qry, conn))
        //        {
        //            // 매개변수 추가
        //            cmd.Parameters.AddWithValue("@id", id);

        //            using (var adapter = new SQLiteDataAdapter(cmd))
        //            {
        //                var dataTable = new DataTable();
        //                adapter.Fill(dataTable);

        //                // DataGridView에 데이터 바인딩
        //                guna2DataGridView1.DataSource = dataTable;
        //            }
        //        }
        //    }
        //}
        private void LoadData(List<int> ids)
        {            
            if (ids.Count == 0)
            {
                // ID 목록이 비어 있는 경우, DataGridView를 비웁니다.
                guna2DataGridView1.DataSource = null;
                return;
            }

            // SQL 쿼리 문자열을 설정 (IN 절 사용)
            string qry = "SELECT r.reqID, strftime('%d-%m-%Y', r.reqDate) AS ReqDate, r.empID, e.eName, r.typeID, t.type, strftime('%d-%m-%Y', r.reqfrom) AS ReqFrom, " +
                         "strftime('%d-%m-%Y', r.reqto) AS ReqTo, reqReason, r.reqStatus " +
                         "FROM tblRequest r " +
                         "INNER JOIN tblEmployee e ON e.ID = r.empID " +
                         "INNER JOIN tblType t ON t.typeID = r.typeID " +
                         "WHERE r.reqID IN (" + string.Join(", ", ids) + ")";

            try
            {
                string dbPath = Path.Combine(Application.StartupPath, "Database", "LMS.db");
                using (var conn = new SQLiteConnection($"Data Source={dbPath}"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand(qry, conn))
                    {
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // DataGridView의 기존 컬럼을 모두 제거합니다.
                            guna2DataGridView1.Columns.Clear();

                            // DataGridView에 데이터 바인딩
                            guna2DataGridView1.DataSource = dataTable;
                            // 컬럼 숨기기 (필요한 경우)
                            guna2DataGridView1.Columns["reqID"].Visible = false;
                            guna2DataGridView1.Columns["empID"].Visible = false;
                            guna2DataGridView1.Columns["typeID"].Visible = false;

                            // 컬럼 이름 변경
                            guna2DataGridView1.Columns["ReqDate"].HeaderText = "요청 날짜";
                            guna2DataGridView1.Columns["eName"].HeaderText = "직원 이름";
                            guna2DataGridView1.Columns["type"].HeaderText = "요청 유형";
                            guna2DataGridView1.Columns["ReqFrom"].HeaderText = "시작 날짜";
                            guna2DataGridView1.Columns["ReqTo"].HeaderText = "종료 날짜";
                            guna2DataGridView1.Columns["reqReason"].HeaderText = "요청 사유";
                            guna2DataGridView1.Columns["reqStatus"].HeaderText = "상태";

                            // 필요한 컬럼 추가
                            // 예를 들어, StatusButton 컬럼 추가
                            if (!guna2DataGridView1.Columns.Contains("StatusButton"))
                            {
                                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                                buttonColumn.Name = "StatusButton";
                                buttonColumn.HeaderText = "Status";
                                buttonColumn.Text = "Approve/Reject";
                                buttonColumn.UseColumnTextForButtonValue = true;
                                guna2DataGridView1.Columns.Add(buttonColumn);
                            }
                            // 셀 포맷팅 이벤트 핸들러 등록
                            guna2DataGridView1.CellFormatting += guna2DataGridView1_CellFormatting;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateLabels();


        }

        private List<int> GetAllRequestIds()
        {
            List<int> ids = new List<int>();

            // SQL 쿼리 문자열을 설정
            string qry = "SELECT reqID FROM tblRequest";

            using (var conn = new SQLiteConnection("Data Source=\\Users\\admin\\source\\repos\\LMS\\LMS\\bin\\Debug\\Database\\LMS.db"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(qry, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(0)); // reqID 컬럼을 읽어 리스트에 추가
                        }
                    }
                }
            }

            return ids;
        }
        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // "StatusButton" 컬럼의 인덱스를 가져옵니다.
            if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "StatusButton")
            {
                // 셀의 요청 상태를 가져옵니다.
                string status = guna2DataGridView1.Rows[e.RowIndex].Cells["reqStatus"].Value?.ToString();

                if (status != null)
                {
                    switch (status)
                    {
                        case "Pending":
                            e.Value = "대기"; // 상태가 대기 중인 경우
                            break;
                        case "Approved":
                            e.Value = "승인"; // 상태가 승인된 경우
                            break;
                        case "Rejected":
                            e.Value = "거절"; // 상태가 거절된 경우
                            break;
                        default:
                            e.Value = "미지정"; // 기본 상태
                            break;
                    }
                }
            }
        }
        //r INNER JOIN tblEmployee e on e.ID = r.empID INNER JOIN tblType t on t.typeID = r.typeID where eName like '%' || ? || '%' and reqStatus = 'Pending'"
        //"SELECT COUNT(*) FROM tblRequest WHERE type IS NOT NULL").ToString();
        private void UpdateLabels()
        {
            string connectionString = "Data Source=\\Users\\admin\\source\\repos\\LMS\\LMS\\bin\\Debug\\Database\\LMS.db";

            lblLeaveNum.Text = GetCountFromDatabase(connectionString, "SELECT COUNT(*) From tblRequest WHERE typeID",null).ToString();
            lblEmpNum.Text = GetCountFromDatabase(connectionString, "SELECT COUNT(*) FROM tblEmployee",null).ToString();
            lblApprovedNum.Text = GetCountFromDatabase(connectionString, "SELECT COUNT(*) FROM tblRequest WHERE reqStatus = 'Approved'",null).ToString();
            lblRejectedNum.Text = GetCountFromDatabase(connectionString, "SELECT COUNT(*) FROM tblRequest WHERE reqStatus = 'Rejected'",null).ToString();
            lblPendingNum.Text = GetCountFromDatabase(connectionString, "SELECT COUNT(*) FROM tblRequest WHERE reqStatus = 'Pending'",null).ToString();
        }
        private int GetCountFromDatabase(string connectionString, string qry, string parameter)
        {
            int count = 0;

            using(SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(qry, conn))
                {
                    if (parameter != null)
                    {
                        cmd.Parameters.AddWithValue("param", parameter);
                    }
                    try
                    {
                        conn.Open();
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                    
                
                

                //count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count;
        }
       

    }

}
