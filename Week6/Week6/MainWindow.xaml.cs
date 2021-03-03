/*##################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 03/03/21
 GitHub Link: 

 Description: Contains definitions for how our window opperates
                 i.e. When a ListBox object is selected, the other ListBox objects will get updated
 Properties:
 Methods:
 ##################################################################################################################################################*/
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

namespace Week6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
