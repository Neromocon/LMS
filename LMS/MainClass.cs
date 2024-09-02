using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    internal class MainClass
    {
        //먼저 사용자가 로그인할 때 사용자 데이터를 저장할 속성을 만듬

        private static string name;
        private static string role;
        private static int userid;
        private static string Job;
        private static Image img;
        
        public static string USER
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public static string ROLE
        {
            get
            {
                return role;
            }
            private set
            {
                role = value;
            }
        }

        public static int USERID
        {
            get
            {
                return userid;
            }
            private set
            {
                userid = value;
            }
        }

        public static string JOB
        {
            get
            {
                return Job;
            }
            private set
            {
                Job = value;
            }
        }

        public static Image IMG
        {
            get
            {
                return img;
            }
            private set
            {
                img = value;
            }
        }

        //now we download DB browser software to create sqlite database
        //SQLite 데이터베이스를 만들기 위해 DB 브라우저 소프트웨어를 다운로드함
        //디버그 폴더에 데이터베이스 생성


        //먼저 문자열을 연결함.

        public static SQLiteConnection con = new SQLiteConnection("Data Source =" + 
            Application.StartupPath + "\\Database\\LMS.db; Version=3;New=false;Compress=True", true);
        // Application.StartupPath는 윈폼 애플리케이션에서 사용되는 속성임.
        // 현재 애플리케이션이 실행되거 있는 디렉토리의 경로를 반환함. 여기선 "\\Database\\LMS.db; Version=3;New=false;Compress=True"
        // 이 속성은 애플리케이션이 시작된 위치를 기준으로 파일 경로를 구성하거나 설정 파일, 리소스 파일 등을
        // 찾는데 용이함.

        //삽입, 업데이트 삭제를 위한 몇 가지 추가 기능

        public static int SQL(string qry, Hashtable ht)
        // Hashtable은 C#에서 키-값 둘을 저정하는 데이터 구조임
        // 해시 테이블 알고리즘을 사용해서 검색, 추가 및 삭제 작업을 지원함.        
        {
            int res = 0;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(qry, con);
                // SQLiteCommand는 SQLite 데이터베이스와 상호 작용하기 위한 클래스임.
                // 이 클래스는 SQL명령문을 실행하고, 데이터베이스에 대한 CRUD(Create, Read, Update, Delete)
                //작업을 수행함.
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                // DictionaryEntry는 주로 HashTable이나 IDictionary 컬렉션을 열거할 때 사용함.
                // 예를 들어 foreach 루프를 사용하여 HashTable의 모든 항목을 열거할 때, 각 항목은
                // DictionaryEntry로 나타남.
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    //Parameters.AddWithValue는 SQLiteCommand의 Parameters 컬렉션에 매게변수를 추가하는 매서드임.
                    // 이 메서드는 매개변수의 이름과 값을 받아 SQL 쿼리에 추가함.
                    // item.Key.ToString()는 매게변수의 이름임. 정확히는 item.Key가 이름으로 사용되며 이를
                    // ToString()을 사용, 문자열로 변환하여 AddWithValue 메서드에 전달함.
                    // item.Value은 매개변수의 값임. 매개변수 이름에 할당될 실제 값을 나타냄.
                    // 예를 들면, item.Value가 Alpha면 SQL 쿼리에서 @name 매개변수는 Alpha 값을 가지게 됨
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                // ExecuteNonQuery()는 데이터베이스 명령을 실행할 때 사용되는 메서드로 주로 데이터베이스에서 
                // 데이터를 수정하는 SQL 명령(Insert, Update, Delete 등)을 실행하는 데 사용됨
                // 주요 특징으로는
                // 1. 결과 집합 반환 없음 : Select 쿼리와 같은 결과 집합을 반환하지 않는 SQL 명령에 사용됨
                // 2. 영향 받은 행의 수 반환 : SQL 명령이 데이터베이스에서 영향을 미친 행의 수를 정수로 반환.
                //   예를 들어, 3개의 행이 업데이트되면 ExecuteNonQuery는 3을 반환함.
                // 3. 예외 처리 : SQL 명령이 실패하면 예외가 발생할 수 있으므로, 이를 처리하는 것이 중요함.
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            // 예외처리
            {
                MessageBox.Show(ex.ToString());
                con.Close();
                // 문제 발생시 메세지 박스를 보여주고 데이터베이스 연결을 닫음
            }
            return res;

        }

        //콤보박스 채우기
        public static void CBFill(string qry, Guna2ComboBox cb)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(qry, con);
                //SQLiteCommand는 ADO.NET 프레임워크의 일부로, SQLite 데이터베이스에 대해 SQL 명령을
                // 실행하는데 사용되는 클래스임. 이 클래스는 SQL문을 데이터베이스에 전달하고, 쿼리 실행
                // 결과를 처리하는 기능을 제공함.
                cmd.CommandType = CommandType.Text;

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                //SQLiteDataAdapter는 ADO.NET에서 SQLtie 데이터베이스와 상호 작용할 때 사용되는 클래스임.
                // SQLiteDataAdapter는 데이터를 데이터베이스와 데이터셋(DataSet) 간에 전송하는 역할을 하며
                // 데이터베이스에서 데이터를 조회하고, 업데이트하고, 데이터셋에 데이터를 채우는데 사용함.
                DataTable dt = new DataTable();
                //DataTable는 ADO.NET의 핵심 클래스 주 하나로, 메모리 내에서 테이블 형식의 데이터를 저장
                //하고 조작하는데 사용됨. 데이터베이스의 테이블과 유사한 구조를 가지며, 다양한 데이터 조작
                //기능을 제공함.
                da.Fill(dt);
                cb.DisplayMember = "name";
                //DisplayMember는 윈폼 또는 WPF 애플리케이션에서 사용되는 속성임
                //ComboBox 또는 ListBox와 같은 컨트롤에서 사용되며 데이터 소스의 특정 속성을 사용자에게
                //보여주는데 사용됨.
                cb.ValueMember = "id";
                //ValueMember는 윈폼 또는 WPF 애플리케이션에서 데이터 바인딩 컨트롤에서 각 항목의 값을 정의하는
                //속성임. ValueMember 속성은 ComboBox, ListBox, CheckedListBox 등과 같은 컨트롤에서 사용되며
                // 각 항목의 실제 값을 정의하는데 사용됨.
                cb.DataSource = dt;
                //DataSource는 ADO.NET 및 데이터 바인딩 컨트롤에서 데이터의 원본을 지정하는 속성임.
                //이 속성은 데이터 컨트롤(예를들어, ComboBox, ListBox, DataGridView, BindingSource 등)에
                //데이터를 제공하여 컨트롤의 항목 또는 셀에 데이터를 표시할 수 있도록 함.
                cb.SelectedIndex = 0;
                //SelectedIndex는 윈폼 및 WPF에서 사용되는 컨트롤 속성으로 ComboBox, ListBox, CheckedListBox,
                //ListView 등에서 현재 선택된 항목의 인덱스를 나타냄. 이 속성은 선택된 항목의 위치를 0부터 
                //시작하는 정수로 반환하며, 선택된 항목이 없을 경우에는 -1을 반환함.
                cb.SelectedIndex = -1;
                //데이터 바인딩 컨트롤은 원폼 및 WPF 애플리케이션에서 데이터와 사용자 인터페이스(UI)를 연결하는 데
                //사용되는 컨트롤임. 이 컨트롤은 데이터 소스와 연결되어 데이터를 자동으로 표시하고 업데이트하며, 
                //사용자가 인터페이스를 통해 데이터를 조작할 수 있도록 함. 
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }


        }

        //데이터 로드
        public static void loadData(string qry, DataGridView gv, ListBox lb) 
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(qry, MainClass.con);
                cmd.CommandType = System.Data.CommandType.Text;
                //System.Data.CommandType.Text : CommandType은 SQL 명령을 정의할 때 사용되는 열거형의 값중 하나임                
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++) 
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;

            }
            catch (Exception ex) 
            {
                MainClass.con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        //데이터를 데이터테이블에서 가져오기

        public static DataTable GetData(string qry)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(qry, con);

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "LMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
            return dt;
        }

        //폼 컨트롤을 재설정
        //컨트롤이 파라미터를 위해 패널에 표시되기 때문에 guna2 패널을 제공함
        public static void ResetControls(Guna2Panel p)
        {
            foreach (Control c in p.Controls)
            //Control은 원폼 애플리케이션에서 사용자 인터페이스 요소를 구성하는 기본 클래스임.
            //모든 UI 요소는Control 클래스를 상속하여 만들어지며, 이를 통해 화면에 표시되거나
            //사용자의 입력을 처리할 수 있음. Control 클래스는 다양한 UI요소의 공통 기능을 제공하며
            // 다른 컨트롤(예를들어 Button, TextBox, Label)은 모두 이 클래스를 기반으로 함
            {
                if (c is Guna2TextBox)
                {
                    Guna2TextBox t = (Guna2TextBox)c;
                    {
                        t.Text = "";
                    }
                }
                if(c is Guna2ComboBox)//드로그다운
                {
                    Guna2ComboBox t = (Guna2ComboBox)c;
                    {
                        t.SelectedIndex = 0;
                        t.SelectedIndex = -1;
                        t.Text = "";
                    }
                }
            }
        }

        //사용자 확인
        public static bool UserDetails(string user, string pass)
        {
            bool isValid = false;

            string qry = "SELECT * from tblEmployee where email = '" + user + "' and pass='" + pass + "'";
            SQLiteCommand cmd = new SQLiteCommand(qry, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count == 1)
            // DataSet의 첫번째 DataTable에서 행(row)의 수가 1인지를 검사함. 
            //즉, 데이터가 정확히 하나의 레코드를 반환했는지를 확인함.
            //이 조건이 참일 경우 데이터베이스 쿼리 결과가 정확히 하나의 행(row)만 존재하는 상황임
            {
                name = ds.Tables[0].Rows[0]["eName"].ToString();
                //첫번째 행의 eName 열의 값을 문자열로 변환하여 name변수에 저장함. eName은 열의
                //이름이며 이 열에서 데이터를 읽어옴
                role = ds.Tables[0].Rows[0]["role"].ToString();
                //첫번째 행의 role 열의 값을 문자열로 변환하여 role변수에 저장함
                Job = ds.Tables[0].Rows[0]["Job"].ToString();
                //첫번째 행의 Job열의 값을 문자열로 변환하여 Job변수에 저장함
                userid = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
                //첫번째 행의 ID열의 값을 문자열로 변환한 후 이를 정수로 변환하여 userid변수에 저장함
                //다른 창에서 나중에 액세스할 사용자 이름을 설정합니다

                Byte[] imageArray = (byte[])ds.Tables[0].Rows[0]["pic"];
                //첫번째 행의 pic열에서 이미지 데이터를 바이트 배열(byte[])로 가져옴.
                //pic열은 이미지 데이터를 바이너리 형태로 저장하고 저장함
                byte[] imageByteArray = imageArray;                
                img = Image.FromStream(new MemoryStream(imageArray));
                //바이트 배열로부터 MemoryStream를 생성하고 이 스트림을 사용하여 Image객체를 생성함
                //img는 이미지를 나타내는 Imgae임
                isValid = true;
                //즉, 데이터베이스에서 단일 레코드를 검색하고, 해당 레코드의 다양한 속성(이름, 역할,
                //직무, 사용자ID 이미지)을 추출하여 사용하거나 다른 UI요소에서 활용할 수 있도록
                //준비하는 작업을 수행함.
            }
            
            return isValid;
        } 



    }
}
