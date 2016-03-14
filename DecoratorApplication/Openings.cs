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
    public partial class Openings : Form
    {
        public Openings()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Form Paints = new Paints();
            this.Hide();
            Paints.ShowDialog();
            this.Show();
        }

        private void addOpeningBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(widthBox.Text);
                float.Parse(heightBox.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter both the width and the height.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("The area entered is too large and has not been added", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("The area entered is not formatted correctly and has not been added", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.Parse(widthBox.Text) * float.Parse(heightBox.Text) >= MainForm.Calculator.WallAreas.Sum() - MainForm.Calculator.OpenAreas.Sum())
            {
                MessageBox.Show("The opening you entered is larger than or equal to the wall area.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.Parse(widthBox.Text) <= 0 || float.Parse(heightBox.Text) <= 0)
            {
                MessageBox.Show("The area entered is too small and has not been added.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MainForm.Calculator.AddOpening(float.Parse(widthBox.Text), float.Parse(heightBox.Text));
            UpdateLabels();
            this.widthBox.Text = null;
            this.heightBox.Text = null;
        }
        private void UpdateLabels()
        {
            this.OpeningsCountLbl.Text = MainForm.Calculator.OpenAreas.Count().ToString();
            this.PaintAreaLbl.Text = MainForm.Calculator.GetTotalArea().ToString();
        }

        private void Openings_Load(object sender, EventArgs e)
        {
            this.PaintAreaLbl.Text = MainForm.Calculator.GetTotalArea().ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
