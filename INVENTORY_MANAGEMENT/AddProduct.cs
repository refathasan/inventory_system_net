using MySql.Data.MySqlClient;
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
    public partial class AddProduct : Form
    {
        DBConnect dBConnect;
        public AddProduct()
        {
            InitializeComponent();
            dBConnect =  new DBConnect();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool status = false;
            int id = int.Parse(tbProductID.Text);
            string name = tbProductName.Text;
            string desc = tbProductDescription.Text;
            int price = int.Parse(tbUnitPrice.Text);
            status = dBConnect.insertInventory(id,name,desc,price);
            if (status == true)
            {
                MessageBox.Show("Inventory Insert Successfully. Product ID is " + id);
                tbProductID.Text = "";
                tbProductName.Text = "";
                tbProductDescription.Text = "";
                tbUnitPrice.Text = "";
            }
            else if (status == false)
            {
                MessageBox.Show("Inventory Insertion Failed ");
            }
        }
    }
}
