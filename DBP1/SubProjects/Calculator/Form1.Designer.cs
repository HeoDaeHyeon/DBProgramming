namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxComboCalc = new System.Windows.Forms.GroupBox();
            this.buttonComboBoxCalculator = new System.Windows.Forms.Button();
            this.comboBoxComboCalc_Operator = new System.Windows.Forms.ComboBox();
            this.textBoxComboCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRadioButtonCalc = new System.Windows.Forms.GroupBox();
            this.groupBoxOperator = new System.Windows.Forms.GroupBox();
            this.radioButtonSubtrac = new System.Windows.Forms.RadioButton();
            this.radioButtonMultipl = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.buttonRadioCalculator = new System.Windows.Forms.Button();
            this.textBoxRadioCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.groupBoxComboCalc.SuspendLayout();
            this.groupBoxRadioButtonCalc.SuspendLayout();
            this.groupBoxOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCalc
            // 
            this.groupBoxComboCalc.Controls.Add(this.buttonComboBoxCalculator);
            this.groupBoxComboCalc.Controls.Add(this.comboBoxComboCalc_Operator);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Result);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Oper2);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Oper1);
            this.groupBoxComboCalc.Controls.Add(this.label4);
            this.groupBoxComboCalc.Controls.Add(this.label3);
            this.groupBoxComboCalc.Controls.Add(this.label2);
            this.groupBoxComboCalc.Controls.Add(this.label1);
            this.groupBoxComboCalc.Location = new System.Drawing.Point(22, 22);
            this.groupBoxComboCalc.Name = "groupBoxComboCalc";
            this.groupBoxComboCalc.Size = new System.Drawing.Size(528, 106);
            this.groupBoxComboCalc.TabIndex = 0;
            this.groupBoxComboCalc.TabStop = false;
            this.groupBoxComboCalc.Text = "ComboBox Calculator";
            // 
            // buttonComboBoxCalculator
            // 
            this.buttonComboBoxCalculator.Location = new System.Drawing.Point(342, 52);
            this.buttonComboBoxCalculator.Name = "buttonComboBoxCalculator";
            this.buttonComboBoxCalculator.Size = new System.Drawing.Size(70, 20);
            this.buttonComboBoxCalculator.TabIndex = 8;
            this.buttonComboBoxCalculator.Text = "Calculator";
            this.buttonComboBoxCalculator.UseVisualStyleBackColor = true;
            this.buttonComboBoxCalculator.Click += new System.EventHandler(this.buttonComboBoxCalculator_Click);
            // 
            // comboBoxComboCalc_Operator
            // 
            this.comboBoxComboCalc_Operator.FormattingEnabled = true;
            this.comboBoxComboCalc_Operator.Location = new System.Drawing.Point(123, 52);
            this.comboBoxComboCalc_Operator.Name = "comboBoxComboCalc_Operator";
            this.comboBoxComboCalc_Operator.Size = new System.Drawing.Size(90, 20);
            this.comboBoxComboCalc_Operator.TabIndex = 7;
            // 
            // textBoxComboCalc_Result
            // 
            this.textBoxComboCalc_Result.Location = new System.Drawing.Point(437, 51);
            this.textBoxComboCalc_Result.Name = "textBoxComboCalc_Result";
            this.textBoxComboCalc_Result.Size = new System.Drawing.Size(75, 21);
            this.textBoxComboCalc_Result.TabIndex = 6;
            // 
            // textBoxComboCalc_Oper2
            // 
            this.textBoxComboCalc_Oper2.Location = new System.Drawing.Point(247, 51);
            this.textBoxComboCalc_Oper2.Name = "textBoxComboCalc_Oper2";
            this.textBoxComboCalc_Oper2.Size = new System.Drawing.Size(75, 21);
            this.textBoxComboCalc_Oper2.TabIndex = 5;
            // 
            // textBoxComboCalc_Oper1
            // 
            this.textBoxComboCalc_Oper1.Location = new System.Drawing.Point(18, 51);
            this.textBoxComboCalc_Oper1.Name = "textBoxComboCalc_Oper1";
            this.textBoxComboCalc_Oper1.Size = new System.Drawing.Size(75, 21);
            this.textBoxComboCalc_Oper1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand1";
            // 
            // groupBoxRadioButtonCalc
            // 
            this.groupBoxRadioButtonCalc.Controls.Add(this.groupBoxOperator);
            this.groupBoxRadioButtonCalc.Controls.Add(this.buttonRadioCalculator);
            this.groupBoxRadioButtonCalc.Controls.Add(this.textBoxRadioCalc_Result);
            this.groupBoxRadioButtonCalc.Controls.Add(this.textBoxRadioCalc_Oper2);
            this.groupBoxRadioButtonCalc.Controls.Add(this.textBoxRadioCalc_Oper1);
            this.groupBoxRadioButtonCalc.Controls.Add(this.label5);
            this.groupBoxRadioButtonCalc.Controls.Add(this.label6);
            this.groupBoxRadioButtonCalc.Controls.Add(this.label8);
            this.groupBoxRadioButtonCalc.Location = new System.Drawing.Point(24, 171);
            this.groupBoxRadioButtonCalc.Name = "groupBoxRadioButtonCalc";
            this.groupBoxRadioButtonCalc.Size = new System.Drawing.Size(528, 127);
            this.groupBoxRadioButtonCalc.TabIndex = 9;
            this.groupBoxRadioButtonCalc.TabStop = false;
            this.groupBoxRadioButtonCalc.Text = "Radio button Calculator";
            // 
            // groupBoxOperator
            // 
            this.groupBoxOperator.Controls.Add(this.radioButtonSquare);
            this.groupBoxOperator.Controls.Add(this.radioButtonSubtrac);
            this.groupBoxOperator.Controls.Add(this.radioButtonMultipl);
            this.groupBoxOperator.Controls.Add(this.radioButtonAdd);
            this.groupBoxOperator.Controls.Add(this.radioButtonDivision);
            this.groupBoxOperator.Location = new System.Drawing.Point(114, 27);
            this.groupBoxOperator.Name = "groupBoxOperator";
            this.groupBoxOperator.Size = new System.Drawing.Size(110, 94);
            this.groupBoxOperator.TabIndex = 13;
            this.groupBoxOperator.TabStop = false;
            this.groupBoxOperator.Text = "Operator";
            // 
            // radioButtonSubtrac
            // 
            this.radioButtonSubtrac.AutoSize = true;
            this.radioButtonSubtrac.Location = new System.Drawing.Point(19, 46);
            this.radioButtonSubtrac.Name = "radioButtonSubtrac";
            this.radioButtonSubtrac.Size = new System.Drawing.Size(29, 16);
            this.radioButtonSubtrac.TabIndex = 10;
            this.radioButtonSubtrac.TabStop = true;
            this.radioButtonSubtrac.Text = "-";
            this.radioButtonSubtrac.UseVisualStyleBackColor = true;
            this.radioButtonSubtrac.CheckedChanged += new System.EventHandler(this.radioButtonSubtrac_CheckedChanged);
            // 
            // radioButtonMultipl
            // 
            this.radioButtonMultipl.AutoSize = true;
            this.radioButtonMultipl.Location = new System.Drawing.Point(68, 24);
            this.radioButtonMultipl.Name = "radioButtonMultipl";
            this.radioButtonMultipl.Size = new System.Drawing.Size(29, 16);
            this.radioButtonMultipl.TabIndex = 11;
            this.radioButtonMultipl.TabStop = true;
            this.radioButtonMultipl.Text = "*";
            this.radioButtonMultipl.UseVisualStyleBackColor = true;
            this.radioButtonMultipl.CheckedChanged += new System.EventHandler(this.radioButtonMultipl_CheckedChanged);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(19, 24);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(29, 16);
            this.radioButtonAdd.TabIndex = 9;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "+";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged);
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(68, 45);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(29, 16);
            this.radioButtonDivision.TabIndex = 12;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "/";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            this.radioButtonDivision.CheckedChanged += new System.EventHandler(this.radioButtonDivision_CheckedChanged);
            // 
            // buttonRadioCalculator
            // 
            this.buttonRadioCalculator.Location = new System.Drawing.Point(342, 52);
            this.buttonRadioCalculator.Name = "buttonRadioCalculator";
            this.buttonRadioCalculator.Size = new System.Drawing.Size(70, 20);
            this.buttonRadioCalculator.TabIndex = 8;
            this.buttonRadioCalculator.Text = "Calculator";
            this.buttonRadioCalculator.UseVisualStyleBackColor = true;
            this.buttonRadioCalculator.Click += new System.EventHandler(this.buttonRadioCalculator_Click);
            // 
            // textBoxRadioCalc_Result
            // 
            this.textBoxRadioCalc_Result.Location = new System.Drawing.Point(437, 51);
            this.textBoxRadioCalc_Result.Name = "textBoxRadioCalc_Result";
            this.textBoxRadioCalc_Result.Size = new System.Drawing.Size(75, 21);
            this.textBoxRadioCalc_Result.TabIndex = 6;
            // 
            // textBoxRadioCalc_Oper2
            // 
            this.textBoxRadioCalc_Oper2.Location = new System.Drawing.Point(247, 51);
            this.textBoxRadioCalc_Oper2.Name = "textBoxRadioCalc_Oper2";
            this.textBoxRadioCalc_Oper2.Size = new System.Drawing.Size(75, 21);
            this.textBoxRadioCalc_Oper2.TabIndex = 5;
            // 
            // textBoxRadioCalc_Oper1
            // 
            this.textBoxRadioCalc_Oper1.Location = new System.Drawing.Point(18, 51);
            this.textBoxRadioCalc_Oper1.Name = "textBoxRadioCalc_Oper1";
            this.textBoxRadioCalc_Oper1.Size = new System.Drawing.Size(75, 21);
            this.textBoxRadioCalc_Oper1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Operand2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Operand1";
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(18, 72);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(29, 16);
            this.radioButtonSquare.TabIndex = 13;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = "^";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            this.radioButtonSquare.CheckedChanged += new System.EventHandler(this.radioButtonSquare_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 335);
            this.Controls.Add(this.groupBoxRadioButtonCalc);
            this.Controls.Add(this.groupBoxComboCalc);
            this.Name = "Form1";
            this.Text = "FormCalculator";
            this.groupBoxComboCalc.ResumeLayout(false);
            this.groupBoxComboCalc.PerformLayout();
            this.groupBoxRadioButtonCalc.ResumeLayout(false);
            this.groupBoxRadioButtonCalc.PerformLayout();
            this.groupBoxOperator.ResumeLayout(false);
            this.groupBoxOperator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCalc;
        private System.Windows.Forms.Button buttonComboBoxCalculator;
        private System.Windows.Forms.ComboBox comboBoxComboCalc_Operator;
        private System.Windows.Forms.TextBox textBoxComboCalc_Result;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRadioButtonCalc;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonMultipl;
        private System.Windows.Forms.RadioButton radioButtonSubtrac;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button buttonRadioCalculator;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Result;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Oper1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxOperator;
        private System.Windows.Forms.RadioButton radioButtonSquare;
    }
}

