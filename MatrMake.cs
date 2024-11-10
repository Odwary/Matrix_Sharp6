using System;
using System.Windows.Forms;
using System.Data;

namespace Task_6
{
    class MatrMake
    {
        int n_str, // количество строк
            n_col; // количество столбцов
        int[,] matrix; // обрабатываемая матрица

        public MatrMake(int n)
        {
            n_str = n; // на входе матрица квадратная
            n_col = n;
            matrix = new int[n + 1, n];
        }

        // Заполнение матрицы из DataGridView
        public void GridToMatrix(DataGridView dgv)
        {
            DataGridViewCell txtCell;
            for (int i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    if (s == "")
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = Int32.Parse(s);
                }
            }
        }

        // Вывод матрицы в DataGridView
        public void MatrixToGrid(DataGridView dgv)
        {
            // Установка размеров
            int i;
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[n_col];
            for (i = 0; i < n_col; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            for (i = 0; i <= n_str; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            dgv.DataSource = matr;
            for (i = 0; i < n_col; i++)
                dgv.Columns[i].Width = 50;

            // Занесение значений
            DataGridViewCell txtCell;
            for (i = 0; i <= n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    txtCell.Value = matrix[i, j].ToString();
                }
            }
        }

        // Добавление строки с максимумами каждой строки
        public void AddMaxRow()
        {
            for (int i = 0; i < n_str; i++)
            {
                int max = matrix[i, 0];
                for (int j = 1; j < n_col; j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
                matrix[n_str, i] = max; 
            }
        }
    }
}