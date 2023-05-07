namespace Sort
{
    partial class Sort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDGV = new System.Windows.Forms.CheckBox();
            this.bRandomArray = new System.Windows.Forms.Button();
            this.bEmptyArray = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.bType = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDGV);
            this.groupBox1.Controls.Add(this.bRandomArray);
            this.groupBox1.Controls.Add(this.bEmptyArray);
            this.groupBox1.Controls.Add(this.tbNum);
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерація масива";
            // 
            // cbDGV
            // 
            this.cbDGV.AutoSize = true;
            this.cbDGV.Checked = true;
            this.cbDGV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDGV.Location = new System.Drawing.Point(10, 169);
            this.cbDGV.Name = "cbDGV";
            this.cbDGV.Size = new System.Drawing.Size(116, 24);
            this.cbDGV.TabIndex = 5;
            this.cbDGV.Text = "Using DGV";
            this.cbDGV.UseVisualStyleBackColor = true;
            // 
            // bRandomArray
            // 
            this.bRandomArray.Location = new System.Drawing.Point(543, 160);
            this.bRandomArray.Name = "bRandomArray";
            this.bRandomArray.Size = new System.Drawing.Size(263, 33);
            this.bRandomArray.TabIndex = 4;
            this.bRandomArray.Text = "Заповнити масив";
            this.bRandomArray.UseVisualStyleBackColor = true;
            this.bRandomArray.Click += new System.EventHandler(this.bRandomArray_Click);
            // 
            // bEmptyArray
            // 
            this.bEmptyArray.Location = new System.Drawing.Point(202, 160);
            this.bEmptyArray.Name = "bEmptyArray";
            this.bEmptyArray.Size = new System.Drawing.Size(263, 33);
            this.bEmptyArray.TabIndex = 3;
            this.bEmptyArray.Text = "Згенерувати порожній массив";
            this.bEmptyArray.UseVisualStyleBackColor = true;
            this.bEmptyArray.Click += new System.EventHandler(this.bEmptyArray_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(72, 70);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(96, 26);
            this.tbNum.TabIndex = 1;
            this.tbNum.Text = "10";
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.ColumnHeadersVisible = false;
            this.dgvMass.Location = new System.Drawing.Point(191, 16);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 20;
            this.dgvMass.RowTemplate.Height = 28;
            this.dgvMass.Size = new System.Drawing.Size(620, 129);
            this.dgvMass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кількість елементів масиву";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "\"Бульбашкове\" сортування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Відсортований масив";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(177, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(629, 119);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 142);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сортування";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sort_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(627, 418);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(176, 42);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bType
            // 
            this.bType.Location = new System.Drawing.Point(394, 418);
            this.bType.Name = "bType";
            this.bType.Size = new System.Drawing.Size(176, 42);
            this.bType.TabIndex = 3;
            this.bType.Text = "Вид сортування";
            this.bType.UseVisualStyleBackColor = true;
            this.bType.Click += new System.EventHandler(this.bType_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(8, 429);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(129, 20);
            this.lab.TabIndex = 4;
            this.lab.Text = "Час сортування";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(143, 429);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(18, 20);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "0";
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 472);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.bType);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sort";
            this.Text = "Сортирування";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bRandomArray;
        private System.Windows.Forms.Button bEmptyArray;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bType;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.CheckBox cbDGV;
    }
}

