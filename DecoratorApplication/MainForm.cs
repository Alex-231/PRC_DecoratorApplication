using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecoratorApplication
{
    public partial class MainForm : Form
    {
        public static PaintMath Calculator = new PaintMath();

        public MainForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Walls form, hide the MainForm
            //show the Walls form as a dialog and when it's done show the MainForm again.
            Calculator = new PaintMath();
            Form Walls = new Walls();
            this.Hide();
            Walls.ShowDialog();
            this.Show();
            //this.Close();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            Form About = new AboutBox();
            About.ShowDialog();
        }
    }
}
