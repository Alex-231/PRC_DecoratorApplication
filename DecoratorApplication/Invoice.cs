﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DecoratorApplication
{
    public partial class Invoice : Form
    {
        #region DemStrings

        //The purchaseOrder is 001 for paint, 002 for paint with undercoat and 000 for error.
        //The paymentDue date is one month after the current date, this can be adjusted if needed.

        //Invoice # Format = #Year-Quater-Number. Eg. #2016-3-007
        //Unfortunately without access to scenario hardware there's no way I can tell the invoice count.
        //So I'll assume that all invoices are created through one installation of this program and store the count locally.
        //An interface could replace this later on though :)
        //The count is currently stored in the program's settings.

        //Invoice Variables
        //I'm using the string datatype a lot here so that I don't have to do any conversion when producing the rtf invoice.
        string date = DateTime.Now.Date.ToString("dd/MM/yy"); //Could probably use .ToShortDateString() here but I like the customization.
        string invoiceNumber = DateTime.Now.Year + "-" + (DateTime.Now.Month / 4) + "-" + DecoratorApplication.Properties.Settings.Default.invoiceNumber.ToString("D3");
        string purchaseOrder = "000";
        string paymentDue = DateTime.Now.Date.AddMonths(1).ToString("dd/MM/yy");
        string subTotal = (MainForm.Calculator.GetTotalArea() * (MainForm.Calculator.paintPrice + MainForm.Calculator.undercoatPrice)).ToString();

        string totalArea = MainForm.Calculator.GetTotalArea().ToString();
        string paintType = MainForm.Calculator.paintType;
        string paintPrice = MainForm.Calculator.paintPrice.ToString();
        string undercoatPrice;
        string undercoatType;  //Some support for multiple undercoats here although it would take some more work.
        string discount = "0";
        float vatRateValue = 0.2f; //Used in calculation.
        string vatRate = "20";
        string vat;
        string total;

        string name;
        string companyName;
        string addressline1;
        string addressline2;
        string phoneNumber;
        string customerId;
        string specialInstructions = "";

        bool writeError = false; //Definately a better way to do this.

        #endregion

        public Invoice()
        {
            InitializeComponent();

            if (MainForm.Calculator.undercoatPrice == 0)
            {
                purchaseOrder = "001";
                undercoatPrice = "";
                undercoatType = "";
            }
            else
            {
                purchaseOrder = "002";
                undercoatPrice = MainForm.Calculator.undercoatPrice.ToString();
                undercoatType = "   + Undercoat";
            }
        }

        private void UpdateFinishButton()
        {
            if(!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(companyName) && !string.IsNullOrWhiteSpace(addressline1) && !string.IsNullOrWhiteSpace(addressline2) && !string.IsNullOrWhiteSpace(phoneNumber) && !string.IsNullOrWhiteSpace(customerId))
            {
                this.finishBtn.Enabled = true;
            }
            else
            {
                this.finishBtn.Enabled = false;
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            dateBox.Text = date;
            invoiceNumberBox.Text = invoiceNumber;
            purchaseOrderBox.Text = purchaseOrder;
            paymentDueBox.Text = paymentDue;
            subtotalBox.Text = "£" + subTotal;
            vatRateBox.SelectedIndex = 0;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            saveInvoice.FileName = "Invoice #" + invoiceNumber;
            saveInvoice.ShowDialog();
        }
        private void CreateInvoice() //Creates the invoice and returns true. Returns false if an error occured. There's probably a better way to do this.
        {
            //Loading the whole file here, would be ideal to change it line by line but I can't figure out a simple way to read it line by line.
            string invoiceFileContents = Properties.Resources.InvoiceTemplate.ToString();
            //I should really use String Builder more often. Not going back now.
            StringBuilder invoiceFileEditing = new StringBuilder(invoiceFileContents);

            #region Invoice Editing

            invoiceFileEditing.Replace("<name>", name);
            invoiceFileEditing.Replace("<companyName>", companyName);
            invoiceFileEditing.Replace("<addressline1>", addressline1);
            invoiceFileEditing.Replace("<addressline2>", addressline2);
            invoiceFileEditing.Replace("<phoneNumber>", phoneNumber);
            invoiceFileEditing.Replace("<date>", date);
            invoiceFileEditing.Replace("<invoiceNumber>", invoiceNumber);
            invoiceFileEditing.Replace("<customerId>", customerId);
            invoiceFileEditing.Replace("<purchaseOrder>", purchaseOrder);
            invoiceFileEditing.Replace("<paymentDue>", paymentDue);
            invoiceFileEditing.Replace("<paintType>", (paintType + " Paint")); //Might want to look into using an array in the future to handle multiple items.
            invoiceFileEditing.Replace("<totalArea>", totalArea);
            invoiceFileEditing.Replace("<undercoatType>", undercoatType);
            invoiceFileEditing.Replace("<paintPrice>", paintPrice);
            invoiceFileEditing.Replace("<undercoatPrice>", undercoatPrice);
            invoiceFileEditing.Replace("<specialInstructions>", specialInstructions);
            invoiceFileEditing.Replace("<subTotal>", subTotal);
            invoiceFileEditing.Replace("<vatRate>", vatRate);
            invoiceFileEditing.Replace("<vat>", vat);
            invoiceFileEditing.Replace("<discount>", discount);
            invoiceFileEditing.Replace("<total>", total);

            #endregion

            invoiceFileContents = invoiceFileEditing.ToString();
            
            try
            {
                File.WriteAllText(saveInvoice.FileName, invoiceFileContents);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Something went wrong! Please check the invoice path.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeError = true;
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("The invoice path is too long, please choose another.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeError = true;
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Could not find the invoice file path.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeError = true;
            }
            catch (IOException)
            {
                MessageBox.Show("Something is preventing the program from creating the invoice.\nDoes the file already exist?", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeError = true;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Something is preventing the program from creating the invoice.\nDoes the file already exist?", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeError = true;
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Something went wrong! Please check the invoice path.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeError = true;
            }
            catch (SecurityException)
            {
                MessageBox.Show("You do not have permission to create a file there.\nDoes the file already exist?", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeError = true;
            }

        }

        #region BillTo Control Updating

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            name = nameBox.Text;
            UpdateFinishButton();
        }

        private void companyNameBox_TextChanged(object sender, EventArgs e)
        {
            companyName = companyNameBox.Text;
            UpdateFinishButton();
        }

        private void addressline1Box_TextChanged(object sender, EventArgs e)
        {
            addressline1 = addressline1Box.Text;
            UpdateFinishButton();
        }

        private void addressline2Box_TextChanged(object sender, EventArgs e)
        {
            addressline2 = addressline2Box.Text;
            UpdateFinishButton();
        }

        private void phoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = phoneNumberBox.Text;
            UpdateFinishButton();
        }

        private void customerIdBox_TextChanged(object sender, EventArgs e)
        {
            customerId = customerIdBox.Text;
            UpdateFinishButton();
        }

        #endregion

        private void vatRateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                vatRateValue = float.Parse(vatRateBox.Text.Remove(vatRateBox.Text.IndexOf(")")).Remove(0, vatRateBox.Text.IndexOf("%") + 1)) / 100;
            }
            catch (FormatException)
            {
                MessageBox.Show("Something went wrong! Please check the VAT Rate.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Something went wrong! Please check the VAT Rate.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Something went wrong! Please check the VAT Rate.", "Paint Calculator - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            vatRate = vatRateBox.Text.Remove(vatRateBox.Text.IndexOf(")")).Remove(0, vatRateBox.Text.IndexOf("%") + 1);
            vat = (float.Parse(subTotal) * vatRateValue).ToString(); //Don't need to try this parse since it's already been parsed from a float.
            vatBox.Text = "£" + (float.Parse(subTotal) * vatRateValue).ToString();
            total = ((float.Parse(subTotal) + float.Parse(vat)) - float.Parse(discount)).ToString();
            totalBox.Text = "£" + total;
        }

        private void discountBox_ValueChanged(object sender, EventArgs e)
        {
            //This makes sure that the discount cannot be greater than the price with VAT.
            if (((float.Parse(subTotal) + float.Parse(vat)) - decimal.ToSingle(discountBox.Value)) < 0)
            {
                discountBox.Value = Decimal.Parse((float.Parse(subTotal) + float.Parse(vat)).ToString());
                return;
            }

            discount = discountBox.Value.ToString();
            total = ((float.Parse(subTotal) + float.Parse(vat)) - float.Parse(discount)).ToString();
            totalBox.Text = "£" + total;
        }

        private void specialInstructionsBox_TextChanged(object sender, EventArgs e)
        {
            specialInstructions = specialInstructionsBox.Text;
        }

        private void saveInvoice_FileOk(object sender, CancelEventArgs e)
        {
            CreateInvoice();

            //And Finally, I need to create the RTF file for the invoice.
            //When that's done, I'll increase the invoice count for next time, open the invoice and close this application.

            if (writeError == true)
            {
                return;
            }

            DecoratorApplication.Properties.Settings.Default.invoiceNumber++;
            DecoratorApplication.Properties.Settings.Default.Save();
            //saveInvoice.OpenFile();
            Process.Start(saveInvoice.FileName);
            Environment.Exit(0);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
