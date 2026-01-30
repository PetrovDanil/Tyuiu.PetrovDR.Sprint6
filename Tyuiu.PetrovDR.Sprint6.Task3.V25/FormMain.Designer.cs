namespace Tyuiu.PetrovDR.Sprint6.Task3.V25
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
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            dataGridViewResult_PDR = new DataGridView();
            dataGridViewStart_PDR = new DataGridView();
            buttonHelp_PDR = new Button();
            buttonDone_PDR = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PDR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStart_PDR).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(386, 40);
            label1.TabIndex = 0;
            label1.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку \r\nпо возрастанию в третьем столбце.";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dataGridViewResult_PDR);
            groupBox3.Controls.Add(dataGridViewStart_PDR);
            groupBox3.Controls.Add(buttonHelp_PDR);
            groupBox3.Controls.Add(buttonDone_PDR);
            groupBox3.Location = new Point(448, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(843, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(552, 29);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 5;
            label4.Text = "Результат";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 1;
            label3.Text = "Изначальная матрица";
            // 
            // dataGridViewResult_PDR
            // 
            dataGridViewResult_PDR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PDR.ColumnHeadersVisible = false;
            dataGridViewResult_PDR.Location = new Point(552, 52);
            dataGridViewResult_PDR.Name = "dataGridViewResult_PDR";
            dataGridViewResult_PDR.RowHeadersVisible = false;
            dataGridViewResult_PDR.RowHeadersWidth = 51;
            dataGridViewResult_PDR.Size = new Size(285, 220);
            dataGridViewResult_PDR.TabIndex = 4;
            // 
            // dataGridViewStart_PDR
            // 
            dataGridViewStart_PDR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStart_PDR.ColumnHeadersVisible = false;
            dataGridViewStart_PDR.Location = new Point(6, 52);
            dataGridViewStart_PDR.Name = "dataGridViewStart_PDR";
            dataGridViewStart_PDR.RowHeadersVisible = false;
            dataGridViewStart_PDR.RowHeadersWidth = 51;
            dataGridViewStart_PDR.Size = new Size(285, 217);
            dataGridViewStart_PDR.TabIndex = 3;
            // 
            // buttonHelp_PDR
            // 
            buttonHelp_PDR.BackColor = SystemColors.ButtonFace;
            buttonHelp_PDR.Location = new Point(678, 391);
            buttonHelp_PDR.Name = "buttonHelp_PDR";
            buttonHelp_PDR.Size = new Size(36, 29);
            buttonHelp_PDR.TabIndex = 1;
            buttonHelp_PDR.Text = "?";
            buttonHelp_PDR.UseVisualStyleBackColor = false;
            buttonHelp_PDR.Click += buttonHelp_PDR_Click;
            // 
            // buttonDone_PDR
            // 
            buttonDone_PDR.BackColor = SystemColors.ButtonFace;
            buttonDone_PDR.Location = new Point(720, 391);
            buttonDone_PDR.Name = "buttonDone_PDR";
            buttonDone_PDR.Size = new Size(117, 29);
            buttonDone_PDR.TabIndex = 0;
            buttonDone_PDR.Text = "Выполнить";
            buttonDone_PDR.UseVisualStyleBackColor = false;
            buttonDone_PDR.Click += buttonDone_PDR_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 26 | Петров Д.Р.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PDR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStart_PDR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label1;
        private Button buttonHelp_PDR;
        private Button buttonDone_PDR;
        private Label label2;
        private TextBox textBoxResult_PDR;
        private DataGridView dataGridViewStart_PDR;
        private DataGridView dataGridViewResult_PDR;
        private Label label4;
        private Label label3;
    }
}
