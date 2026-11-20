using prakt7_trifonov_trpo.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prakt7_trifonov_trpo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WarehouseItem item = new WarehouseItem
            {
                Name = "Клавиатура механическая",
                UnitPrice = 3500.50m,
                Quantity = 10,
                MinimumStock = 5
            };

            this.DataContext = item;
        }
    }
}