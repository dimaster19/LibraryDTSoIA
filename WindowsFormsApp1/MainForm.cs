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
        private readonly CheckUser _user;
        
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(CheckUser user)
        {
            InitializeComponent();
            Text = "Главная";
            _user = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(_user.IsAdmin == true)
            {
                materialLabel1.Text = _user.Login + " (Админ)";
            }
            else
            {
                materialButton3.Enabled = false;
                materialLabel1.Text = _user.Login + " (Пользователь)";

            }
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }
    }
}
