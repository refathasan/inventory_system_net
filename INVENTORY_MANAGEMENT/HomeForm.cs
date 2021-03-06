﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
   
    public partial class home : Form
    {
        private DBConnect dBConnect;
        public home()
        {
            InitializeComponent();
            dBConnect = new DBConnect();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Are You Sure to exit this Application!!! ","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (exitResult == DialogResult.OK)
            {
                Application.Exit();
            }
            if (exitResult== DialogResult.Cancel)
            {
                
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            AddStockForm addStockForm = new AddStockForm();
            addStockForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(QuaryStatements.STOCK_QUERY, dBConnect.CONNECTION_STRING);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            currentStockGridView.DataSource = dataSet.Tables[0];
        }
    }
}
