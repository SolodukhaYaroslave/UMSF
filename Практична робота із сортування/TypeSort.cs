using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    public partial class TypeSort : Form
    {
        public TypeSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }

    public int numRes()
        {
            int num = 0;
            if (rbBubble.Checked) { num = 0; }
            else if (rbSelection.Checked) { num = 1; }
            else if (rbInsertion.Checked) { num = 2; }
            else if (rbCocktail.Checked) { num = 3; }
            else if (rbQuick.Checked) { num = 4; }
            else if (rbShell.Checked) { num = 5; }
            return num;
        }
    }
}
