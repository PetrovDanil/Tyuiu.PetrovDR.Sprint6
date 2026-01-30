using Tyuiu.PetrovDR.Sprint6.Task3.V25.Lib;

namespace Tyuiu.PetrovDR.Sprint6.Task3.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = {     {14, 5, -9, 18, 21 },
                              {-5, -12, -12, 4, 28 },
                              {27, -2, -14, 23, 27 },
                              {-19, -15, 17, 15, 1 },
                              {33, 2, 6, 24, 24 } };

        private void buttonHelp_PDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППб-25-1 Петров Данил Романович", "Сообщение");
        }

        private void buttonDone_PDR_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridViewResult_PDR.RowCount = rows;
            dataGridViewResult_PDR.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewResult_PDR.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_PDR.Rows[i].Cells[j].Value = mtrx[i, j].ToString();
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewStart_PDR.RowCount = rows;
            dataGridViewStart_PDR.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewStart_PDR.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewStart_PDR.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }
    }
}
