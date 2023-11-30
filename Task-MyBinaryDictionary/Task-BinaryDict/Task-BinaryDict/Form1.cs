using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_BinaryDict
{
    public partial class Form1 : Form
    { 
        MyTresscs<string,string> myTresscs=new MyTresscs<string,string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Refresh()
        {   listboxKey.Items.Clear();
            listBoxValue.Items.Clear();
            foreach (var item in myTresscs.Key)
            {
                listboxKey.Items.Add(item);
            }
            foreach (var item in myTresscs.Values)
            {
                listBoxValue.Items.Add(item);
            }
        }
        private void tbxContains_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myTresscs.Add( tbxValue.Text,tbxKey.Text);
            Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            myTresscs.Remove(tbxValueRemove.Text);
            Refresh();
        }
        private void btnValueByKey_Click(object sender, EventArgs e)
        {
            textBox2.Text = myTresscs[tbxValueByKey.Text];
        }

        private void btnKeyByValue_Click(object sender, EventArgs e)
        {
            textBox4.Text = myTresscs.FindKey(textBox3.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = myTresscs.ContainsKey(textBox1.Text).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text=myTresscs.ContainsValue(textBox5.Text).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myTresscs.Clear();
            Refresh();
        }
    }
}
