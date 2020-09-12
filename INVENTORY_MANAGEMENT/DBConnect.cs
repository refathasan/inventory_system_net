using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using INVENTORY_MANAGEMENT;
using MySql.Data.MySqlClient;

public class DBConnect
{
	private MySqlConnection connection;
	private string server;
	private string database;
	private string uid;
	private string password;
    //invConnectionString
    public string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["invConnectionString"].ConnectionString;
    public DBConnect()
	{
		Initialize();
	}
	private void Initialize()
    {
		server = "127.0.0.1";
		database = "inventory_management";
		uid = "root";
		password = "";
		string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
		connection = new MySqlConnection(connectionString);
	}

	private bool openConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            //When handling errors, you can your application's response based 
            //on the error number.
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }
	private bool closeConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }

    }
    public bool insertInventory(int productID, string productName,string productDescription, int productUnitPrice)
    {
        MySqlConnection mySqlConnection = new MySqlConnection(CONNECTION_STRING);
        mySqlConnection.Open();
        MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
        mySqlCommand.CommandText = QuaryStatements.ADD_INVENTORY;
        mySqlCommand.Parameters.AddWithValue("@inv_id",productID );
        mySqlCommand.Parameters.AddWithValue("@inv_name", productName);
        mySqlCommand.Parameters.AddWithValue("inv_description", productDescription);
        mySqlCommand.Parameters.AddWithValue("inv_unit_price", productUnitPrice);

        if (mySqlCommand.ExecuteNonQuery() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public bool insertStock(int productID, int productQunatity )
    {
        MySqlConnection mySqlConnection = new MySqlConnection(CONNECTION_STRING);
        mySqlConnection.Open();
        MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
        mySqlCommand.CommandText = QuaryStatements.INSERT_STOCK_QUANTITY;
        mySqlCommand.Parameters.AddWithValue("@stock_id", productID);
        mySqlCommand.Parameters.AddWithValue("@stock_qunantity", productQunatity);

        if (mySqlCommand.ExecuteNonQuery() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
