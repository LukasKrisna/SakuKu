using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormCRUDAccess
{
    public partial class Form2 : Form
    {
        Form1 f1;
        Form3 f3;

        public Form2()
        {
            InitializeComponent();
            f1 = new Form1();
            f3 = new Form3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f3.IsDisposed)
            {
                f3 = new Form3();
                f3.Show();
            }
            else
            {
                f3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f1.IsDisposed)
            {
                f1 = new Form1();
                f1.Show();
            }
            else
            {
                f1.Show();
            }
        }
    }
}
