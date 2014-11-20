using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArbGollFboll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boll b1 = new Boll(20, "plast", "gul");
            richTextBox1.AppendText(b1.Rulla(3) + "\n");
            richTextBox1.AppendText(b1.Volym() + "\n\n");
            b1.Diameter = 100;
            richTextBox1.AppendText(b1.Volym() + "\n");
            richTextBox1.AppendText("\n");

            Boll b2 = new Boll { };
            Golfboll g2 = new Golfboll(23,"s","f","bf3");
            Boll.

            Golfboll g1 = new Golfboll(43, "Sten", "Grön", "Björnborg");
            richTextBox1.AppendText(g1.Rulla(3) + "\n");
            richTextBox1.AppendText(g1.Volym() + "\n");
            richTextBox1.AppendText(g1.Godkänd() + "\n");
        }
    }
}
