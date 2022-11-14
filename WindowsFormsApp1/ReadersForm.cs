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
    public partial class ReadersForm : MaterialForm
    {
        public ReadersForm()
        {
            InitializeComponent();
            Text = "Читатели";
        }
        private void ReadersForm_Load(object sender, EventArgs e)
        {
            RefreshData();  
            
        }
        private void RefreshData()
        {
            readerLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            string cmd = $"SELECT * FROM Readers";
            connection.Open();
            dataReader = new SqlCommand(cmd, connection).ExecuteReader();
            ListViewItem item = null;
            while (dataReader.Read())
            {
                item = new ListViewItem(new string[] { Convert.ToString(dataReader["IDReader"]), Convert.ToString(dataReader["ReaderFullName"]), Convert.ToString(dataReader["ReaderAddress"]), Convert.ToString(dataReader["ReaderPhone"]) });
                readerLV.Items.Add(item);
            }
            da.Dispose();
            connection.Close();
            ds.Dispose();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddReaderForm addReaderForm = new AddReaderForm();
            addReaderForm.ShowDialog();
            RefreshData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

            try
            {
                foreach (int i in readerLV.SelectedIndices)
                {
                    string temp = readerLV.Items[i].Text; 
                    string cmd = "delete from Readers where IDReader='" + temp + "'";
                    SqlCommand myCommand = new SqlCommand(cmd, connection);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    readerLV.Items.Remove(readerLV.Items[i]);
                    RefreshData();
                }
              
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("УДАЛИТЕ или ИЗМЕНИТЕ все поля таблиц, в которых используется этот читатель. \n\n", "Ошибка связи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            foreach(int i in readerLV.SelectedIndices)
            {

                int id = int.Parse(readerLV.Items[i].Text);
                AddReaderForm addReaderForm = new AddReaderForm(id);
                addReaderForm.ShowDialog();
                RefreshData();
            }
        }

        private void nameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            readerLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader;
            string cmd;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            try
            {
                using (connection)
                {

                    cmd = string.Format("SELECT * FROM Readers WHERE Readers.ReaderFullName like N'%" + findTextBox.Text + "%' ");
                    connection.Open();

                    ListViewItem item = null;
                    dataReader = new SqlCommand(cmd, connection).ExecuteReader();
                    while (dataReader.Read())
                    {
                        item = new ListViewItem(new string[] { Convert.ToString(dataReader["IDReader"]), Convert.ToString(dataReader["ReaderFullName"]), Convert.ToString(dataReader["ReaderAddress"]), Convert.ToString(dataReader["ReaderPhone"]) });
                        readerLV.Items.Add(item);
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
