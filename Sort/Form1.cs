using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    public partial class Sort : Form
    {
        AllTypeSort ATS = new AllTypeSort();
        TypeSort typeSort;
        public int numSort;
        public Sort()
        {
            InitializeComponent();
            typeSort = new TypeSort();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bEmptyArray_Click(object sender, EventArgs e)
        {
            if (tbNum.Text == "")
            {
                MessageBox.Show("Введіть кількість елиментів", "Error");
            }
            else
            {
                int num = 0;
                try
                {
                    num = Int32.Parse(tbNum.Text);
                    dgvMass.ColumnCount = num;
                    for (int i = 0; i < num; i++)
                    {
                        dgvMass.RowHeadersWidth = 4;
                        dgvMass.Columns[i].Width = 40;
                    }
                }
                catch (System.InvalidOperationException) { MessageBox.Show("Значення кількості \nелиментів перебільшує можливе", "Error"); dgvMass.ColumnCount = 655; }
                catch { MessageBox.Show("Значення кількості \nелиментів не вірне", "Error"); }

            }
        }

        private void bRandomArray_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            if (dgvMass.ColumnCount == 0) bEmptyArray_Click(sender, e);
            for (int i = 0; i < dgvMass.ColumnCount; i++)
            {
                int a = ran.Next(3);
                if(a == 1)
                dgvMass.Rows[0].Cells[i].Value = ((char)ran.Next(48, 58)).ToString();
                else if (a == 2)
                    dgvMass.Rows[0].Cells[i].Value = ((char)ran.Next(97, 123)).ToString();
                else
                    dgvMass.Rows[0].Cells[i].Value = ((char)ran.Next(65, 91)).ToString();
            }
        }

        private void sort_Click(object sender, EventArgs e)
        {
            if (dgvMass.Rows.Count == 0) bRandomArray_Click(sender, e);
            char[] MyArray = new char[dgvMass.Rows[0].Cells.Count];
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = char.Parse((string)dgvMass.Rows[0].Cells[i].Value);
            }
            try { numSort = typeSort.numRes(); }
            catch { numSort = 0; }

            DateTime currentTime = DateTime.MinValue;
            switch (numSort)
            {
                case 0:
                    currentTime = DateTime.Now;
                    MyArray = ATS.Bubble_Sort(MyArray);
                    break;
                case 1:
                    currentTime = DateTime.Now;
                    MyArray = ATS.Selection_Sort(MyArray);
                    break;
                case 2:
                    currentTime = DateTime.Now;
                    MyArray = ATS.Insertion_Sort(MyArray);
                    break;
                case 3:
                    currentTime = DateTime.Now;
                    MyArray = ATS.Cocktail_Sort(MyArray);
                    break;
            }
            labTime.Text = (DateTime.Now - currentTime).ToString();

                richTextBox1.Clear();
            for (int i = 0; i < MyArray.Length; i++)
            {
                richTextBox1.Text += MyArray[i] + " ";
            }
        }
        

        private void bType_Click(object sender, EventArgs e)
        {
            typeSort.Show();
            typeSort.Activate();
        }
    }
}
