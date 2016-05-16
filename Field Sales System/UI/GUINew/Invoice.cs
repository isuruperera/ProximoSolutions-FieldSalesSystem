﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUINew
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            invoiceNumberText.Text = "";
            empIDText.Text = "";
            customerNameText.Text = "";
            customerContactText.Text = "";
            productNameCombo.Text = "Product Name";
            productIDLabel.Text = "Product ID";
            batchNoCombo.Text = "Batch No";
            unitPriceLabel.Text = "Unit Price";
            qtyText.Text = "Quantity";

            invoiceDataGrid.RowCount = 0;

            totalText.Text = "";
        }

        float price;

        private void addItemButton_Click(object sender, EventArgs e)
        {
            price = (float.Parse(unitPriceLabel.Text)) * (float.Parse(qtyText.Text));
            this.invoiceDataGrid.Rows.Add(productIDLabel.Text, productNameCombo.GetItemText(productNameCombo.SelectedItem), unitPriceLabel.Text, qtyText.Text, price);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (this.invoiceDataGrid.SelectedRows.Count > 0)
            {
                invoiceDataGrid.Rows.RemoveAt(this.invoiceDataGrid.SelectedRows[0].Index);
            }
        }

        double sum, discount;

        private void finishButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            for (int i = 0; i < invoiceDataGrid.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(invoiceDataGrid.Rows[i].Cells["Value"].Value);
            }

            totalText.Text = sum.ToString();
        }

        

        
    }
}
