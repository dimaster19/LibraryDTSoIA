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
    public partial class AddGivenBookForm : MaterialForm
    {

        int updateID = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        string sql1 = "SELECT * FROM Books";
        string sql2 = "SELECT * FROM Readers";
        string sql3 = "SELECT * FROM Workers";
        DataSet ds;
        SqlDataAdapter adapter;
        public AddGivenBookForm()
        {
            InitializeComponent();
            Text = $"Выдать книгу";
        }
        public AddGivenBookForm(int id)
        {
            InitializeComponent();
            updateID = id;
            Text = $"Изменить выдачу #{id}";
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dateStartTB.Text != "")
            {
                if (updateID == 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                    string query = "INSERT INTO GivenBooks (BookID, ReaderID, DateStart, DateEnd, WorkerID)";
                    query += " VALUES ( @BookID, @ReaderID, @DateStart, @DateEnd, @WorkerID)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@BookID", bookCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@ReaderID", readerCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@DateStart", dateStartTB.Text);
                    myCommand.Parameters.AddWithValue("@DateEnd", dateEndTB.Text);
                    myCommand.Parameters.AddWithValue("@WorkerID", workerCB.SelectedValue);
            
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
                    connection.Close();
                }

                else
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                    string query = "UPDATE GivenBooks Set BookID = @BookID, ReaderID = @ReaderID, DateStart = @DateStart, DateEnd = @DateEnd, WorkerID = @WorkerID   WHERE GivenID=@ID";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@BookID", bookCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@ReaderID", readerCB.SelectedValue);
                    myCommand.Parameters.AddWithValue("@DateStart", dateStartTB.Text);
                    myCommand.Parameters.AddWithValue("@DateEnd", dateEndTB.Text);
                    myCommand.Parameters.AddWithValue("@WorkerID", workerCB.SelectedValue);
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
                    connection.Close();
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Заполните название книги");
        }

        private void AddGivenBookForm_Load(object sender, EventArgs e)
        {
            using (connection)
            {
                adapter = new SqlDataAdapter(sql1, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                bookCB.DataSource = ds.Tables[0];
                bookCB.DisplayMember = "BookName";
                bookCB.ValueMember = "BookID";
                adapter = new SqlDataAdapter(sql2, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                readerCB.DataSource = ds.Tables[0];
                readerCB.DisplayMember = "ReaderFullName";
                readerCB.ValueMember = "IDReader";
                adapter = new SqlDataAdapter(sql3, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                workerCB.DataSource = ds.Tables[0];
                workerCB.DisplayMember = "WorkerFullName";
                workerCB.ValueMember = "IDWorker";
                connection.Close();
            }


            if (updateID != 0)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True"))
                {
                    string cmd = "select * from GivenBooks where GivenID=@ID";
                    SqlCommand cmd2 = new SqlCommand(cmd, connection);
                    cmd2.Parameters.AddWithValue("@ID", updateID);
                    connection.Open();
                    SqlDataReader reader = cmd2.ExecuteReader();
                    reader.Read();
                    bookCB.SelectedValue = reader[1].ToString();
                    readerCB.SelectedValue = reader[2].ToString();
                    workerCB.SelectedValue = reader[5].ToString();
                    connection.Close();
                }
            }

        }
    }
}
