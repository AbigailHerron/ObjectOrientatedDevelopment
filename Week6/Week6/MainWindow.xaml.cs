/*##################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 03/03/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Week6/Week6/MainWindow.xaml.cs

 Description: Contains definitions for how our window opperates
                 i.e. When a ListBox object is selected, the other ListBox objects will get updated
 Properties: lbxStock, lbxSuppliers, lbxCountries
 Methods: Window_Loaded, 
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
    /// 
    public partial class MainWindow : Window
    {
        /*VARIABLES-------------------------------------------------------------------------------------------------------------------------------*/
        NORTHWNDEntities db = new NORTHWNDEntities(); // importing database as a new object

        public MainWindow()
        {
            InitializeComponent();
        }// end MainWindow()

        /*EVENT BASED METHODS--------------------------------------------------------------------------------------------------------------------*/
        /*Method: Window_Loaded
                  1) Executes as soon as the window is loaded
                  2) Populates lbxStock
                  3) Uses queries to populate both lbxSuppliers and lbxCountries */
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Populating lbxStock                     
            lbxStock.ItemsSource = Enum.GetNames(typeof(StockLevel)); /* Note: Enum StockLevel is defined        |
                                                                      |         just after the MainWindow Class */
            // Using query1 to get the list of Suppliers
            var query1 = from s in db.Suppliers
                         orderby s.CompanyName
                         select new
                         {
                             SupplierName = s.CompanyName,
                             SupplierID = s.SupplierID,
                             Country = s.Country
                         };
            // Populating lbxSuppliers with query1 results
            lbxSuppliers.ItemsSource = query1.ToList();

            
            // Using query2 to get the list of Countries of Suppliers
            var query2 = query1   // Using query1 to build query2
                .OrderBy(s => s.Country)
                .Select(s => s.Country);

            // Populating lbxCountries with query2 distinct results
            lbxCountries.ItemsSource = query2.ToList().Distinct();
        }// end Window_Loaded()



        /*Method: lbxStock_SelectionChanged()
                  1) */
        private void lbxStock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }// end lbxStock_SelectionChanged()



        /*Method: lbxSuppliers_SelectionChanged()
                  1) */
        private void lbxSuppliers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }// end lbxSuppliers_SelectionChanged()



        /*Method: lbxCountries_SelectionChanged()
                  1) */
        private void lbxCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }// end lbxCountries_SelectionChanged()
    }// end MainWindow class
    /*SHARED ITEMS-------------------------------------------------------------------------------------------------------------------------------*/
    public enum StockLevel { Low, Normal, Overstocked };
}// end Namespace
