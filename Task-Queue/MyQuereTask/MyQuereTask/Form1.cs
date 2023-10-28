using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQuereTask
{
    public partial class Form1 : Form
    {
        MyQueue<int> queu;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbxCount.Text, out var res))
            {
                queu = new MyQueue<int>(res);
                button1.Enabled=true;
                button2.Enabled=true;
                button3.Enabled=true;
                button4.Enabled=true;
            }
            items.Items.Clear();
            tbxAddItem.Clear();
            tbxdeleteItem.Clear();
            tbxGetItem.Clear();
        }
        private void UpdateList()
        {
            items.Items.Clear();
            foreach (var s in queu.Values())
            {
                items.Items.Add(s);
            }
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbxAddItem.Text, out var res))
            {
                try
                {
                    queu.Enqueue(res);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
       
                }
                UpdateList();
            }

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                tbxdeleteItem.Text = queu.Dequeue().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            UpdateList();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            try
            {
                tbxGetItem.Text = queu.Peek().ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

    }

        
   
}
