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
    public partial class AddWorkerForm : MaterialForm
    {
        int updateID = 0;
        public AddWorkerForm()
        {
            InitializeComponent();
            Text = $"Добавить сотрудника";
        }
        public AddWorkerForm(int id)
        {
            InitializeComponent();
            updateID = id;
            Text = $"Изменить сотрудника #{id}";
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" || addressTB.Text != "" || phoneTB.Text != "")
            {
                if (updateID == 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                    string query = "INSERT INTO Workers (WorkerFullName, WorkerAddress, WorkerPhone)";
                    query += " VALUES (@WorkerFullName, @WorkerAddress, @WorkerPhone)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@WorkerFullName", nameTB.Text);
                    myCommand.Parameters.AddWithValue("@WorkerAddress", addressTB.Text);
                    myCommand.Parameters.AddWithValue("@WorkerPhone", phoneTB.Text);

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
                    string query = "UPDATE Workers Set WorkerFullName = @WorkerFullName, WorkerAddress = @WorkerAddress, WorkerPhone = @WorkerPhone WHERE IDWorker=@ID";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@WorkerFullName", nameTB.Text);
                    myCommand.Parameters.AddWithValue("@WorkerAddress", addressTB.Text);
                    myCommand.Parameters.AddWithValue("@WorkerPhone", phoneTB.Text);
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
            else MessageBox.Show("Заполните все пустые поля");
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {
            if (updateID != 0)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True"))
                {
                    string cmd = "select * from Workers where IDWorker=@ID";
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
