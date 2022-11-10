using System;
using MaterialSkin.Controls;
using MaterialSkin;
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
using System.Windows.Documents;

namespace WindowsFormsApp1
{
    public partial class AuthForm : MaterialForm
    {
        public AuthForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown700, Primary.Brown800, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string cmd = null;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            try
            {
                using (connection)
                {

                    cmd = "SELECT * FROM Users  WHERE Login = '" + loginTB.Text + "' and Password = '" + passwordTB.Text + "'";

                    SqlCommand myCommand = new SqlCommand(cmd, connection);
                    da.SelectCommand = myCommand;
                    da.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                        var user = new CheckUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));
                        MessageBox.Show("Вы успешно авторизовались", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainForm f = new MainForm(user);
                        f.ShowDialog();
                        this.Show();

                    }
                    else
                    {
                        MessageBox.Show("Такого аккаунта не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




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

        private void regButton_Click(object sender, EventArgs e)
        {
            Form f = new RegForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

 

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            passwordTB.Password = true;
        }
    }
}
