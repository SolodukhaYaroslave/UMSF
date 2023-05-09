namespace Sort
{
    partial class TypeSort
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
            this.rbBubble = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rbSelection = new System.Windows.Forms.RadioButton();
            this.rbInsertion = new System.Windows.Forms.RadioButton();
            this.rbCocktail = new System.Windows.Forms.RadioButton();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbShell = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbBubble
            // 
            this.rbBubble.AutoSize = true;
            this.rbBubble.Checked = true;
            this.rbBubble.Location = new System.Drawing.Point(60, 27);
            this.rbBubble.Name = "rbBubble";
            this.rbBubble.Size = new System.Drawing.Size(146, 24);
            this.rbBubble.TabIndex = 0;
            this.rbBubble.TabStop = true;
            this.rbBubble.Text = "Бульбашковий";
            this.rbBubble.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(75, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрити";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSelection
            // 
            this.rbSelection.AutoSize = true;
            this.rbSelection.Location = new System.Drawing.Point(60, 57);
            this.rbSelection.Name = "rbSelection";
            this.rbSelection.Size = new System.Drawing.Size(145, 24);
            this.rbSelection.TabIndex = 2;
            this.rbSelection.Text = "Сорт. вибором";
            this.rbSelection.UseVisualStyleBackColor = true;
            // 
            // rbInsertion
            // 
            this.rbInsertion.AutoSize = true;
            this.rbInsertion.Location = new System.Drawing.Point(61, 87);
            this.rbInsertion.Name = "rbInsertion";
            this.rbInsertion.Size = new System.Drawing.Size(153, 24);
            this.rbInsertion.TabIndex = 3;
            this.rbInsertion.Text = "Сорт. вставкою";
            this.rbInsertion.UseVisualStyleBackColor = true;
            // 
            // rbCocktail
            // 
            this.rbCocktail.AutoSize = true;
            this.rbCocktail.Location = new System.Drawing.Point(60, 117);
            this.rbCocktail.Name = "rbCocktail";
            this.rbCocktail.Size = new System.Drawing.Size(206, 24);
            this.rbCocktail.TabIndex = 4;
            this.rbCocktail.Text = "Сорт. перемішуванням";
            this.rbCocktail.UseVisualStyleBackColor = true;
            // 
            // rbQuick
            // 
            this.rbQuick.AutoSize = true;
            this.rbQuick.Location = new System.Drawing.Point(60, 177);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(184, 24);
            this.rbQuick.TabIndex = 5;
            this.rbQuick.Text = "Швидке сортування\r\n";
            this.rbQuick.UseVisualStyleBackColor = true;
            // 
            // rbShell
            // 
            this.rbShell.AutoSize = true;
            this.rbShell.Location = new System.Drawing.Point(60, 147);
            this.rbShell.Name = "rbShell";
            this.rbShell.Size = new System.Drawing.Size(179, 24);
            this.rbShell.TabIndex = 6;
            this.rbShell.Text = "Сортування Шелла";
            this.rbShell.UseVisualStyleBackColor = true;
            // 
            // TypeSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 284);
            this.ControlBox = false;
            this.Controls.Add(this.rbShell);
            this.Controls.Add(this.rbQuick);
            this.Controls.Add(this.rbCocktail);
            this.Controls.Add(this.rbInsertion);
            this.Controls.Add(this.rbSelection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbBubble);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypeSort";
            this.ShowIcon = false;
            this.Text = "Вид сортування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBubble;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbSelection;
        private System.Windows.Forms.RadioButton rbInsertion;
        private System.Windows.Forms.RadioButton rbCocktail;
        private System.Windows.Forms.RadioButton rbQuick;
        private System.Windows.Forms.RadioButton rbShell;
    }
}