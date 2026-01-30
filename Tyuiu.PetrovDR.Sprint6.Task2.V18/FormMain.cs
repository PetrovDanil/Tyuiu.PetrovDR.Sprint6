using Tyuiu.PetrovDR.Sprint6.Task2.V18.Lib;

namespace Tyuiu.PetrovDR.Sprint6.Task2.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonHelp_PDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППб-25-1 Петров Данил Романович", "Сообщение");
        }

        private void textBoxStep_PDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_PDR_Click(object sender, EventArgs e)
        {
            int StartStep = Convert.ToInt32(textBoxStartStep_PDR.Text);
            int StopStep = Convert.ToInt32(textBoxStopStep_PDR.Text);

            int len = ds.GetMassFunction(StartStep, StopStep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(StartStep, StopStep);

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewFunction.Rows.Add(Convert.ToString(StartStep), Convert.ToString(valueArray[i]));
                StartStep++;
            }
        }

    }
}
