﻿using Field_Sales_System.Business_Logic;
using Field_Sales_System.ControlLogic;
using System;
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
        private Controller controller;
        public Invoice(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            invoiceNumberText.Text = "";
            empIDText.Text = "";
            customerNameText.Text = "";
            customerContactText.Text = "";
            productNameCombo.Text = "Product Name";
            productIDLabel.Text = "Product ID";
            unitPriceLabel.Text = "Unit Price";
            qtyText.Text = "Quantity";

            invoiceDataGrid.RowCount = 0;

            totalText.Text = "";
        }

        float price;


        private void addItemButton_Click(object sender, EventArgs e)
        {           
            price = (float.Parse(unitPriceLabel.Text)) * (float.Parse(qtyText.Text));
            this.invoiceDataGrid.Rows.Add(false, productIDLabel.Text, productNameCombo.GetItemText(productNameCombo.SelectedItem.ToString()), unitPriceLabel.Text, qtyText.Text, price);
           
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in invoiceDataGrid.SelectedRows) {
                if (!row.IsNewRow) invoiceDataGrid.Rows.Remove(row);
            }
           
                
        }

        //double sum, discount;

        private void productNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProct = productNameCombo.SelectedItem.ToString();
            Product product = controller.getSelectedProduct(selectedProct);
            if (product != null) {
                productIDLabel.Text = product.ProductID.ToString();
                unitPriceLabel.Text = product.PricePerUnit.ToString();
            }
        }



        double sum = 0;
        private void finishButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < invoiceDataGrid.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(invoiceDataGrid.Rows[i].Cells["Value"].Value);
            }

            totalText.Text = sum.ToString();
            controller.addOrder();
            //removeButton_Click(sender, e);
            clearButton_Click(sender, e);
        }

        private void qtyText_Click(object sender, EventArgs e)
        {
            if (qtyText.Text == "Quantity") {
                qtyText.Text = "";
            }
        }

        private void finishButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void removeButton_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in invoiceDataGrid.SelectedRows)
                if (!row.IsNewRow) invoiceDataGrid.Rows.Remove(row);
=======
        private void finishButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Invoice_Paint(object sender, PaintEventArgs e)
        {
            controller.loadNewOrder();
>>>>>>> 93c3057ea334bd1eeee5e286716e5298a6f09708
        }
    }
}
