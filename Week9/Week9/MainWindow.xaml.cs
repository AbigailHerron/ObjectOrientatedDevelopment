/*#######################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Week9/Week9/MainWindow.xaml.cs
 Date: 24/03/21

 Description: Contains the methods associated with in-class questions for Exerscise Sheet 6
               1) Main focus is on joins and grouping
 #######################################################################################################################*/
using System.Linq;
using System.Windows;

namespace Week9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        // Exercise 1
        private void Ex1Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Categories
                        join p in db.Products
                        on c.CategoryName equals p.Category.CategoryName
                        orderby c.CategoryName
                        select new // annonymous type
                        {
                            Category = c.CategoryName,
                            Product = p.ProductName
                        }; // end query

            var results = query.ToList();
            ex1dgDisplay.ItemsSource = results;
            ex1TblkCount.Text = results.Count.ToString();
        }// end Exercise 1


        // Exercise 2
        private void Ex2Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Products
                        orderby p.Category.CategoryName, p.ProductName
                select new
                {
                    Category = p.Category.CategoryName,
                    Product = p.ProductName
                };// end query

            var results = query.ToList();
            ex2dgDisplay.ItemsSource = results;
            ex2TblkCount.Text = results.Count.ToString();
        }//end Exercise 2


        // Exercise 3
        private void Ex3Button_Click(object sender, RoutedEventArgs e)
        {
            // total number of orders for product no.7
            var query1 = from od in db.Order_Details
                         where od.ProductID == 7
                         select od;

            int numberOfOrders = query1.Count();

            // total value of orders for product no.7
            var query2 = from od in db.Order_Details
                         where od.ProductID == 7
                         select od.UnitPrice * od.Quantity;

            decimal totalValue = query2.Sum();

            // average order value
            decimal averageValue = query2.Average();

            // update screen
            ex3TblkCount.Text = string.Format($"Total number of orders: {numberOfOrders}\nValue of Orders: {totalValue:C}\nAverage Order Value: {averageValue:C}");
        }// end Exercise 3


        // Exercise 4
        private void Ex4Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from customer in db.Customers
                        where customer.Orders.Count >= 20
                        select new
                        {
                            Name = customer.CompanyName,
                            OrderCount = customer.Orders.Count
                        };

            ex4dgDisplay.ItemsSource = query.ToList();

        }// end Exercise 4


        // Exercise 5
        private void Ex5Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from customer in db.Customers
                        where customer.Orders.Count < 3
                        select new
                        {
                            Company = customer.CompanyName,
                            City = customer.City,
                            Region = customer.Region,
                            OrderCount = customer.Orders.Count
                        };

            ex5dgDisplay.ItemsSource = query.ToList();
        }// end Exercise 5


        // Exercise 6
        private void Ex6Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from customer in db.Customers
                        orderby customer.CompanyName
                        select customer.CompanyName;

            ex6lbxCustomers.ItemsSource = query.ToList();
        }

        private void Ex6Button_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string company = (string)ex6lbxCustomers.SelectedItem;

            if(company != null)
            {
                var query = (from detail in db.Order_Details
                             where detail.Order.Customer.CompanyName == company
                             select detail.UnitPrice * detail.Quantity).Sum();

                ex6TblkOrderSummary.Text = string.Format($"Total for supplier {company}\n\n{query:C}");
            }
        }// end Exercise 6


        // Exercise 7
        private void Ex7Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Products
                        group p by p.Category.CategoryName into g
                        orderby g.Count() descending
                        select new
                        {
                            Category = g.Key,
                            Count = g.Count()
                        };

            ex7dgDisplay.ItemsSource = query.ToList();
        }// end Exercise 7
    }// end MainWindow class
}// end Namespace
