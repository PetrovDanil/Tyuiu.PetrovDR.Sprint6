namespace Tyuiu.PetrovDR.Sprint6.Task0.V23
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
            textBoxVarX_PDR = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxResult_PDR = new TextBox();
            buttonDone_PDR = new Button();
            buttonHelp_PDR = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(260, 40);
            label1.TabIndex = 0;
            label1.Text = "Вычислить выражение по формуле:\r\ny = ln((x + 1)/(x + 2))\r\n";
            // 
            // textBoxVarX_PDR
            // 
            textBoxVarX_PDR.Location = new Point(12, 390);
            textBoxVarX_PDR.Name = "textBoxVarX_PDR";
            textBoxVarX_PDR.Size = new Size(125, 27);
            textBoxVarX_PDR.TabIndex = 1;
            textBoxVarX_PDR.KeyPress += textBoxVarX_PDR_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 354);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите Х:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 354);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Результат:";
            // 
            // textBoxResult_PDR
            // 
            textBoxResult_PDR.Location = new Point(241, 390);
            textBoxResult_PDR.Name = "textBoxResult_PDR";
            textBoxResult_PDR.Size = new Size(125, 27);
            textBoxResult_PDR.TabIndex = 4;
            // 
            // buttonDone_PDR
            // 
            buttonDone_PDR.BackColor = SystemColors.MenuHighlight;
            buttonDone_PDR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDone_PDR.Location = new Point(633, 369);
            buttonDone_PDR.Name = "buttonDone_PDR";
            buttonDone_PDR.Size = new Size(155, 48);
            buttonDone_PDR.TabIndex = 5;
            buttonDone_PDR.Text = "Вычислить";
            buttonDone_PDR.UseVisualStyleBackColor = false;
            buttonDone_PDR.Click += buttonDone_PDR_Click;
            // 
            // buttonHelp_PDR
            // 
            buttonHelp_PDR.BackColor = Color.Chartreuse;
            buttonHelp_PDR.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_PDR.Location = new Point(580, 369);
            buttonHelp_PDR.Name = "buttonHelp_PDR";
            buttonHelp_PDR.Size = new Size(47, 48);
            buttonHelp_PDR.TabIndex = 6;
            buttonHelp_PDR.Text = "?";
            buttonHelp_PDR.UseVisualStyleBackColor = false;
            buttonHelp_PDR.Click += buttonHelp_PDR_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_PDR);
            Controls.Add(buttonDone_PDR);
            Controls.Add(textBoxResult_PDR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxVarX_PDR);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxVarX_PDR;
        private Label label2;
        private Label label3;
        private TextBox textBoxResult_PDR;
        private Button buttonDone_PDR;
        private Button buttonHelp_PDR;
    }
}
