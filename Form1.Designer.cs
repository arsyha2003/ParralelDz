namespace ParralelDz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(428, 242);
            button1.Name = "button1";
            button1.Size = new Size(419, 95);
            button1.TabIndex = 0;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartButtonEvent;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 426);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(428, 343);
            button2.Name = "button2";
            button2.Size = new Size(419, 95);
            button2.TabIndex = 2;
            button2.Text = "Стоп";
            button2.UseVisualStyleBackColor = true;
            button2.Click += StopButtonEvent;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(437, 14);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(287, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Посчитать количество предложений";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(437, 44);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(408, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Посчитать количество вопросительных предложений";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(437, 74);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(421, 24);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Посчитать количество восклицаательных предложений";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(437, 104);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(222, 24);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Посчитать количество слов";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(437, 134);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(259, 24);
            checkBox5.TabIndex = 8;
            checkBox5.Text = "Посчитать количество символов";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
    }
}
