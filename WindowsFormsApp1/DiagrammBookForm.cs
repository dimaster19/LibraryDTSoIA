using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DiagrammBookForm : MaterialForm
    {
        int diagID = 0;
        public DiagrammBookForm()
        {
            InitializeComponent();
        }
        public DiagrammBookForm(int i)
        {
            InitializeComponent();
            if (i == 0) { Text = "Круговая диаграмма авторов"; diagID = 0; }
            else if (i == 1) { Text = "Круговая диаграмма издателей"; diagID = 1; }
            else { Text = "Круговая диаграмма жанров"; diagID = 2; }

        }

        private void DiagrammBookForm_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlCommand command = connection.CreateCommand();

            if (diagID == 0)  {
                command.CommandText = "SELECT Authors.AuthorFullName, COUNT(Books.AuthorID) FROM Books left join Authors ON Books.AuthorID = Authors.IDAuthor GROUP BY Authors.AuthorFullName";
                SqlDataAdapter da = new SqlDataAdapter(command);
                //SqlDataReader dataReader = null;
                connection.Open();
                da.Fill(ds, "Books");
                dt = ds.Tables["Books"];
                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
                SeriesCollection piechartData = new SeriesCollection();


                foreach (DataRow row in dt.Rows)
                {
                    piechartData.Add(new PieSeries
                    {
                        Title = Convert.ToString(row[0]),
                        Values = new ChartValues<double> { Convert.ToInt32(row[1]) }

                    });

                }
                pieChart1.Series = piechartData;

                pieChart1.LegendLocation = LegendLocation.Right;

            }
            else if (diagID == 1) {
                command.CommandText = "SELECT Publishers.PublisherFullName, COUNT(Books.PublisherID) FROM Books left join Publishers ON Books.PublisherID = Publishers.IDPublisher GROUP BY Publishers.PublisherFullName";
                SqlDataAdapter da = new SqlDataAdapter(command);
                //SqlDataReader dataReader = null;
                connection.Open();
                da.Fill(ds, "Books");
                dt = ds.Tables["Books"];
                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
                SeriesCollection piechartData = new SeriesCollection();


                foreach (DataRow row in dt.Rows)
                {
                    piechartData.Add(new PieSeries
                    {
                        Title = Convert.ToString(row[0]),
                        Values = new ChartValues<double> { Convert.ToInt32(row[1]) }

                    });

                }
                pieChart1.Series = piechartData;

                pieChart1.LegendLocation = LegendLocation.Right;

            }
            else {
                command.CommandText = "SELECT Genres.GenreName, COUNT(Books.GenreID) FROM Books  left join Genres ON Books.GenreID = Genres.IDGenre GROUP BY  Genres.GenreName";
                SqlDataAdapter da = new SqlDataAdapter(command);
                connection.Open();
                da.Fill(ds, "Books");
                dt = ds.Tables["Books"];
                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
                // Define a collection of items to display in the chart 
                SeriesCollection piechartData = new SeriesCollection();


                foreach (DataRow row in dt.Rows)
                {
                    piechartData.Add(new PieSeries
                    {
                        Title = Convert.ToString(row[0]),
                        Values = new ChartValues<double> { Convert.ToInt32(row[1]) }

                    });

                }
                pieChart1.Series = piechartData;

                pieChart1.LegendLocation = LegendLocation.Right;

            }

            
           

        }
    }
}
