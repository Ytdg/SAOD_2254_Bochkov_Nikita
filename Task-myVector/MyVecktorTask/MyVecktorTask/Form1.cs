using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVecktorTask
{
    public partial class Form1 : Form
    { MyVector<String> vector;
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshItems()
        {
            lbx_Items.Items.Clear();
            foreach(string item in vector) {
                lbx_Items.Items.Add(item);
            }
            lbxCapacity.Text=vector.Capacity.ToString();
            lbx_Size.Text=vector.Size.ToString();   
        }
       private void NoClicBtn(Boolean cheker)
        {
            if (cheker)
            {
                btnShrinkToFit.Enabled = false;
                btn_Add.Enabled = false;
                btn_At.Enabled = false;
                btn_Create.Enabled = false;
                btn_Reserve.Enabled = false;
                btn_Resize.Enabled = false;
                btn_Set.Enabled = false;
            }
            else {
                btn_Create.Enabled = true;
            }
        }
        private void inputIndInit_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown=sender as NumericUpDown;
            if(numericUpDown.Value<=0) { NoClicBtn(true); }
            else { NoClicBtn(false); }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        { var valueInit = initValue.Text;
            if (valueInit.Replace(" ","") == "")
            {
                valueInit = "default value";

            }
            vector = new MyVector<String>((int)inputIndInit.Value, valueInit);
            btnShrinkToFit.Enabled = true;
            btn_Add.Enabled = true;
            btn_At.Enabled = true;
            btn_Reserve.Enabled = true;
            btn_Resize.Enabled = true;
            btn_Set.Enabled = true;
            RefreshItems();
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var inputValueAdds = inputValueAdd.Text;
            if (inputValueAdds.Replace(" ", "") == "")
            {
                inputValueAdds = "default value";
            }
            vector.Add(inputValueAdds);
            RefreshItems();
        }

        private void btn_At_Click(object sender, EventArgs e)
        {
            try {
                ViewValuesIndex.Text = vector[Math.Abs((int)InputIndexGetCalue.Value)];
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            try
            {
                vector[Math.Abs((int)inputIndexSet.Value)] = SetValues.Text.Replace(" ", "") == "" ? "default value" : SetValues.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            RefreshItems();
        }

        

        private void countReserve_ValueChanged(object sender, EventArgs e)
        {
            if (countReserve.Value < 0)
            {
                countReserve.Value = 0;
            }
        }

        private void btn_Resize_Click(object sender, EventArgs e)
        {
            var valueInit = initValue.Text;
            if (valueInit.Replace(" ", "") == "")
            {
                valueInit = "default value"; ;
            }
            vector.Resize((int)countResize.Value, valueInit);
            RefreshItems();
        }

        private void countResize_ValueChanged(object sender, EventArgs e)
        {
            if(countResize.Value < 0) { countReserve.Value = 0; }
        }

        private void btnShrinkToFit_Click(object sender, EventArgs e)
        {
            vector.ShrinkToFit();
            RefreshItems();
        }

        private void btn_Reserve_Click_1(object sender, EventArgs e)
        {
            try
            {
                vector.Reserve((int)countReserve.Value);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            RefreshItems();
        }
    }
}
