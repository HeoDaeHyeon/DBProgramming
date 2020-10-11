using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables(); // ComboBox Item 초기설정
        }
        String opera=""; // 연산의 종류를 확인하기위해 String 임시변수 선언




        public void InitVariables() {
            comboBoxComboCalc_Operator.Items.Clear();

            comboBoxComboCalc_Operator.Items.Add("+");  
            comboBoxComboCalc_Operator.Items.Add("-");
            comboBoxComboCalc_Operator.Items.Add("*");
            comboBoxComboCalc_Operator.Items.Add("/");
            comboBoxComboCalc_Operator.Items.Add("^"); // 덧셈~제곱연산 Item구성원 추가

            comboBoxComboCalc_Operator.SelectedIndex = 0;

        }


        private void buttonComboBoxCalculator_Click(object sender, EventArgs e)
        {
            String oper1 = textBoxComboCalc_Oper1.Text;  
            String oper2 = textBoxComboCalc_Oper2.Text;

            double oper_1 = Convert.ToDouble(oper1); // Convert 클래스를 이용하여 받아온 text를 소수점단위까지 계산을위해 double 형으로 변환
            double oper_2 = Convert.ToDouble(oper2); // Convert 클래스를 이용하여 받아온 text를 소수점단위까지 계산을위해 double 형으로 변환

            double result = 0; // 계산결과를 저장하는 변수
        
            switch (comboBoxComboCalc_Operator.SelectedIndex) { // 선택 index 에 따라 해당 연산수행
                case 0: // 더하기
                    result = oper_1 + oper_2;
                    break;

                case 1: // 빼기
                    result = oper_1 - oper_2;
                    break;

                case 2: // 곱하기
                    result = oper_1 * oper_2;
                    break;

                case 3: // 나누기
                    result = oper_1 / oper_2;
                    break;

                case 4: // 제곱
                    result = oper_1; 
                    if (oper_2 == 0) result = 1; // oper_2가 0일때 결과는 1
                    else if (oper_2 > 0) // 제곱근이 양수일때
                    {
                        for (int i = 1; i < oper_2; i++) // 해당수만큼 제곱의원리 로 반복문
                        {
                            result *= oper_1;
                        }
                    }
                    else if (oper_2 < 0) // 제곱근이 음수일때
                    {
                        oper_2 *= -1; // 양수로 임시전환후 해당 제곱연산 수행 (밑에서 역수해줘야함)
                        for (int i = 1; i < oper_2; i++) // 해당수만큼 제곱의원리 로 반복문
                        {
                            result *= oper_1;
                        }
                        result = 1 / result; // 제곱근이 음수일때는 역수를 취해줌
                    }
                    break;

            }

            String result_1 = Convert.ToString(result); // 결과값을 나타내기위해 String으로 변환

            if (comboBoxComboCalc_Operator.SelectedIndex==3 && oper_2 == 0) textBoxComboCalc_Result.Text = "잘못된 수식."; // 나눗셈일때 0으로 나눌수없기에 예외처리
            else textBoxComboCalc_Result.Text = result_1;
        }


        private void buttonRadioCalculator_Click(object sender, EventArgs e)
        {
            String oper1 = textBoxRadioCalc_Oper1.Text;
            String oper2 = textBoxRadioCalc_Oper2.Text;

            double oper_1 = Convert.ToDouble(oper1); // Convert 클래스를 이용하여 받아온 text를 소수점단위까지 계산을위해 double 형으로 변환
            double oper_2 = Convert.ToDouble(oper2); // Convert 클래스를 이용하여 받아온 text를 소수점단위까지 계산을위해 double 형으로 변환
            double result = 0; // 계산결과를 저장하는 변수
            switch(opera) { // 연산의종류에 해당하는 연산수행
                case "+": // 더하기
                    result = oper_1 + oper_2;
                    break;

                case "-": // 빼기
                    result = oper_1 - oper_2;
                    break;

                case "*": // 곱하기
                    result = oper_1 * oper_2;
                    break;

                case "/": // 나누기
                    result = oper_1 / oper_2;
                    break;

                case "^": // 제곱
                    result=oper_1;
                    if (oper_2 == 0) result = 1; // oper_2가 0일때 결과는 1
                    else if (oper_2 > 0) // 제곱근이 양수일때
                    {
                        for (int i = 1; i < oper_2; i++) // 해당수만큼 제곱의원리 로 반복문
                        {
                            result *= oper_1;
                        }
                    }
                    else if (oper_2 < 0) // 제곱근이 음수일때
                    {
                        oper_2 *= -1; // 양수로 임시전환후 해당 제곱연산 수행 (밑에서 역수해줘야함)
                        for (int i = 1; i < oper_2; i++) // 해당수만큼 제곱의원리 로 반복문
                        {
                            result *= oper_1;
                        }
                        result = 1 / result; // 제곱근이 음수일때는 역수를 취해줌
                    }
                    break;

            }

            String result_1 = Convert.ToString(result); // 결과값을 String으로 변환

            if (opera == "/" && oper_2 == 0) textBoxRadioCalc_Result.Text = "잘못된 수식."; // 나눗셈할때 0으로 나눌수없기에 예외처리
            else textBoxRadioCalc_Result.Text = result_1;
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            opera = "+";
        }

        private void radioButtonSubtrac_CheckedChanged(object sender, EventArgs e)
        {
            opera = "-";
        }

        private void radioButtonMultipl_CheckedChanged(object sender, EventArgs e)
        {
            opera = "*";
        }

        private void radioButtonDivision_CheckedChanged(object sender, EventArgs e)
        {
            opera = "/";
        }

        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            opera = "^";
        }



    }
}
