using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkappaBollC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boll b1 = new boll();
            b1.radie = 10;
            boll.pi = 3141415;
            textBox1.AppendText(boll.count.ToString());

            boll b2 = new boll();
            b2.radie = 20;
            
            textBox1.AppendText("\n");
            textBox1.AppendText(boll.count.ToString());
        }
    }
}
