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

namespace PaymentsExampleApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Payments21Entities _context = new Payments21Entities();
        public MainWindow()
        {
            InitializeComponent();
            ChartPayments.ChartAreas.Add(new ChartArea("Main "));

            var currentSeries = new Series("Payments");
            {
                 = true;
            };

        }
    }
}
