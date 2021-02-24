using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // creating new database object from existing db file
        NORTHWNDEntities db = new NORTHWNDEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, RoutedEventArgs e)
        {
            // Ex1 - Customer Names
            var query = from c in db.Customers
                        select c.CompanyName;

        }
    }
}
