using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace StudentManagement
{
    public partial class Form1 : Form
    {
        int count; // 전체학생수 를 구하기위한 count변수
        public Form1()
        {
            InitializeComponent();
            InitVariables();

        }

        private void InitVariables() // 초기 설정
        {

            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent1Gender.Items.Add("남자");
            comboBoxStudent1Gender.Items.Add("여자");

            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            
            string[] genderData = { "남자", "여자" };
            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;

            labelStudentNum.Text = "0";

        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e) // 학생정보 불러오기
        {
            LoadStudent();
        }

        #region Student 1 Event handlers
        private void buttonStudent1Save_Click(object sender, EventArgs e) // 학생1 저장버튼
        {
            SaveStudent();
        }

        private void buttonStudent1Delete_Click(object sender, EventArgs e) // 학생1 데이터를 삭제
        {

            BinaryWriter bw = new BinaryWriter(new FileStream("student.stu", FileMode.Create));

            bw.Write("학생정보 없음");
            bw.Write("");
            bw.Write("남자");
            bw.Write("");

            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.Text);
            bw.Write(textBoxStudent2Display.Text);

            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.Text);
            bw.Write(textBoxStudent3Display.Text);

            bw.Close();
            LoadStudent();

        }
        #endregion

        #region Student 2 Event handlers
        private void buttonStudent2Save_Click(object sender, EventArgs e) // 학생2 저장버튼
        {
            SaveStudent();
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e) // 학생2 데이터를 삭제
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("student.stu", FileMode.Create));

            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.Text);
            bw.Write(textBoxStudent1Display.Text);

            bw.Write("학생정보 없음");
            bw.Write("");
            bw.Write("남자");
            bw.Write("");

            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.Text);
            bw.Write(textBoxStudent3Display.Text);

            bw.Close();
            LoadStudent();
        }
        #endregion

        #region Student 3 Event handlers
        private void buttonStudent3Save_Click(object sender, EventArgs e) // 학생3 저장버튼
        {
            SaveStudent();
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e) // 학생3 데이터를 삭제
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("student.stu", FileMode.Create));

            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.Text);
            bw.Write(textBoxStudent1Display.Text);

            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.Text);
            bw.Write(textBoxStudent2Display.Text);

            bw.Write("학생정보 없음");
            bw.Write("");
            bw.Write("남자");
            bw.Write("");

            bw.Close();
            LoadStudent();
        }
        #endregion

     
        private void LoadStudent() // 학생정보 로드
        {
            BinaryReader br = new BinaryReader(new FileStream("student.stu", FileMode.Open));
            string[] str = { br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString() };
            string name="학생정보 없음";

            textBoxStudent1Name.Text = str[0];
            textBoxStudent1ID.Text = str[1];
            comboBoxStudent1Gender.Text = str[2];
            textBoxStudent1Display.Text = str[3];

            textBoxStudent2Name.Text = str[4];
            textBoxStudent2ID.Text = str[5];
            comboBoxStudent2Gender.Text = str[6];
            textBoxStudent2Display.Text = str[7];
            
            textBoxStudent3Name.Text = str[8];
            textBoxStudent3ID.Text = str[9];
            comboBoxStudent3Gender.Text = str[10];
            textBoxStudent3Display.Text = str[11];

            count = 3; // 최대학생 수 설정
            for (int i = 0; i < 12; i += 4) // 학생이름을 기준으로 없는경우 감소
            {
                if (str[i] == name)
                    count--;
            }
            string Num = Convert.ToString(count);
            labelStudentNum.Text = Num;
                br.Close();
        }


        private void SaveStudent() // 학생정보 저장
        {
       
            BinaryWriter bw = new BinaryWriter(new FileStream("student.stu", FileMode.Create));

            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.Text);
            bw.Write(textBoxStudent1Display.Text);

            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.Text);
            bw.Write(textBoxStudent2Display.Text);

            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.Text);
            bw.Write(textBoxStudent3Display.Text);

            bw.Close();
           
            
 
        }

        // Form에서 체크박스 저장을위한 Setting
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxLoad.Checked = Properties.Settings.Default.CheckBox;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CheckBox = checkBoxLoad.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBoxLoad_CheckedChanged(object sender, EventArgs e) // checkBox 체크유무에 따라 자동로드
        {
            LoadStudent();
        }

     
    }
}
