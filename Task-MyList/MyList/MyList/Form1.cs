using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMyList
{
    public partial class Form1 : Form
    {
        MyList<int> list=new MyList<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateList()
        {   listBox1.Items.Clear();
            foreach(int item in list) {
            listBox1.Items.Add(item);   
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            list.Append((int)numericUpDown1.Value);
            UpdateList();
        }
        private void prependBtn_Click(object sender, EventArgs e)
        {
            list.Prepend((int)numericUpDown2.Value);
            UpdateList();
        }
        private void removeVbtn_Click(object sender, EventArgs e)
        {
            list.Remove((int)numericUpDown3.Value);
            UpdateList();
        }
        private void removeAbtn_Click(object sender, EventArgs e)
        {
            list.RemoveAt((int)numericUpDown4.Value);
            UpdateList();
        }
        private void atBtn_Click(object sender, EventArgs e)
        {
            label1.Text = list[(int)numericUpDown5.Value].ToString();
        }
        private void findBtn_Click(object sender, EventArgs e)
        {
            label2.Text = list.Find((int)numericUpDown6.Value).ToString();
        }

        private void containsBtn_Click(object sender, EventArgs e)
        {
            va.Text=list.Contains((int)numericUpDown7.Value).ToString();
        }

        private void setValuebtn_Click(object sender, EventArgs e)
        {
            list[(int)numericUpDown8.Value]=(int)numericUpDown9.Value;
            UpdateList();
        }

        private void toArrayBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (int item in list.ToArray()) 
            {
                textBox1.Text = textBox1.Text + " , " + item;
            }
        }
    }
}
