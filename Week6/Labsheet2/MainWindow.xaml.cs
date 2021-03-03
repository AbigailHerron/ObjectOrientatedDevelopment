/*######################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 03/03/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Week6/Labsheet2/MainWindow.xaml.cs

 Description:
 Properties: lbxCustomers, lbxOrderSum, dgOrderDet
 Methods: Window_Loaded, lbxCustomers_SelectionChanged, lbxOrderSum_SelectionChanged
 ######################################################################################################################*/
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

namespace Labsheet2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*VARIABLES-------------------------------------------------------------------------------------------------------------------------------*/
        AdventureLiteEntities db = new AdventureLiteEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        /*Method: Window_Loaded
                  1) Executes when window is loaded
                  2) Populates lbxCustomers*/
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from o in db.SalesOrderHeaders
                        orderby o.Customer.CompanyName
                        select o.Customer.CompanyName;

            // Populating lbxCustomers
            lbxCustomers.ItemsSource = query.ToList().Distinct();
        }// end Window_Loaded()

        /*Method: lbxCustomers_SelectionChanged
                  1) Executes when an item in lbxCustomers is selected
                  2) Retrieves the selected item's value as a string
                  3) Queries the database SalesOrderHeaders for a match to the value
                     as long as the value is not null 
                  4) Updates lbxOrderSum */
        private void lbxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {  /*Note: Partial Class for SalesOrderHeader was used to override ToString() method */
            // Grabbing string value of selected item
            string cust = lbxCustomers.SelectedItem as string;

            if(cust != null)
            {
                var query = from o in db.SalesOrderHeaders
                            where o.Customer.CompanyName.Equals(cust)
                            select o;

                //Updating lbxOrderSum
                lbxOrderSum.ItemsSource = query.ToList();
            }// end if block
        }// end lbxCustomers_SelectionChanged()


        /*Method: lbxOrderSum_SelectionChanged
                  1) Executes when an item in lbxCOrderSum is selected
                  2) Retrieve and converts the selected value to an int
                  3) Queries the SalesOrderDetails table in the database for a match
                  4) Updates dgOrderDet with query results */
        private void lbxOrderSum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Grabbing the selected value and converting it to an int
            int orderID = Convert.ToInt32(lbxOrderSum.SelectedValue);

            if (orderID > 0)
            {
                var query = from od in db.SalesOrderDetails
                            where od.SalesOrderID == orderID
                            select new
                            {
                                ProductName = od.Product.Name,
                                od.UnitPrice,
                                od.UnitPriceDiscount,
                                od.OrderQty,
                                od.LineTotal
                            };

                // Updating dgOrderDet
                dgOrderDet.ItemsSource = query.ToList();
            }// end if block
        }// end lbxOrderSum_SelectionChanged()

    }// end MainWindow class
}// end Namespace
