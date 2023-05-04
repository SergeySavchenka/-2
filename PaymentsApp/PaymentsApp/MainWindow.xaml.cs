using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaymentsApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Payment_SavchenkoEntities _context = new Payment_SavchenkoEntities();
        public MainWindow()
        {
            InitializeComponent();
            ChartsPayments.ChartAreas.Add(new ChartArea("Main"));

            var currentSeries = new Series("Payment")
            {
                IsValueShownAsLabel = true
            };
            ChartsPayments.Series.Add(currentSeries);

            ComboUsers.ItemsSource = _context.User.ToList();
            ComboChartsTypes.ItemsSource = Enum.GetValues(typeof(SeriesChartType));

        }

        private void UpdateChart(object sender, SelectionChangedEventArgs e)
        {
            if (ComboUsers.SelectedItem is User currentUser && 
                    ComboChartsTypes.SelectedItem is SeriesChartType currentType) 
            {
                Series currentSeries = ChartsPayments.Series.FirstOrDefault();
                currentSeries.ChartType = currentType;
                currentSeries.Points.Clear();

                var categoriesList = _context.Category.ToList();
                foreach(var category in categoriesList)
                {
                    currentSeries.Points.AddXY(category.Name,
                        _context.Payment.ToList().Where(p=>p.User == currentUser
                        && p.Category == category).Sum(p=>p.Price * p.Num));
                }
            }
        }
    }
}
