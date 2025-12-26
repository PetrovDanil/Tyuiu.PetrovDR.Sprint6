using Tyuiu.PetrovDR.Sprint6.Task1.V26.Lib;

namespace Tyuiu.PetrovDR.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_PDR_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStartValue_PDR.Text);
                int StopStep = Convert.ToInt32(textBoxStopValue_PDR.Text);

                string strLine;

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartStep, StopStep);
                textBoxResult_PDR.Text = "";
                textBoxResult_PDR.AppendText("+---------------------+" + Environment.NewLine);
                textBoxResult_PDR.AppendText("|     X      |     f(x)    |" + Environment.NewLine);
                textBoxResult_PDR.AppendText("+----------------------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1, 5:f2}   |", StartStep, valueArray[i]);
                    textBoxResult_PDR.AppendText(strLine + Environment.NewLine);
                    StartStep++;
                }

                textBoxResult_PDR.AppendText("+----------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент  группы РППб-25-1 Петров Данил Романович", "Сообщение");
        }

        private void textBoxStartValue_PDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }
    }
}
