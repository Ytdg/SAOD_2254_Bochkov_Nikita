using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskStack
{
    public partial class Form1 : Form
    {
        MyStack<int> stack;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbxCountStack.Text, out var res) && res != 0)
            {

                lbVisCreatStack.Visible = true;
                stack = new MyStack<int>(res);
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            items.Items.Clear();
            tbxAddItem.Clear();
            tbxdeleteItem.Clear();
            tbxGetItem.Clear();

        }
        private void UpdateList()
        {
            items.Items.Clear();
            foreach (var s in stack.Values())
            {
                items.Items.Add(s);

            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbxAddItem.Text, out var res))
            {

                stack.Push(res);
                UpdateList();

            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            tbxdeleteItem.Text = stack.Pop().ToString();
            UpdateList();

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            tbxGetItem.Text = stack.Peek().ToString();
        }
    }
}
