﻿namespace WinFormsAppcalculator
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            Num1 = new TextBox();
            Num2 = new TextBox();
            Result = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(74, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(74, 106);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Num2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(74, 142);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(292, 51);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Num1
            // 
            Num1.ForeColor = SystemColors.ActiveCaption;
            Num1.Location = new Point(145, 52);
            Num1.Name = "Num1";
            Num1.Size = new Size(125, 27);
            Num1.TabIndex = 4;
            // 
            // Num2
            // 
            Num2.ForeColor = SystemColors.ActiveCaption;
            Num2.Location = new Point(145, 99);
            Num2.Name = "Num2";
            Num2.Size = new Size(125, 27);
            Num2.TabIndex = 5;
            // 
            // Result
            // 
            Result.ForeColor = SystemColors.ActiveCaption;
            Result.Location = new Point(145, 142);
            Result.Name = "Result";
            Result.Size = new Size(125, 27);
            Result.TabIndex = 6;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(292, 99);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(292, 142);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ActiveCaption;
            button4.Location = new Point(406, 51);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.ActiveCaption;
            button5.Location = new Point(406, 97);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Result);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox Num1;
        private TextBox Num2;
        private TextBox Result;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
