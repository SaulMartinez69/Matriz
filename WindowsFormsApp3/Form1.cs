using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        public Form1()
        {
            InitializeComponent();
            DisplayMatrix();
        }
        private void DisplayMatrix()
        {
            textBox1.Multiline = true;
            textBox1.ReadOnly = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    textBox1.AppendText(matrix[row, col] + "\t");
                }
                textBox1.AppendText(Environment.NewLine);
            }
        }
    }
}