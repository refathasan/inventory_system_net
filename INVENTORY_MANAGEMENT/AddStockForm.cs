using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class AddStockForm : Form
    {
        string inventory_name = "";
        DBConnect dBConnect;
        public AddStockForm()
        {
            InitializeComponent();
            dBConnect = new DBConnect();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(QuaryStatements.STOCK_QUERY, dBConnect.CONNECTION_STRING);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            currentStockGridView.DataSource = dataSet.Tables[0];
        }

        private void currentStockGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = currentStockGridView.Rows[e.RowIndex];
                tbItemId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool status = false;
            int id = int.Parse(tbItemId.Text);
            int qunatity = int.Parse(tbQunatity.Text);
            status = dBConnect.insertStock(id, qunatity);
            if (status == true)
            {
                MessageBox.Show("Stock Insert Successfully. Product ID is " + id);
                tbItemId.Text = "";
                tbQunatity.Text = "";
            }
            else if (status == false)
            {
                MessageBox.Show("Stock Insertion Failed ");
            }
            
        }
    }
}
