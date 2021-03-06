﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculationProgram
{

    public partial class Parse : Form
    {

        public Parse()
        {
            InitializeComponent();
        }

        private void CalcButtan_Click(object sender, EventArgs e)
        {
            //変数の宣言
            int valueLeft;
            int valueRight;
            int valueAnswer;
            //値の取り込み
            valueLeft = InputCheck(Input1TextBox.Text, out valueLeft);
            valueRight = InputCheck(Input2TextBox.Text, out valueRight);
            //取り込んだ値の計算
            valueAnswer = valueLeft + valueRight;
            //計算結果の出力
            AnswerTextBox.Text = valueAnswer.ToString();
        }

        private int InputCheck(string textValue, out int value)
        {
            if (int.TryParse(textValue, out value) == true)
            {
                value = int.Parse(textValue);
            }
            else
            {
                value = 0;
            }
            return value;
        }
    }
}
