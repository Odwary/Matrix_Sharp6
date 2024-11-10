using System;
using System.Data;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        int N; // Размерность матрицы

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxN_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBoxN.Text, out N) || N <= 0)
            {
                MessageBox.Show("Введите положительное целое число.");
                return;
            }

            // Установка размера матрицы и DataGridView
            DataTable matr = new DataTable("matr");
            for (int i = 0; i < N; i++)
            {
                matr.Columns.Add(new DataColumn(i.ToString()));
            }
            for (int i = 0; i < N ; i++) 
            {
                matr.Rows.Add(matr.NewRow());
            }

            datGrdViewIn.DataSource = matr;
            foreach (DataGridViewColumn col in datGrdViewIn.Columns)
            {
                col.Width = 50;
            }
        }

        // Обработка матрицы
        private void btnStart_Click(object sender, EventArgs e)
        {
            MatrMake mt = new MatrMake(N);
            mt.GridToMatrix(datGrdViewIn);
            mt.AddMaxRow(); 
            mt.MatrixToGrid(datGrdViewRes);
            datGrdViewRes.Visible = true;
        }
    }
}