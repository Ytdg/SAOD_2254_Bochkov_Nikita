namespace MyVecktorTask
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
            this.inputIndInit = new System.Windows.Forms.NumericUpDown();
            this.btn_Create = new System.Windows.Forms.Button();
            this.inputValueAdd = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.InputIndexGetCalue = new System.Windows.Forms.NumericUpDown();
            this.ViewValuesIndex = new System.Windows.Forms.TextBox();
            this.btn_At = new System.Windows.Forms.Button();
            this.inputIndexSet = new System.Windows.Forms.NumericUpDown();
            this.SetValues = new System.Windows.Forms.TextBox();
            this.btn_Set = new System.Windows.Forms.Button();
            this.countReserve = new System.Windows.Forms.NumericUpDown();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.countResize = new System.Windows.Forms.NumericUpDown();
            this.btn_Resize = new System.Windows.Forms.Button();
            this.btnShrinkToFit = new System.Windows.Forms.Button();
            this.lbx_Items = new System.Windows.Forms.ListBox();
            this.lbx_Size = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.Label();
            this.lbxCapacity = new System.Windows.Forms.Label();
            this.initValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputIndInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputIndexGetCalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputIndexSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countResize)).BeginInit();
            this.SuspendLayout();
            // 
            // inputIndInit
            // 
            this.inputIndInit.Location = new System.Drawing.Point(12, 24);
            this.inputIndInit.Name = "inputIndInit";
            this.inputIndInit.Size = new System.Drawing.Size(104, 22);
            this.inputIndInit.TabIndex = 0;
            this.inputIndInit.ValueChanged += new System.EventHandler(this.inputIndInit_ValueChanged);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(132, 24);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(85, 34);
            this.btn_Create.TabIndex = 1;
            this.btn_Create.Text = "CREATE";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // inputValueAdd
            // 
            this.inputValueAdd.Location = new System.Drawing.Point(12, 79);
            this.inputValueAdd.Multiline = true;
            this.inputValueAdd.Name = "inputValueAdd";
            this.inputValueAdd.Size = new System.Drawing.Size(104, 32);
            this.inputValueAdd.TabIndex = 2;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(132, 77);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 34);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // InputIndexGetCalue
            // 
            this.InputIndexGetCalue.Location = new System.Drawing.Point(12, 135);
            this.InputIndexGetCalue.Name = "InputIndexGetCalue";
            this.InputIndexGetCalue.Size = new System.Drawing.Size(104, 22);
            this.InputIndexGetCalue.TabIndex = 4;
            // 
            // ViewValuesIndex
            // 
            this.ViewValuesIndex.Location = new System.Drawing.Point(122, 135);
            this.ViewValuesIndex.Multiline = true;
            this.ViewValuesIndex.Name = "ViewValuesIndex";
            this.ViewValuesIndex.Size = new System.Drawing.Size(104, 32);
            this.ViewValuesIndex.TabIndex = 5;
            // 
            // btn_At
            // 
            this.btn_At.Location = new System.Drawing.Point(232, 135);
            this.btn_At.Name = "btn_At";
            this.btn_At.Size = new System.Drawing.Size(85, 34);
            this.btn_At.TabIndex = 6;
            this.btn_At.Text = "At";
            this.btn_At.UseVisualStyleBackColor = true;
            this.btn_At.Click += new System.EventHandler(this.btn_At_Click);
            // 
            // inputIndexSet
            // 
            this.inputIndexSet.Location = new System.Drawing.Point(12, 181);
            this.inputIndexSet.Name = "inputIndexSet";
            this.inputIndexSet.Size = new System.Drawing.Size(104, 22);
            this.inputIndexSet.TabIndex = 7;
            // 
            // SetValues
            // 
            this.SetValues.Location = new System.Drawing.Point(122, 181);
            this.SetValues.Multiline = true;
            this.SetValues.Name = "SetValues";
            this.SetValues.Size = new System.Drawing.Size(104, 32);
            this.SetValues.TabIndex = 8;
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(232, 181);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(85, 34);
            this.btn_Set.TabIndex = 9;
            this.btn_Set.Text = "Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // countReserve
            // 
            this.countReserve.Location = new System.Drawing.Point(12, 235);
            this.countReserve.Name = "countReserve";
            this.countReserve.Size = new System.Drawing.Size(104, 22);
            this.countReserve.TabIndex = 10;
            this.countReserve.ValueChanged += new System.EventHandler(this.countReserve_ValueChanged);
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Location = new System.Drawing.Point(122, 235);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(85, 34);
            this.btn_Reserve.TabIndex = 11;
            this.btn_Reserve.Text = "Reserve";
            this.btn_Reserve.UseVisualStyleBackColor = true;
            this.btn_Reserve.Click += new System.EventHandler(this.btn_Reserve_Click_1);
            // 
            // countResize
            // 
            this.countResize.Location = new System.Drawing.Point(12, 290);
            this.countResize.Name = "countResize";
            this.countResize.Size = new System.Drawing.Size(104, 22);
            this.countResize.TabIndex = 12;
            this.countResize.ValueChanged += new System.EventHandler(this.countResize_ValueChanged);
            // 
            // btn_Resize
            // 
            this.btn_Resize.Location = new System.Drawing.Point(122, 283);
            this.btn_Resize.Name = "btn_Resize";
            this.btn_Resize.Size = new System.Drawing.Size(85, 34);
            this.btn_Resize.TabIndex = 13;
            this.btn_Resize.Text = "Resize";
            this.btn_Resize.UseVisualStyleBackColor = true;
            this.btn_Resize.Click += new System.EventHandler(this.btn_Resize_Click);
            // 
            // btnShrinkToFit
            // 
            this.btnShrinkToFit.Location = new System.Drawing.Point(122, 341);
            this.btnShrinkToFit.Name = "btnShrinkToFit";
            this.btnShrinkToFit.Size = new System.Drawing.Size(85, 34);
            this.btnShrinkToFit.TabIndex = 14;
            this.btnShrinkToFit.Text = "ShrinkToFit";
            this.btnShrinkToFit.UseVisualStyleBackColor = true;
            this.btnShrinkToFit.Click += new System.EventHandler(this.btnShrinkToFit_Click);
            // 
            // lbx_Items
            // 
            this.lbx_Items.FormattingEnabled = true;
            this.lbx_Items.ItemHeight = 16;
            this.lbx_Items.Location = new System.Drawing.Point(360, 33);
            this.lbx_Items.Name = "lbx_Items";
            this.lbx_Items.Size = new System.Drawing.Size(164, 180);
            this.lbx_Items.TabIndex = 15;
            // 
            // lbx_Size
            // 
            this.lbx_Size.AutoSize = true;
            this.lbx_Size.Location = new System.Drawing.Point(399, 216);
            this.lbx_Size.Name = "lbx_Size";
            this.lbx_Size.Size = new System.Drawing.Size(0, 16);
            this.lbx_Size.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Size:";
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Location = new System.Drawing.Point(357, 244);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(63, 16);
            this.lbx.TabIndex = 18;
            this.lbx.Text = "Capacity:";
            // 
            // lbxCapacity
            // 
            this.lbxCapacity.AutoSize = true;
            this.lbxCapacity.Location = new System.Drawing.Point(426, 244);
            this.lbxCapacity.Name = "lbxCapacity";
            this.lbxCapacity.Size = new System.Drawing.Size(0, 16);
            this.lbxCapacity.TabIndex = 19;
            // 
            // initValue
            // 
            this.initValue.Location = new System.Drawing.Point(223, 26);
            this.initValue.Multiline = true;
            this.initValue.Name = "initValue";
            this.initValue.Size = new System.Drawing.Size(104, 32);
            this.initValue.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "defValue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initValue);
            this.Controls.Add(this.lbxCapacity);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_Size);
            this.Controls.Add(this.lbx_Items);
            this.Controls.Add(this.btnShrinkToFit);
            this.Controls.Add(this.btn_Resize);
            this.Controls.Add(this.countResize);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.countReserve);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.SetValues);
            this.Controls.Add(this.inputIndexSet);
            this.Controls.Add(this.btn_At);
            this.Controls.Add(this.ViewValuesIndex);
            this.Controls.Add(this.InputIndexGetCalue);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.inputValueAdd);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.inputIndInit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputIndInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputIndexGetCalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputIndexSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countResize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputIndInit;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox inputValueAdd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.NumericUpDown InputIndexGetCalue;
        private System.Windows.Forms.TextBox ViewValuesIndex;
        private System.Windows.Forms.Button btn_At;
        private System.Windows.Forms.NumericUpDown inputIndexSet;
        private System.Windows.Forms.TextBox SetValues;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.NumericUpDown countReserve;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.NumericUpDown countResize;
        private System.Windows.Forms.Button btn_Resize;
        private System.Windows.Forms.Button btnShrinkToFit;
        private System.Windows.Forms.ListBox lbx_Items;
        private System.Windows.Forms.Label lbx_Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lbxCapacity;
        private System.Windows.Forms.TextBox initValue;
        private System.Windows.Forms.Label label2;
    }
}

