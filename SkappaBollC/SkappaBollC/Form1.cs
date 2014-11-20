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
            Boll b1 = new Boll();

            try
            {
                int radie = int.Parse(textBox2.Text);
                b1.radie = radie;
            }
            catch ( Exception error)
            {

                textBox1.AppendText(error.ToString());
            }
           
            
            
            /* if (!flag)
              textBox1.AppendText("fel imanting \n ");

              b1.radie = radie;
            
            */
              Boll.pi = 3141415;
              textBox1.AppendText(b1.Area().ToString());

/*            boll b2 = new boll();
            b2.radie = int.Parse(textBox2.Text);
            
            textBox1.AppendText("\n");
            textBox1.AppendText(boll.count.ToString());
  */
   }
    }
}
