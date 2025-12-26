using Tyuiu.PetrovDR.Sprint6.Task0.V23.Lib;

namespace Tyuiu.PetrovDR.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_PDR_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_PDR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_PDR.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_PDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_PDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент  группы РППб-25-1 Петров Данил Романович", "Сообщение");
        }
    }
}
