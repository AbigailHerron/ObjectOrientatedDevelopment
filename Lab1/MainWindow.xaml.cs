/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/01/21
 GitHub Repository Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Lab1/MainWindow.xaml.cs
 
 Description:
 Variables:
 Methods:
 ##########################################################################################################################*/
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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }// end MainWindow

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band b1 = new Band();
            Band b2 = new Band("ABBA", 1972, "Agnetha Fältskog, Björn Ulvaeus, Benny Andersson, Anni-Frid Lyngstad");
            Band b3 = new Band("Heart", 1970, "Ann Wilson, Nancy Wilson, Denny Fongheiser, Craig Bartock, Ryan Waters, Dan Walker, Andy Stoller");
            Band b4 = new Band("Kiss", 1973, "Paul Stanley, Gene Simmons, Peter Criss, Ace Frehley");
            Band b5 = new Band("Boppins", 2010, "Crazy Lady, Brass Tax");
            Band b6 = new Band("In This Moment", 2005, "Maria Brink, Chris Howorth, Travis Johnson, Randy Weitzel, Kent Diimmel");

        }// end Window_Loaded
    }// end MainWindow Class
}// end Namespace
