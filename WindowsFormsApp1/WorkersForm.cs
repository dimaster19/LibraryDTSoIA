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
    public partial class WorkersForm : MaterialForm
    {
        public WorkersForm()
        {
            InitializeComponent();
            Text = "Сотрудники";
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            workerLV.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader dataReader = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            string cmd = $"SELECT * FROM Workers";
            connection.Open();
            dataReader = new SqlCommand(cmd, connection).ExecuteReader();
            ListViewItem item = null;
            while (dataReader.Read())
            {
                item = new ListViewItem(new string[] { Convert.ToString(dataReader["IDWorker"]), Convert.ToString(dataReader["WorkerFullName"]), Convert.ToString(dataReader["WorkerAddress"]), Convert.ToString(dataReader["WorkerPhone"]) });
                workerLV.Items.Add(item);
            }
            da.Dispose();
            connection.Close();
            ds.Dispose();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm();
            addWorkerForm.ShowDialog();
            RefreshData();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (int i in workerLV.SelectedIndices)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                    string temp = workerLV.Items[i].Text;
                    string cmd = "delete from Workers where IDWorker='" + temp + "'";
                    SqlCommand myCommand = new SqlCommand(cmd, connection);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    workerLV.Items.Remove(workerLV.Items[i]);
                    RefreshData();
                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("УДАЛИТЕ или ИЗМЕНИТЕ все поля таблиц, в которых используется этот работник. \n\n", "Ошибка связи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            foreach (int i in workerLV.SelectedIndices)
            {

                int id = int.Parse(workerLV.Items[i].Text);
                AddWorkerForm addWorkerForm = new AddWorkerForm(id);
                addWorkerForm.ShowDialog();
                RefreshData();
            }
        }
    }
}
