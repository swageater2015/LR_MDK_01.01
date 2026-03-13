using ClassLibrary1.Data;
using ClassLibrary1.Models;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.WinForms;

namespace rabota13._03._2026
{
    public partial class MainForm : Form
    {
        private DataStorage _storage;
        private ListBox listBox;
        private LiveCharts.WinForms.CartesianChart dailyChart;
        private LiveCharts.WinForms.PieChart pieChart;
        private string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

        public MainForm()
        {
            this.Text = "Салон красоты - Анализ выручки";
            this.Size = new Size(1000, 550);
            this.StartPosition = FormStartPosition.CenterScreen;

            _storage = new DataStorage();

            listBox = new ListBox();
            listBox.Location = new Point(10, 10);
            listBox.Size = new Size(200, 450);
            listBox.DisplayMember = "Name";
            listBox.DataSource = _storage.Services;
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;

            dailyChart = new LiveCharts.WinForms.CartesianChart();
            dailyChart.Location = new Point(220, 10);
            dailyChart.Size = new Size(360, 250);

            dailyChart.AxisX.Add(new Axis
            {
                Title = "Дни недели",
                Labels = days
            });

            dailyChart.AxisY.Add(new Axis
            {
                Title = "Количество",
                LabelFormatter = value => value.ToString("N0")
            });

            pieChart = new LiveCharts.WinForms.PieChart();
            pieChart.Location = new Point(590, 10);
            pieChart.Size = new Size(360, 250);

            this.Controls.Add(listBox);
            this.Controls.Add(dailyChart);
            this.Controls.Add(pieChart);


            BuildPieChart();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is Service selectedService)
            {
                BuildDailyChart(selectedService);
            }
        }

        private void BuildDailyChart(Service service)
        {
            var series = new SeriesCollection();
            var lineSeries = new LineSeries
            {
                Title = service.Name,
                Values = new ChartValues<int>()
            };

            foreach (string day in days)
            {
                if (service.DailyStats.ContainsKey(day))
                    lineSeries.Values.Add(service.DailyStats[day]);
                else
                    lineSeries.Values.Add(0);
            }

            series.Add(lineSeries);
            dailyChart.Series = series;
        }

        private void BuildPieChart()
        {
            var series = new SeriesCollection();


            Dictionary<Service, decimal> revenues = new Dictionary<Service, decimal>();


            foreach (var s in _storage.Services)
            {
                decimal revenue = 0;
                foreach (var stat in s.DailyStats)
                {
                    revenue += stat.Value * s.Price;
                }
                revenues[s] = revenue;
            }

            foreach (var s in _storage.Services)
            {
                var pieSlice = new PieSeries
                {
                    Title = s.Name,
                    Values = new ChartValues<decimal> { revenues[s] },
                    DataLabels = true
                };


                pieSlice.LabelPoint = point =>
                    $"{s.Name}: {revenues[s]:C0} ({point.Participation * 100:F1}%)";

                series.Add(pieSlice);
            }

            pieChart.Series = series;

        }
    }
}
