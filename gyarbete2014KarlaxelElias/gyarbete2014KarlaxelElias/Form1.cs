using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gyarbete2014KarlaxelElias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                tid += 0.16f;

                boll.posB.X = 75f * tid;
                boll.posB.Y = 650f - 75f * tid + 0.5f * 9.82f * tid * tid;


                if (boll.posB.Y > 700f)
                {
                    boll.posB.Y = 650f;
                    boll.posB.X = 0;
                }
            }
        }
    }
}
