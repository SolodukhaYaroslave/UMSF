using System;
using System.Windows.Forms;

namespace Sort
{
    public partial class Sort : Form
    {
        AllTypeSort ATS = new AllTypeSort();
        TypeSort typeSort;
        public int numSort;
        public char[] BigChArray = new char[0];
        public int time = 0;
        public Sort()
        {
            InitializeComponent();
            typeSort = new TypeSort();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>Створення порожніх ячейок в DataGridView</summary>
        private void bEmptyArray_Click(object sender, EventArgs e)
        {
            //Превірка на порожність текстового поля 
            if (tbNum.Text == "")
            {
                MessageBox.Show("Введіть кількість елиментів", "Error");
            }
            else
            {
                try
                {
                    int size = Int32.Parse(tbNum.Text);
                    if (cbDGV.Checked)
                    {
                        dgvMass.ColumnCount = size;
                        for (int i = 0; i < size; i++)
                        {
                            dgvMass.RowHeadersWidth = 4;
                            dgvMass.Columns[i].Width = 40;
                        }
                    }
                    else { BigChArray = new char[size]; }
                }
                catch (System.InvalidOperationException) { MessageBox.Show("Значення кількості \nелиментів перебільшує можливе", "Error"); dgvMass.ColumnCount = 655; }
                catch { MessageBox.Show("Значення кількості \nелиментів не вірне", "Error"); }

            }
        }


        /// <summary>Метод для заповнення випадекових значень для порожніх клітиеок DataGridView</summary>
        private void bRandomArray_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            if (cbDGV.Checked && dgvMass.ColumnCount == 0 || !cbDGV.Checked && BigChArray.Length == 0) 
                bEmptyArray_Click(sender, e);
            if (cbDGV.Checked)
                for (int i = 0; i < dgvMass.ColumnCount; i++)
                {
                    int a = ran.Next(3);
                    if (a == 1)
                        dgvMass.Rows[0].Cells[i].Value = ((char)ran.Next(48, 58)).ToString();
                    else if (a == 2)
                        dgvMass.Rows[0].Cells[i].Value = ((char)ran.Next(97, 123)).ToString();
                    else
                        dgvMass.Rows[0].Cells[i].Value = ((char)ran.Next(65, 91)).ToString();
                }
            else
                for (int i = 0; i < BigChArray.Length; i++)
                {
                    int a = ran.Next(3);
                    if (a == 1)
                        BigChArray[i] = (char)ran.Next(48, 58);
                    else if (a == 2)
                        BigChArray[i] = (char)ran.Next(97, 123);
                    else
                        BigChArray[i] = (char)ran.Next(65, 91);
                }
        }


        /// <summary>Методдля сортування значень рядку DataGridView</summary>
        private void sort_Click(object sender, EventArgs e)
        {
            //Перевірка на  порожність DataGridView
            if (cbDGV.Checked && dgvMass.ColumnCount == 0 || !cbDGV.Checked && BigChArray.Length == 0) bRandomArray_Click(sender, e);

            //Претворяння рядку DGV на масив символів
            char[] MyArray = new char[cbDGV.Checked ? dgvMass.ColumnCount : BigChArray.Length];
            if (cbDGV.Checked)
                for (int i = 0; i < MyArray.Length; i++)
                {
                    MyArray[i] = char.Parse((string)dgvMass.Rows[0].Cells[i].Value);
                }
            else
                Array.Copy(BigChArray, MyArray, BigChArray.Length);

            //Запрошення виду сортування із форми 2: TypeSort.cs
            try { numSort = typeSort.numRes(); }
            catch { numSort = 0; }

            //Створення твймеру та розпорядження ма методи класу AllTypeSort відповідно до значення numSort
            DateTime currentTime = DateTime.MaxValue;
            switch (numSort)
            {
                case 0:
                    //Бульбашкове сортування
                    currentTime = DateTime.Now;
                    MyArray = ATS.Bubble_Sort(MyArray);
                    break;
                case 1:
                    //Сортування вибором
                    currentTime = DateTime.Now;
                    MyArray = ATS.Selection_Sort(MyArray);
                    break;
                case 2:
                    //Вставне сортування
                    currentTime = DateTime.Now;
                    MyArray = ATS.Insertion_Sort(MyArray);
                    break;
                case 3:
                    //Сортування пермішанням
                    currentTime = DateTime.Now;
                    MyArray = ATS.Cocktail_Sort(MyArray);
                    break;
                case 4:
                    //Швидке сортування
                    currentTime = DateTime.Now;
                    ATS.Quick_Sort(ref MyArray, 0, MyArray.Length -1);
                    break;
            }
            labTime.Text = ((DateTime.Now - currentTime).TotalMilliseconds).ToString(); //Вирахування та виведення часу сортування

            //Виведення відсортованого масиву символів у richTextBox
            richTextBox1.Clear();
            for (int i = 0; i < MyArray.Length; i++)
            {
                richTextBox1.Text += MyArray[i] + "\v ";
            }
        }


        /// <summary>Метод для показу та активацію форми TypeSort</summary>
        private void bType_Click(object sender, EventArgs e)
        {
            typeSort.Show();
            typeSort.Activate();
        }
    }
}
