using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public class DBConnect
{
	private MySqlConnection connection;
	private string server;
	private string database;
	private string uid;
	private string password;	
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
}
