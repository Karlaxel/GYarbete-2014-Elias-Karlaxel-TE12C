using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InlämningsuppgiftPersonKarlaxelEkblom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person("Anna", "Mälarhöjden");
            textBox1.Text = p.Fakta();
            
            Anställd a  = new Anställd("Anna","Mälarhöjden", 15000);
            textBox1.AppendText(a.Fakta());
            
            Försäljare b = new Försäljare("Anna", "Mälarhöjden", 15000,10);
            textBox1.AppendText(b.Fakta() + "\n");
            
        }
    }
}
