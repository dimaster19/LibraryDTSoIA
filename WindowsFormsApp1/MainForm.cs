using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace WindowsFormsApp1
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "Главная";
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown700, Primary.Brown800, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form f = new BooksForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Form f = new ReadersForm();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

            Form f = new WorkersForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void givenBooksButton_Click(object sender, EventArgs e)
        {
            Form f = new GivenBooksForm();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
