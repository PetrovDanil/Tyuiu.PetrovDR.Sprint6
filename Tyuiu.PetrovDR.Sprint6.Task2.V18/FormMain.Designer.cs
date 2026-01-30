namespace Tyuiu.PetrovDR.Sprint6.Task2.V18
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
            buttonDone_PDR = new Button();
            buttonHelp_PDR = new Button();
            textBoxStopStep_PDR = new TextBox();
            textBoxStartStep_PDR = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Fx = new DataGridViewTextBoxColumn();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(337, 100);
            label1.TabIndex = 0;
            label1.Text = "Протабулировать функцию\r\n ((3*cosX) / (4X - 0,5)) + sinX - 5X - 2\r\nна заданном диапазоне.\r\nРезультат вывести в DataGridView и построить \r\nграфик функции.\r\n";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(buttonDone_PDR);
            groupBox2.Controls.Add(buttonHelp_PDR);
            groupBox2.Controls.Add(textBoxStopStep_PDR);
            groupBox2.Controls.Add(textBoxStartStep_PDR);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 147);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // buttonDone_PDR
            // 
            buttonDone_PDR.BackColor = Color.Aquamarine;
            buttonDone_PDR.Location = new Point(277, 31);
            buttonDone_PDR.Name = "buttonDone_PDR";
            buttonDone_PDR.Size = new Size(138, 50);
            buttonDone_PDR.TabIndex = 5;
            buttonDone_PDR.Text = "Выполнить";
            buttonDone_PDR.UseVisualStyleBackColor = false;
            buttonDone_PDR.Click += buttonDone_PDR_Click;
            // 
            // buttonHelp_PDR
            // 
            buttonHelp_PDR.BackColor = Color.Chartreuse;
            buttonHelp_PDR.Location = new Point(277, 87);
            buttonHelp_PDR.Name = "buttonHelp_PDR";
            buttonHelp_PDR.Size = new Size(138, 50);
            buttonHelp_PDR.TabIndex = 4;
            buttonHelp_PDR.Text = "Справка";
            buttonHelp_PDR.UseVisualStyleBackColor = false;
            buttonHelp_PDR.Click += buttonHelp_PDR_Click;
            // 
            // textBoxStopStep_PDR
            // 
            textBoxStopStep_PDR.Location = new Point(6, 99);
            textBoxStopStep_PDR.Name = "textBoxStopStep_PDR";
            textBoxStopStep_PDR.Size = new Size(125, 27);
            textBoxStopStep_PDR.TabIndex = 3;
            textBoxStopStep_PDR.KeyPress += textBoxStep_PDR_KeyPress;
            // 
            // textBoxStartStep_PDR
            // 
            textBoxStartStep_PDR.Location = new Point(6, 46);
            textBoxStartStep_PDR.Name = "textBoxStartStep_PDR";
            textBoxStartStep_PDR.Size = new Size(125, 27);
            textBoxStartStep_PDR.TabIndex = 2;
            textBoxStartStep_PDR.KeyPress += textBoxStep_PDR_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 1;
            label3.Text = "Конец шага:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Старт шага:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(dataGridViewFunction);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(439, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(683, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Fx });
            dataGridViewFunction.Location = new Point(3, 23);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(300, 188);
            dataGridViewFunction.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // Fx
            // 
            Fx.HeaderText = "F(X)";
            Fx.MinimumWidth = 6;
            Fx.Name = "Fx";
            Fx.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 1;
            label4.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 26 | Петров Д.Р.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Button buttonDone_PDR;
        private Button buttonHelp_PDR;
        private TextBox textBoxStopStep_PDR;
        private TextBox textBoxStartStep_PDR;
        private Label label4;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Fx;
    }
}
