namespace Tyuiu.PetrovDR.Sprint6.Task1.V26
{
    partial class FormMain
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonHelp_PDR = new Button();
            buttonDone_PDR = new Button();
            textBoxStopValue_PDR = new TextBox();
            textBoxStartValue_PDR = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            textBoxResult_PDR = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(259, 100);
            label1.TabIndex = 0;
            label1.Text = "Протабулировать функцию\r\n( (2*cosX+2) / (2x-1) ) + cosX - 5X + 3\r\nна заданном диапазоне.\r\n\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(buttonHelp_PDR);
            groupBox2.Controls.Add(buttonDone_PDR);
            groupBox2.Controls.Add(textBoxStopValue_PDR);
            groupBox2.Controls.Add(textBoxStartValue_PDR);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 112);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // buttonHelp_PDR
            // 
            buttonHelp_PDR.BackColor = Color.Chartreuse;
            buttonHelp_PDR.Location = new Point(349, 33);
            buttonHelp_PDR.Name = "buttonHelp_PDR";
            buttonHelp_PDR.Size = new Size(49, 50);
            buttonHelp_PDR.TabIndex = 4;
            buttonHelp_PDR.Text = "?";
            buttonHelp_PDR.UseVisualStyleBackColor = false;
            buttonHelp_PDR.Click += buttonHelp_PDR_Click;
            // 
            // buttonDone_PDR
            // 
            buttonDone_PDR.BackColor = Color.Cyan;
            buttonDone_PDR.Location = new Point(404, 33);
            buttonDone_PDR.Name = "buttonDone_PDR";
            buttonDone_PDR.Size = new Size(100, 50);
            buttonDone_PDR.TabIndex = 0;
            buttonDone_PDR.Text = "Выполнить";
            buttonDone_PDR.UseVisualStyleBackColor = false;
            buttonDone_PDR.Click += buttonDone_PDR_Click;
            // 
            // textBoxStopValue_PDR
            // 
            textBoxStopValue_PDR.Location = new Point(160, 56);
            textBoxStopValue_PDR.Name = "textBoxStopValue_PDR";
            textBoxStopValue_PDR.Size = new Size(125, 27);
            textBoxStopValue_PDR.TabIndex = 3;
            // 
            // textBoxStartValue_PDR
            // 
            textBoxStartValue_PDR.Location = new Point(6, 56);
            textBoxStartValue_PDR.Name = "textBoxStartValue_PDR";
            textBoxStartValue_PDR.Size = new Size(125, 27);
            textBoxStartValue_PDR.TabIndex = 2;
            textBoxStartValue_PDR.KeyPress += textBoxStartValue_PDR_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 33);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 1;
            label3.Text = "Конец шага:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Старт шага:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(textBoxResult_PDR);
            groupBox3.Location = new Point(528, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 416);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult_PDR
            // 
            textBoxResult_PDR.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_PDR.Location = new Point(6, 26);
            textBoxResult_PDR.Multiline = true;
            textBoxResult_PDR.Name = "textBoxResult_PDR";
            textBoxResult_PDR.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PDR.Size = new Size(248, 384);
            textBoxResult_PDR.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Петров Д.Р.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBoxStopValue_PDR;
        private TextBox textBoxStartValue_PDR;
        private Label label3;
        private Label label2;
        private Button buttonHelp_PDR;
        private Button buttonDone_PDR;
        private GroupBox groupBox3;
        private TextBox textBoxResult_PDR;
    }
}
