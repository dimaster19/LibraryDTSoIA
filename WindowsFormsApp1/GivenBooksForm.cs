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
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
            RefreshData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
