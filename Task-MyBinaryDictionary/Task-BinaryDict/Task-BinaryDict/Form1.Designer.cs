namespace Task_BinaryDict
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listboxKey = new System.Windows.Forms.ListBox();
            this.listBoxValue = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxValueRemove = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValueByKey = new System.Windows.Forms.Button();
            this.tbxValueByKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKeyByValue = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 108);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 65);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listboxKey
            // 
            this.listboxKey.FormattingEnabled = true;
            this.listboxKey.ItemHeight = 16;
            this.listboxKey.Location = new System.Drawing.Point(643, 49);
            this.listboxKey.Name = "listboxKey";
            this.listboxKey.Size = new System.Drawing.Size(120, 244);
            this.listboxKey.TabIndex = 13;
            // 
            // listBoxValue
            // 
            this.listBoxValue.FormattingEnabled = true;
            this.listBoxValue.ItemHeight = 16;
            this.listBoxValue.Location = new System.Drawing.Point(800, 49);
            this.listBoxValue.Name = "listBoxValue";
            this.listBoxValue.Size = new System.Drawing.Size(120, 244);
            this.listBoxValue.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Значение";
            // 
            // tbxKey
            // 
            this.tbxKey.Location = new System.Drawing.Point(198, 48);
            this.tbxKey.Multiline = true;
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(136, 31);
            this.tbxKey.TabIndex = 17;
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(356, 48);
            this.tbxValue.Multiline = true;
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(136, 31);
            this.tbxValue.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Значение";
            // 
            // tbxValueRemove
            // 
            this.tbxValueRemove.Location = new System.Drawing.Point(198, 129);
            this.tbxValueRemove.Multiline = true;
            this.tbxValueRemove.Name = "tbxValueRemove";
            this.tbxValueRemove.Size = new System.Drawing.Size(136, 31);
            this.tbxValueRemove.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Значение";
            // 
            // btnValueByKey
            // 
            this.btnValueByKey.Location = new System.Drawing.Point(12, 189);
            this.btnValueByKey.Name = "btnValueByKey";
            this.btnValueByKey.Size = new System.Drawing.Size(167, 65);
            this.btnValueByKey.TabIndex = 23;
            this.btnValueByKey.Text = "Полчуить значение по ключу";
            this.btnValueByKey.UseVisualStyleBackColor = true;
            this.btnValueByKey.Click += new System.EventHandler(this.btnValueByKey_Click);
            // 
            // tbxValueByKey
            // 
            this.tbxValueByKey.Location = new System.Drawing.Point(198, 201);
            this.tbxValueByKey.Multiline = true;
            this.tbxValueByKey.Name = "tbxValueByKey";
            this.tbxValueByKey.Size = new System.Drawing.Size(136, 31);
            this.tbxValueByKey.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ключ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 201);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 31);
            this.textBox2.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Значение";
            // 
            // btnKeyByValue
            // 
            this.btnKeyByValue.Location = new System.Drawing.Point(12, 269);
            this.btnKeyByValue.Name = "btnKeyByValue";
            this.btnKeyByValue.Size = new System.Drawing.Size(167, 65);
            this.btnKeyByValue.TabIndex = 28;
            this.btnKeyByValue.Text = "Получить ключ по значение";
            this.btnKeyByValue.UseVisualStyleBackColor = true;
            this.btnKeyByValue.Click += new System.EventHandler(this.btnKeyByValue_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(198, 290);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 31);
            this.textBox3.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Значение";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(356, 290);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 31);
            this.textBox4.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ключ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 65);
            this.button1.TabIndex = 33;
            this.button1.Text = "ContainsKey";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 377);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 31);
            this.textBox1.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ключ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "нет";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 65);
            this.button2.TabIndex = 37;
            this.button2.Text = "ContainsValue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(198, 461);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 31);
            this.textBox5.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Значение";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(364, 464);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "нет";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 65);
            this.button3.TabIndex = 41;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 593);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnKeyByValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxValueByKey);
            this.Controls.Add(this.btnValueByKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxValueRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxValue);
            this.Controls.Add(this.listboxKey);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listboxKey;
        private System.Windows.Forms.ListBox listBoxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxValueRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValueByKey;
        private System.Windows.Forms.TextBox tbxValueByKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKeyByValue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
    }
}

