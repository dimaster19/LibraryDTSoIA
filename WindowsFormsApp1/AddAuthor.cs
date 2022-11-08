using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddAuthor : MaterialForm
    {
        private int addID;
        public AddAuthor()
        {
            InitializeComponent();
        }

        public AddAuthor(int i)
        {
            InitializeComponent();
            Text = "Добавить автора";
            if (i == 0) { Text = "Добавить автора"; addID = 0; addLabel.Text = "Полное имя"; }
            else if (i == 1) { Text = "Добавить издателя"; addID = 1; addLabel.Text = "Название"; }
            else { Text = "Добавить жанр"; addID = 2; addLabel.Text = "Название"; }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addTB.Text != "")
            {
                if (addID == 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                    string query = "INSERT INTO Authors (AuthorFullName)";
                    query += " VALUES (@AuthorFullName)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@AuthorFullName", addTB.Text);
                    connection.Open();

                    try
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Поле заполнено не верно!");
                        return;
                    }
                    connection.Close();
                }
                else if (addID == 1)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                    string query = "INSERT INTO Publishers (PublisherFullName)";
                    query += " VALUES (@PublisherFullName)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@PublisherFullName", addTB.Text);
                    connection.Open();

                    try
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Поле заполнено не верно!");
                        return;
                    }
                    connection.Close();
                }
                else
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                    string query = "INSERT INTO Genres (GenreName)";
                    query += " VALUES (@GenreName)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@GenreName", addTB.Text);
                    connection.Open();

                    try
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Поле заполнено не верно!");
                        return;
                    }
                    connection.Close();

                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Поле заполнено не верно!");


        }
    }
}
