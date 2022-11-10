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
    public partial class RegForm : MaterialForm
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (loginTB.Text != "" || passwordTB.Text != "")
            {
                
                    SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                    string query = "INSERT INTO Users ( Login, Password, Role)";
                    query += " VALUES (@Login, @Password, @Role)";

                    SqlCommand myCommand = new SqlCommand(query, connection);
                    myCommand.Parameters.AddWithValue("@Login", loginTB.Text);
                    myCommand.Parameters.AddWithValue("@Password", passwordTB.Text);
                    myCommand.Parameters.AddWithValue("@Role", false);

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
            else MessageBox.Show("Заполните все пустые поля");
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
