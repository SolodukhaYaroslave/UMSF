using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    public partial class Sort : Form
    {
        TypeSort typeSort;
        AllTypeSort Ats = new AllTypeSort();
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
            char[] MyArray = new char[dgvMass.Rows[0].Cells.Count];
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = char.Parse((string)dgvMass.Rows[0].Cells[i].Value);
            }
            DateTime currentTime = DateTime.Now;
            if (((RadioButton)typeSort.Controls["rbBubble"]).Checked) { MyArray = Ats.Bubble_Sort(MyArray); }
            else if (((RadioButton)typeSort.Controls["rbSelection"]).Checked) { MyArray = Ats.Selection_Sort(MyArray); }
            else if (((RadioButton)typeSort.Controls["rbInsertion"]).Checked) { MyArray = Ats.Insertion_Sort(MyArray); }
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
        }
    }
}
