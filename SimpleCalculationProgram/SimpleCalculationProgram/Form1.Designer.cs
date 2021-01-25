
namespace SimpleCalculationProgram
{
    partial class Parse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input1TextBox = new System.Windows.Forms.TextBox();
            this.PlusLabel = new System.Windows.Forms.Label();
            this.Input2TextBox = new System.Windows.Forms.TextBox();
            this.EqualLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.CalcButtan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input1TextBox
            // 
            this.Input1TextBox.Location = new System.Drawing.Point(12, 28);
            this.Input1TextBox.Name = "Input1TextBox";
            this.Input1TextBox.Size = new System.Drawing.Size(100, 23);
            this.Input1TextBox.TabIndex = 0;

            // 
            // PlusLabel
            // 
            this.PlusLabel.AutoSize = true;
            this.PlusLabel.Location = new System.Drawing.Point(118, 31);
            this.PlusLabel.Name = "PlusLabel";
            this.PlusLabel.Size = new System.Drawing.Size(19, 15);
            this.PlusLabel.TabIndex = 1;
            this.PlusLabel.Text = "＋";
            // 
            // Input2TextBox
            // 
            this.Input2TextBox.Location = new System.Drawing.Point(143, 28);
            this.Input2TextBox.Name = "Input2TextBox";
            this.Input2TextBox.Size = new System.Drawing.Size(100, 23);
            this.Input2TextBox.TabIndex = 2;
            // 
            // EqualLabel
            // 
            this.EqualLabel.AutoSize = true;
            this.EqualLabel.Location = new System.Drawing.Point(249, 34);
            this.EqualLabel.Name = "EqualLabel";
            this.EqualLabel.Size = new System.Drawing.Size(15, 15);
            this.EqualLabel.TabIndex = 3;
            this.EqualLabel.Text = "=";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(270, 28);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(100, 23);
            this.AnswerTextBox.TabIndex = 4;
            // 
            // CalcButtan
            // 
            this.CalcButtan.Location = new System.Drawing.Point(12, 70);
            this.CalcButtan.Name = "CalcButtan";
            this.CalcButtan.Size = new System.Drawing.Size(358, 23);
            this.CalcButtan.TabIndex = 5;
            this.CalcButtan.Text = "計算する";
            this.CalcButtan.UseVisualStyleBackColor = true;
            this.CalcButtan.Click += new System.EventHandler(this.CalcButtan_Click);
            // 
            // Parse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcButtan);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.EqualLabel);
            this.Controls.Add(this.Input2TextBox);
            this.Controls.Add(this.PlusLabel);
            this.Controls.Add(this.Input1TextBox);
            this.Name = "Parse";
            this.Text = "簡単計算プログラム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1TextBox;
        private System.Windows.Forms.Label PlusLabel;
        private System.Windows.Forms.TextBox Input2TextBox;
        private System.Windows.Forms.Label EqualLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button CalcButtan;
    }
}

