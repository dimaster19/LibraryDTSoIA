using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GivenBooksForm : MaterialForm
    {
        public GivenBooksForm()
        {
            InitializeComponent();
            Text = "Выданные книги";
        }

        private void GivenBooksForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            bookLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            string cmd = $"SELECT GivenBooks.GivenID, Books.BookName,Readers.ReaderFullName, GivenBooks.DateStart, GivenBooks.DateEnd,  Workers.WorkerFullName FROM GivenBooks left join Books ON GivenBooks.BookID = Books.BookID left join Readers ON GivenBooks.ReaderID = Readers.IDReader left join Workers ON GivenBooks.WorkerID = Workers.IDWorker\r\n";
            connection.Open();
            // ---------ЭТО ВЫВОД В DATAGRIDVIEW--------
            //da.SelectCommand = new SqlCommand(cmd, connection);
            //da.Fill(ds, "books");
            //dataGridView1.DataSource = ds.Tables[0];
            dataReader = new SqlCommand(cmd, connection).ExecuteReader();
            ListViewItem item = null;
            while (dataReader.Read())
            {
                item = new ListViewItem(new string[] { Convert.ToString(dataReader["GivenID"]), Convert.ToString(dataReader["BookName"]), Convert.ToString(dataReader["ReaderFullName"]), Convert.ToString(dataReader["DateStart"]), Convert.ToString(dataReader["DateEnd"]), Convert.ToString(dataReader["WorkerFullName"]) });
                bookLV.Items.Add(item);
            }
            da.Dispose();
            connection.Close();
            ds.Dispose();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddGivenBookForm addGivenBookForm = new AddGivenBookForm();
            addGivenBookForm.ShowDialog();
            RefreshData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (int i in bookLV.SelectedIndices)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                string temp = bookLV.Items[i].Text;
                bookLV.Items.Remove(bookLV.Items[i]);
                string cmd = "delete from GivenBooks where GivenID='" + temp + "'";
                SqlCommand myCommand = new SqlCommand(cmd, connection);
                connection.Open();
                myCommand.ExecuteNonQuery();
            }

            RefreshData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            foreach (int i in bookLV.SelectedIndices)
            {

                int id = int.Parse(bookLV.Items[i].Text);
                AddGivenBookForm addGivenBookForm = new AddGivenBookForm(id);
                addGivenBookForm.ShowDialog();
                RefreshData();
            }

        }

        private void workerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bookLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader;
            string cmd;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            try
            {
                using (connection)
                {

                    cmd = string.Format("SELECT GivenBooks.GivenID, Books.BookName, Readers.ReaderFullName, GivenBooks.DateStart, GivenBooks.DateEnd,  Workers.WorkerFullName FROM GivenBooks left join Books ON GivenBooks.BookID = Books.BookID left join Readers ON GivenBooks.ReaderID = Readers.IDReader left join Workers ON GivenBooks.WorkerID = Workers.IDWorker where Workers.WorkerFullName like N'%" + findTextBox.Text + "%' ");
                    connection.Open();

                    ListViewItem item = null;
                    dataReader = new SqlCommand(cmd, connection).ExecuteReader();
                    while (dataReader.Read())
                    {
                        item = new ListViewItem(new string[] { Convert.ToString(dataReader["GivenID"]), Convert.ToString(dataReader["BookName"]), Convert.ToString(dataReader["ReaderFullName"]), Convert.ToString(dataReader["DateStart"]), Convert.ToString(dataReader["DateEnd"]), Convert.ToString(dataReader["WorkerFullName"]) });
                        bookLV.Items.Add(item);
                    }
                    da.Dispose();
                    connection.Close();
                    ds.Dispose();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();

            }

        }

        private void readerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bookLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader;
            string cmd;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            try
            {
                using (connection)
                {

                    cmd = string.Format("SELECT GivenBooks.GivenID, Books.BookName,Readers.ReaderFullName, GivenBooks.DateStart, GivenBooks.DateEnd,  Workers.WorkerFullName FROM GivenBooks left join Books ON GivenBooks.BookID = Books.BookID left join Readers ON GivenBooks.ReaderID = Readers.IDReader left join Workers ON GivenBooks.WorkerID = Workers.IDWorker where Readers.ReaderFullName like N'%" + findTextBox.Text + "%' ");
                    connection.Open();
                    ListViewItem item = null;
                    dataReader = new SqlCommand(cmd, connection).ExecuteReader();
                    while (dataReader.Read())
                    {
                        item = new ListViewItem(new string[] { Convert.ToString(dataReader["GivenID"]), Convert.ToString(dataReader["BookName"]), Convert.ToString(dataReader["ReaderFullName"]), Convert.ToString(dataReader["DateStart"]), Convert.ToString(dataReader["DateEnd"]), Convert.ToString(dataReader["WorkerFullName"]) });
                        bookLV.Items.Add(item);
                    }
                    da.Dispose();
                    connection.Close();
                    ds.Dispose();

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                connection.Close();
            }


        }
    }
}
