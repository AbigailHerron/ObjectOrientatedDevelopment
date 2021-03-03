/*################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 24/02/21 - 03/03/21

 Description: Some example methods on how to use LINQ
 ################################################################################################################################*/

using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
        }// end MainWindow()

        /*EVENT BASED METHODS----------------------------------------------------------------------------------------------------*/
        /*Exercise 1 -- Customer Names*/
        private void btnQueryEx1_Click(object sender, RoutedEventArgs e)
        {
            // Ex1 - Customer Names
            var query = from c in db.Customers
                        select c.CompanyName;

            lbxCustomersEx1.ItemsSource = query.ToList();
        }// end btnQueryEx1_Click()


        /*Exercise 2 -- Customer Objects*/
        private void btnQueryEx2_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        select c;

            dgCustomersEx2.ItemsSource = query.ToList();
        }// end btnQueryEx2_Click()


        /*Exercise 3 -- Order Information*/
        private void btnQueryEx3_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Orders
                        where o.Customer.City.Equals("London")
                        || o.Customer.City.Equals("Paris")
                        || o.Customer.City.Equals("USA")
                        orderby o.Customer.CompanyName
                        select new // this is a sub-query section
                        {
                            CustomerName = o.Customer.CompanyName,
                            City = o.Customer.City,
                            Address = o.ShipAddress
                        };
            dgCustomersEx3.ItemsSource = query.ToList().Distinct();
        }// end btnQueryEx3_Click()


        /*Exercise 4 -- Product Information*/
        private void btnQueryEx4_Click(object sender, RoutedEventArgs e)
        {
            ShowProducts(dgCustomersEx4);

            //var query = from p in db.Products
            //            where p.Category.CategoryName.Equals("Beverages")
            //            orderby p.ProductID descending
            //            select new // sub-query section
            //            {
            //                p.ProductID,
            //                p.ProductName,
            //                p.Category.CategoryName,
            //                p.UnitPrice
            //            };
            //dgCustomersEx4.ItemsSource = query.ToList();
        }// end btnQueryEx4_Click()


        /*Exercise 5 -- Insert Information*/
        private void btnQueryEx5_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product() { ProductName = "Kickapoo Jungle Joy Juice", UnitPrice = 12.49m, CategoryID = 1 };

            db.Products.Add(p);
            db.SaveChanges();

            ShowProducts(dgCustomersEx5);
        }


        /*Exercise 6 -- Update Product Information*/
        private void btnQueryEx6_Click(object sender, RoutedEventArgs e)
        {
            Product p1 = (db.Products
                .Where(p => p.ProductName.StartsWith("Kick"))
                .Select(p => p)).First();

            p1.UnitPrice = 100m;

            db.SaveChanges();
            ShowProducts(dgCustomersEx6);
        }// end btnQueryEx6_Click()


        /*Exercise 7 -- Update Multiple Product Information*/
        private void btnQueryEx7_Click(object sender, RoutedEventArgs e)
        {
            var products = from p in db.Products
                           where p.ProductName.StartsWith("Kick")
                           select p;

            foreach (var p in products)
            {
                p.UnitPrice = 100m;
            }

            db.SaveChanges();
            ShowProducts(dgCustomersEx7);
        }// end btnQueryEx7_Click()


        /*Exercise 8 -- Delete*/
        private void btnQueryEx8_Click(object sender, RoutedEventArgs e)
        {
            var products = from p in db.Products
                           where p.ProductName.StartsWith("Kick")
                           select p;

            db.Products.RemoveRange(products);
            db.SaveChanges();
            ShowProducts(dgCustomersEx8);
        }// end btnQueryEx8_Click()


        /*Exercise 8 -- Using Stored Proceedure*/
        private void btnQueryEx9_Click(object sender, RoutedEventArgs e)
        {
            var query = db.Customers_By_City("London");

            dgCustomersEx9.ItemsSource = query.ToList();
        }// end btnQueryEx9_Click()


        /*LOGIC BASED METHODS----------------------------------------------------------------------------------------------------*/
        private void ShowProducts(DataGrid dg)
        {
            var query = from p in db.Products
                        where p.Category.CategoryName.Equals("Beverages")
                        orderby p.ProductID descending
                        select new
                        {
                            p.ProductID,
                            p.ProductName,
                            p.Category.CategoryName,
                            p.UnitPrice
                        };

            dg.ItemsSource = query.ToList();
        }// end ShowProducts()

    }// end Class
}// end Namespace
