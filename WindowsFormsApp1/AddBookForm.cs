using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddBookForm : MaterialSkin.Controls.MaterialForm
    {
        int updateID = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        string sql1 = "SELECT * FROM Authors";
        string sql2 = "SELECT * FROM Genres";
        string sql3 = "SELECT * FROM Publishers";
        DataSet ds;
        SqlDataAdapter adapter;
        public AddBookForm()
        {
            InitializeComponent();
            Text = "Добавить книгу";
        }
        public AddBookForm(int id)
        {
            InitializeComponent();
            updateID = id;
            Text = $"Изменить книгу #{id}";
        }
        private void saveButton_Click(object sender, EventArgs e)
        {

            if (bookNameTB.Text != "")
            {
                if (updateID == 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                    string query = "INSERT INTO Books (AuthorID, PublisherID, GenreID, BookName)";
                    query += " VALUES ( @AuthorID, @PublisherID, @GenreID, @BookName)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@AuthorID", authorCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@PublisherID", publisherCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@GenreID", genreCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@BookName", bookNameTB.Text);
                    connection.Open();

                    try
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Одно из полей заполнено не верно!");
                       
                    }
                    finally
                    {
                        connection.Close();

                    }
                }

                else
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                    //string query = "INSERT INTO Books (AuthorID, PublisherID, GenreID, BookName)";
                    string query = "UPDATE Books Set AuthorID = @AuthorID, PublisherID = @PublisherID, GenreID = @GenreID, BookName = @BookName   WHERE BookID=@ID";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@AuthorID", authorCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@PublisherID", publisherCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@GenreID", genreCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@BookName", bookNameTB.Text);
                    myCommand.Parameters.AddWithValue("@ID", updateID);
                    connection.Open();

                    try
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Одно из полей заполнено не верно!");
                        return;
                    }
                    finally { connection.Close(); }
                  
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Заполните название книги");
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
          
                using (connection)
                {
                    adapter = new SqlDataAdapter(sql1, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    authorCB.DataSource = ds.Tables[0];
                    authorCB.DisplayMember = "AuthorFullName";
                    authorCB.ValueMember = "IDAuthor";
                    adapter = new SqlDataAdapter(sql2, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    genreCB.DataSource = ds.Tables[0];
                    genreCB.DisplayMember = "GenreName";
                    genreCB.ValueMember = "IDGenre";
                    adapter = new SqlDataAdapter(sql3, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    publisherCB.DataSource = ds.Tables[0];
                    publisherCB.DisplayMember = "PublisherFullName";
                    publisherCB.ValueMember = "IDPublisher";
                    connection.Close();
            }
               

            if (updateID != 0)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True"))
                {
                    string cmd = "select * from Books where BookID=@ID";
                    SqlCommand cmd2 = new SqlCommand(cmd, connection);
                    cmd2.Parameters.AddWithValue("@ID", updateID);
                    connection.Open();
                    SqlDataReader reader = cmd2.ExecuteReader();
                    reader.Read();
                    authorCB.SelectedValue = reader[1].ToString();
                    publisherCB.SelectedValue = reader[2].ToString();
                    genreCB.SelectedValue = reader[3].ToString();
                    bookNameTB.Text = reader[4].ToString();
                    connection.Close();
                }
            }
           
        }
    }
}
