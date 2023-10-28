namespace MyQuereTask
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
            this.items = new System.Windows.Forms.ListBox();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.tbxAddItem = new System.Windows.Forms.TextBox();
            this.tbxdeleteItem = new System.Windows.Forms.TextBox();
            this.tbxGetItem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.FormattingEnabled = true;
            this.items.ItemHeight = 16;
            this.items.Location = new System.Drawing.Point(450, 12);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(155, 132);
            this.items.TabIndex = 0;
            // 
            // tbxCount
            // 
            this.tbxCount.Location = new System.Drawing.Point(113, 12);
            this.tbxCount.Multiline = true;
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(124, 29);
            this.tbxCount.TabIndex = 1;
            // 
            // tbxAddItem
            // 
            this.tbxAddItem.Location = new System.Drawing.Point(113, 74);
            this.tbxAddItem.Multiline = true;
            this.tbxAddItem.Name = "tbxAddItem";
            this.tbxAddItem.Size = new System.Drawing.Size(124, 29);
            this.tbxAddItem.TabIndex = 2;
            // 
            // tbxdeleteItem
            // 
            this.tbxdeleteItem.Location = new System.Drawing.Point(113, 137);
            this.tbxdeleteItem.Multiline = true;
            this.tbxdeleteItem.Name = "tbxdeleteItem";
            this.tbxdeleteItem.Size = new System.Drawing.Size(124, 29);
            this.tbxdeleteItem.TabIndex = 3;
            // 
            // tbxGetItem
            // 
            this.tbxGetItem.Location = new System.Drawing.Point(113, 198);
            this.tbxGetItem.Multiline = true;
            this.tbxGetItem.Name = "tbxGetItem";
            this.tbxGetItem.Size = new System.Drawing.Size(124, 29);
            this.tbxGetItem.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(276, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(276, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(276, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxGetItem);
            this.Controls.Add(this.tbxdeleteItem);
            this.Controls.Add(this.tbxAddItem);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.items);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox items;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.TextBox tbxAddItem;
        private System.Windows.Forms.TextBox tbxdeleteItem;
        private System.Windows.Forms.TextBox tbxGetItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

