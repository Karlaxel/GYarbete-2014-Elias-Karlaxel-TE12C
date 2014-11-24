using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkör_Click(object sender, EventArgs e)
        {
          //  Animal a = new Animal();
            Cat c = new Cat("Rosa");
            Dog d = new Dog("Fido");
           // tbxresultat.AppendText("Animal;" + a.Sound() + "\n");
            tbxresultat.AppendText("Kat;" + c.Sound() + "\n");
            tbxresultat.AppendText("Hund;" + d.Sound() + "\n");
            tbxresultat.AppendText("ränknare =" + "  " + Animal.Count + "\n");
            tbxresultat.AppendText("Antal Ben För katt;" + c.NumberOfLegs() + "\n");
        }
    }
}
