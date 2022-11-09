using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class BooksForm : MaterialForm
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshData();
            Text = "Книги";
          
        }

        private void RefreshData()
        {
            bookLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            string cmd = $"SELECT Books.BookID, Books.BookName, Authors.AuthorFullName, Genres.GenreName, Publishers.PublisherFullName FROM books left join Authors ON Books.AuthorID = Authors.IDAuthor left join Genres ON Books.GenreID = Genres.IDGenre left join Publishers ON Books.PublisherID = Publishers.IDPublisher";
            connection.Open();
            // ---------ЭТО ВЫВОД В DATAGRIDVIEW--------
            //da.SelectCommand = new SqlCommand(cmd, connection);
            //da.Fill(ds, "books");
            //dataGridView1.DataSource = ds.Tables[0];
            dataReader = new SqlCommand(cmd, connection).ExecuteReader();
            ListViewItem item = null;
            while (dataReader.Read())
            {
                item = new ListViewItem(new string[] { Convert.ToString(dataReader["BookID"]), Convert.ToString(dataReader["BookName"]), Convert.ToString(dataReader["AuthorFullName"]), Convert.ToString(dataReader["GenreName"]), Convert.ToString(dataReader["PublisherFullName"]) });
                bookLV.Items.Add(item);
            }
            da.Dispose();
            connection.Close();
            ds.Dispose();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
            RefreshData();  
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
            try { 
                foreach (int i in bookLV.SelectedIndices)
                 {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                    string temp = bookLV.Items[i].Text;
                    string cmd = "delete from Books where BookID='" + temp + "'";
                    SqlCommand myCommand = new SqlCommand(cmd, connection);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    bookLV.Items.Remove(bookLV.Items[i]);
                }
 
            RefreshData();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("УДАЛИТЕ или ИЗМЕНИТЕ все поля таблиц, в которых используется эта книга. \n\n", "Ошибка связи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            foreach (int i in bookLV.SelectedIndices)
            {

                int id = int.Parse(bookLV.Items[i].Text);
                AddBookForm addBookForm = new AddBookForm(id);
                addBookForm.ShowDialog();
                RefreshData();
            }

        }

        private void addAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthorForm = new AddAuthor(0);
            addAuthorForm.ShowDialog();
            RefreshData();
         
        }

        private void addPublisher_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthorForm = new AddAuthor(1);
            addAuthorForm.ShowDialog();
            RefreshData();
           
        }

        private void addGenre_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthorForm = new AddAuthor(2);
            addAuthorForm.ShowDialog();
            RefreshData();
            
        }
    }
}
