﻿using MaterialSkin.Controls;
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
        }
        private void ReadersForm_Load(object sender, EventArgs e)
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
            string cmd = $"SELECT * FROM Readers";
            connection.Open();
            dataReader = new SqlCommand(cmd, connection).ExecuteReader();
            ListViewItem item = null;
            while (dataReader.Read())
            {
                item = new ListViewItem(new string[] { Convert.ToString(dataReader["IDReader"]), Convert.ToString(dataReader["ReaderFullName"]), Convert.ToString(dataReader["ReaderAddress"]), Convert.ToString(dataReader["ReaderPhone"]) });
                bookLV.Items.Add(item);
            }
            da.Dispose();
            connection.Close();
            ds.Dispose();

        }
        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}