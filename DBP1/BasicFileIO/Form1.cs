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


namespace BasicFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            textBoxDisplay.Text = "Hi, Hello, Good, \r\nNext line";
        }
        /*
         * -----------------------------------------------------------------------------------
         *       이름      |        성별        |         나이        |        전공        
         *   varchar(MAX)  |        int         |         int         |     varchar(MAX)
         * -----------------------------------------------------------------------------------  
         *      김개똥               0                    24                  컴퓨터
         *      홍길순               1                    24                  모바일
         * 
         */ 

        private void buttonBinaryWrite_Click(object sender, EventArgs e)
        {
            long someValue = 0x123456789ABCDEF0;
            //long someValue = 123456789;
            /*Stream outStream = new FileStream("a.dat",FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue);

            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();
            Console.WriteLine("WRITE DATA DONE.");
             3주차*/

            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            bw.Write(2);
            bw.Write("Mr. Kim");
            bw.Write(0);
            bw.Write(24);
            bw.Write("Computer");

            bw.Write("Ms. Hong");
            bw.Write(1);
            bw.Write(24);
            bw.Write("Mobile");

            bw.Close();
        }

        /*
         *  위 데이터는 헤더와 데이터로 구성이 된다.
         *  헤더는 첫 4바이트 값으로 아래의 내용을 포함한다.
         *       *4바이트: 전체 학생의 수 (정수형)
         *       
         *  데이터는 헤더 이후에 바로 기록되어 다음의 형식에 맞게
         *  헤더에 기록된 학생 수 만큼 기록되어 있다.
         *  
         *  - 학생 데이터 형식 -
         *  1바이트 : 문자열의 길이 (바이트형, N1)
         *  N1 바이트: 문자열 (ASCII, 이름)
         *  4 바이트: 성별 (정수형, 0-남자, 1-여자)
         *  4 바이트: 나이 (정수형)
         *  1바이트: 문자열의 길이 (바이트형, N1)
         *  N1 바이트: 문자열 (ASCII, 전공)
         */

        private void buttonBinaryRead_Click(object sender, EventArgs e)
        {
           /* byte[] rBytes = new byte[8];

            Stream inStream = new FileStream("a.dat", FileMode.Open);

            inStream.Read(rBytes, 0, rBytes.Length);

            long readValue = BitConverter.ToInt64(rBytes, 0);

            Console.WriteLine("READ DATA =" + readValue);

            inStream.Close();
           3주차*/
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

            int num1 = br.ReadInt32();
            string str = br.ReadString();

            Console.WriteLine("Read Int =" + num1);
            Console.WriteLine("Read str =" + str);

            br.Close();
        }

        private void buttonStreamWriter_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.WriteLine(int.MaxValue);
            sw.WriteLine("Good Morning");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("안녕하세요");
            sw.WriteLine(double.MaxValue);
            sw.Close();
        }

        private void buttonStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            textBoxDisplay.Text = "";
            while (sr.EndOfStream == false)
            {
                textBoxDisplay.Text += sr.ReadLine();
                textBoxDisplay.Text += "\r\n";
                //Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }
    }
}
