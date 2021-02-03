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
        /*VARIABLES -------------------------------------------------------------------------------------------------------*/
        List<Band> bands = new List<Band>();


        public MainWindow()
        {
            InitializeComponent();
        }// end MainWindow

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // creating band objects
            PopBand b1 = new PopBand();
            PopBand b2 = new PopBand("ABBA", 1972, "Agnetha Fältskog, Björn Ulvaeus, Benny Andersson, Anni-Frid Lyngstad");
            RockBand b3 = new RockBand("Heart", 1970, "Ann Wilson, Nancy Wilson, Denny Fongheiser, Craig Bartock, Ryan Waters, Dan Walker, Andy Stoller");
            RockBand b4 = new RockBand("Kiss", 1973, "Paul Stanley, Gene Simmons, Peter Criss, Ace Frehley");
            IndieBand b5 = new IndieBand("Boppins", 2010, "Crazy Lady, Brass Tax");
            IndieBand b6 = new IndieBand("In This Moment", 2005, "Maria Brink, Chris Howorth, Travis Johnson, Randy Weitzel, Kent Diimmel");

            // creating random object
            Random r = new Random();

            // creating album objects
            Album a1 = new Album();
            Album a2 = new Album("Now That's What I Call Music", r.Next(1960, 2020), r.Next(1000000, 10000000));

                // ABBA
            Album a3 = new Album("Waterloo", r.Next(1960, 2020), r.Next(1000000, 10000000));
            Album a4 = new Album("Arrival", r.Next(1960, 2020), r.Next(1000000, 10000000));

                // Heart
            Album a5 = new Album("Little Queen", r.Next(1960, 2020), r.Next(1000000, 10000000));
            Album a6 = new Album("Brigade", r.Next(1960, 2020), r.Next(1000000, 10000000));

                // Kiss
            Album a7 = new Album("Psycho Circus", r.Next(1960, 2020), r.Next(1000000, 10000000));
            Album a8 = new Album("Alive II", r.Next(1960, 2020), r.Next(1000000, 10000000));

                // In This Moment
            Album a9 = new Album("Black Widow", r.Next(1960, 2020), r.Next(1000000, 10000000));
            Album a10 = new Album("Beautiful Tragedy", r.Next(1960, 2020), r.Next(1000000, 10000000));

                // Boppins
            Album a11 = new Album("I Don't Know How I Got Here", r.Next(1960, 2020), r.Next(1000000, 10000000));
            Album a12 = new Album("Up Is Not Jump", r.Next(1960, 2020), r.Next(1000000, 10000000));


            // adding albums to respective bands
            b1.AlbumList.Add(a1);
            b1.AlbumList.Add(a2);

            b2.AlbumList.Add(a3);
            b2.AlbumList.Add(a4);

            b3.AlbumList.Add(a5);
            b3.AlbumList.Add(a6);

            b4.AlbumList.Add(a7);
            b4.AlbumList.Add(a8);

            b5.AlbumList.Add(a11);
            b5.AlbumList.Add(a12);

            b6.AlbumList.Add(a9);
            b6.AlbumList.Add(a10);



            // adding band objects to bands list
            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);

            

            // sorting bands list by BandName
            bands.Sort();

            // setting items source of lbxBands
            lbxBands.ItemsSource = bands;

        }// end Window_Loaded


        /*Method: lbxBands_SelectionChanged
                  1) Executes when an item in the lbxBands list box is selected
                  2) Checks if something was selected or not
                  3) Displays band information in the tblkInfoBand text block and
                     lbxAlbums list box */
        private void lbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = lbxBands.SelectedItem as Band;

            if(selectedBand != null)
            {
                lbxAlbums.ItemsSource = selectedBand.AlbumList;
                tblkInfoBand.Text = string.Format($"Formed in {selectedBand.YearFormed}" +
                                     $"/nMembers: {selectedBand.Members}");
            }// end if block
        }// end lbxBands_SelectionChanged()

    }// end MainWindow Class
}// end Namespace
