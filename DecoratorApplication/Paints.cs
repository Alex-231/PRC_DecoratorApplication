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
    public partial class Paints : Form
    {
        public Paints()
        {
            InitializeComponent();
        }

        decimal paintPrice;
        decimal undercoatPrice;
        string paintType;

        private void paintBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the selection changes, and contains a £, parse the price.
            if (paintBox.Text.Contains("£"))
            {
                string paintPriceParse = paintBox.Text;
                paintPriceParse = paintPriceParse.Remove(0, paintPriceParse.IndexOf("£") + 1); //Removed everything before the price.
                paintPriceParse = paintPriceParse.Remove(paintPriceParse.IndexOf(" ")); //Removes everything after the price.
                paintType = paintBox.Text.Remove(paintBox.Text.IndexOf("(") - 1); //Removes everything after the paint type.

                try
                {
                    paintPrice = decimal.Parse(paintPriceParse);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Something went wrong! Please check the price of the paint.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Something went wrong! Please check the price of the paint.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Something went wrong! Please check the price of the paint.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (paintPrice > 0)
                {
                    UpdateLabels();
                }
            }
        }

        private void UpdateLabels()
        {
            rateLbl.Text = "£" + (paintPrice + undercoatPrice).ToString();
            totalLbl.Text = "£" + ( decimal.Parse(MainForm.Calculator.GetTotalArea().ToString()) * (paintPrice + undercoatPrice) ).ToString("0.00");
            if (paintPrice > 0)
            {
                createInvoiceBtn.Enabled = true;
            }
            else
            {
                createInvoiceBtn.Enabled = false;
            }
        }

        private void undercoatBox_CheckedChanged(object sender, EventArgs e)
        {
            if (undercoatBox.Checked)
            {
                string undercoatPriceParse = undercoatBox.Text;
                undercoatPriceParse = undercoatPriceParse.Remove(0, undercoatPriceParse.IndexOf("£") + 1); //Removed everything before the price.
                undercoatPriceParse = undercoatPriceParse.Remove(undercoatPriceParse.IndexOf(" ")); //Removes everything after the price.

                try
                {
                    undercoatPrice = decimal.Parse(undercoatPriceParse);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Something went wrong! Please check the price of the undercoat.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Something went wrong! Please check the price of the undercoat.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Something went wrong! Please check the price of the undercoat.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateLabels();
            }
            else
            {
                undercoatPrice = 0;
                UpdateLabels();
            }
        }

        private void Paints_Load(object sender, EventArgs e)
        {
            paintAreaLbl.Text = MainForm.Calculator.GetTotalArea().ToString();
        }

        private void createInvoiceBtn_Click(object sender, EventArgs e)
        {
            Invoice InvoiceForm = new Invoice(paintPrice, undercoatPrice, paintType);
            this.Hide();
            InvoiceForm.ShowDialog();
            this.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
