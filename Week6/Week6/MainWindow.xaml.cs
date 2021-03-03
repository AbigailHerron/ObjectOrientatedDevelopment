/*##################################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 03/03/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Week6/Week6/MainWindow.xaml.cs

 Description: Contains definitions for how our window opperates
                 i.e. When a ListBox object is selected, the other ListBox objects will get updated
 Properties: lbxStock, lbxSuppliers, lbxCountries, lbxProducts
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
                  1) Executes when an item in lbxStock is selected
                  2) Updates lbxProducts based on the switch criteria
                      (i.e. Low = UnitsInStock < 50, Normal = UnitsInStock > 50 and < 100
                            Overstocked = UnitsInStock > 100) */
        private void lbxStock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // get stock level selected
            var query = from p in db.Products
                        where p.UnitsInStock < 50
                        orderby p.ProductName
                        select p.ProductName;

            string selected = lbxStock.SelectedItem as string;

            switch(selected)
            {
                case "Low":
                    break;
                case "Normal":
                    query = from p in db.Products
                            where (p.UnitsInStock >= 50) && (p.UnitsInStock <= 100)
                            orderby p.ProductName
                            select p.ProductName;
                    break;
                case "Overstocked":
                    query = from p in db.Products
                            where p.UnitsInStock > 100
                            orderby p.ProductName
                            select p.ProductName;
                    break;
            } // end switch block

            // Updating lbxProducts
            lbxProducts.ItemsSource = query.ToList();
        }// end lbxStock_SelectionChanged()


        /*Method: lbxSuppliers_SelectionChanged()
                  1) Executes when an item in lbxSuppliers is selected
                  2) Retrieves and converts the Value Path of the item to an int value
                  3) Queries the database for Products sold by Suppliers that match the int value
                  4) Updates lbxProducts */
        private void lbxSuppliers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Using the 'Selected Value Path'
            int supplierID = Convert.ToInt32(lbxSuppliers.SelectedValue);

            // MessageBox.Show(supplierID.ToString());

            var query = from p in db.Products
                        where p.SupplierID == supplierID
                        orderby p.ProductName
                        select p.ProductName;

            // Update lbxProducts
            lbxProducts.ItemsSource = query.ToList();
        }// end lbxSuppliers_SelectionChanged()



        /*Method: lbxCountries_SelectionChanged()
                  1) Eecutes when an item in lbxCountry is selected
                  2) Gets the string value of the selected item
                  3) Queries the database for all matching Products that link to the Country field
                  4) Updates lbxProducts with query results */
        private void lbxCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string country = (string)(lbxCountries.SelectedValue);

            var query = from p in db.Products
                        where p.Supplier.Country == country
                        orderby p.ProductName
                        select p.ProductName;

            // Update lbxProducts
            lbxProducts.ItemsSource = query.ToList();
        }// end lbxCountries_SelectionChanged()
    }// end MainWindow class
    /*SHARED ITEMS-------------------------------------------------------------------------------------------------------------------------------*/
    public enum StockLevel { Low, Normal, Overstocked };
}// end Namespace
