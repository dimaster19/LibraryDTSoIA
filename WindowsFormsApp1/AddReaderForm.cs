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
    public partial class AddReaderForm : MaterialForm
    {
        int updateID = 0;
        
      
        public AddReaderForm()
        {
            InitializeComponent();
            Text = $"Добавить читателя";
        }
        public AddReaderForm(int id)
        {
            InitializeComponent();
            updateID = id;
            Text = $"Изменить читателя #{id}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTB.Text !="" ||  addressTB.Text !="" || phoneTB.Text !=""  )
            {
                if (updateID == 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                    string query = "INSERT INTO Readers (ReaderFullName, ReaderAddress, ReaderPhone)";
                    query += " VALUES (@ReaderFullName, @ReaderAddress, @ReaderPhone)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@ReaderFullName", nameTB.Text);
                    myCommand.Parameters.AddWithValue("@ReaderAddress", addressTB.Text);
                    myCommand.Parameters.AddWithValue("@ReaderPhone", phoneTB.Text);

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
                    finally
                    {
                        connection.Close();

                    }
                }

                else
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                    string query = "UPDATE Readers Set ReaderFullName = @ReaderFullName, ReaderAddress = @ReaderAddress, ReaderPhone = @ReaderPhone WHERE IDReader=@ID";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@ReaderFullName", nameTB.Text);
                    myCommand.Parameters.AddWithValue("@ReaderAddress", addressTB.Text);
                    myCommand.Parameters.AddWithValue("@ReaderPhone", phoneTB.Text);
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
                    finally
                    {
                        connection.Close();

                    }
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Заполните все пустые поля");
        }

        private void AddReaderForm_Load(object sender, EventArgs e)
        {

            if (updateID != 0)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True"))
                {
                    string cmd = "select * from Readers where IDReader=@ID";
                    SqlCommand cmd2 = new SqlCommand(cmd, connection);
                    cmd2.Parameters.AddWithValue("@ID", updateID);
                    connection.Open();
                    SqlDataReader reader = cmd2.ExecuteReader();
                    reader.Read();
                    nameTB.Text = reader[1].ToString();
                    addressTB.Text = reader[2].ToString();
                    phoneTB.Text = reader[3].ToString();
                    connection.Close();
                }
            }

        }
    }
}
