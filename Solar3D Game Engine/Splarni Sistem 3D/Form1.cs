using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cube Body1 = new Cube(5, 5, 5);

        private void Form1_Shown(object sender, EventArgs e)
        {

            this.Paint += new PaintEventHandler(Form1_paint);
        }

        private void Form1_paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Agent.Draw(e.Graphics, Body1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
