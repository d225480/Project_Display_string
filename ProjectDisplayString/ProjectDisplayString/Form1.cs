using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDisplayString
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
          
                // Change the username, password and database according to your needs
                // You can ignore the database option if you want to access all of them.
                // 127.0.0.1 stands for localhost and the default port to connect.
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_string;";
                // Your query,
                string query = "SELECT * FROM string";

                // Prepare the connection
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                // Let's do it !
                try
                {
                    // Open the database
                    databaseConnection.Open();

                    // Execute the query
                    reader = commandDatabase.ExecuteReader();

                    // All succesfully executed, now do something

                    // IMPORTANT : 
                    // If your query returns result, use the following processor :

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                            // Do something with every received database ROW
                            string[] row = { reader.GetString(0), reader.GetString(1) };
                            DisplayLabel.Text = row[1];
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }

                    // Finally close the connection
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
      


        // Change the username, password and database according to your needs
        // You can ignore the database option if you want to access all of them.
        // 127.0.0.1 stands for localhost and the default port to connect.
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_string;";
                // Your query,
                string query = "SELECT * FROM string";

                // Prepare the connection
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                // Let's do it !
                try
                {
                    // Open the database
                    databaseConnection.Open();

                    // Execute the query
                    reader = commandDatabase.ExecuteReader();

                    // All succesfully executed, now do something

                    // IMPORTANT : 
                    // If your query returns result, use the following processor :

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                            // Do something with every received database ROW
                            string[] row = { reader.GetString(0), reader.GetString(1) };
                            DisplayLabel.Text = row[1];
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }

                    // Finally close the connection
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
           





        }
        private System.Windows.Forms.Timer timer1;
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updatelabel();
        }

        private void h(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }
        public void updatelabel()
        {  


                // Change the username, password and database according to your needs
                // You can ignore the database option if you want to access all of them.
                // 127.0.0.1 stands for localhost and the default port to connect.
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_string;";
                // Your query,
                string query = "SELECT * FROM string";

                // Prepare the connection
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                // Let's do it !
                try
                {
                    // Open the database
                    databaseConnection.Open();

                    // Execute the query
                    reader = commandDatabase.ExecuteReader();

                    // All succesfully executed, now do something

                    // IMPORTANT : 
                    // If your query returns result, use the following processor :

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                            // Do something with every received database ROW
                            string[] row = { reader.GetString(0), reader.GetString(1) };
                            DisplayLabel.Text = row[1];
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }

                    // Finally close the connection
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
                Thread.Sleep(4000);
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            
        }
    }
}
