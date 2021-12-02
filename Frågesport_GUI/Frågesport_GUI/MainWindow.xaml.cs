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

namespace Frågesport_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kortlek frågor = new Kortlek();
        private Button[] array1 = new Button[4];
        ModerKort mittKort;
        

        public MainWindow()
        {
            InitializeComponent();
            array1[0] = new Button();
            array1[1] = new Button();
            array1[2] = new Button();
            array1[3] = new Button();

            svars_knappar.Children.Add(array1[0]);
            svars_knappar.Children.Add(array1[1]);
            svars_knappar2.Children.Add(array1[2]);
            svars_knappar2.Children.Add(array1[3]);

            array1[0].FontSize = 35;
            array1[0].Margin = new Thickness(60, 60, 60, 60);
            array1[0].HorizontalAlignment = HorizontalAlignment.Left;
            array1[0].Click += new RoutedEventHandler(svar1_Click);
            array1[0].Visibility = Visibility.Collapsed;
            array1[0].Width = 260;
            array1[0].Background = Brushes.Red;

            array1[1].FontSize = 35;
            array1[1].Margin = new Thickness(60, 60, 60, 60);
            array1[1].HorizontalAlignment = HorizontalAlignment.Left;
            array1[1].Click += new RoutedEventHandler(svar2_Click);
            array1[1].Visibility = Visibility.Collapsed;
            array1[1].Width = 260;
            array1[1].Background = Brushes.Red;

            array1[2].FontSize = 35;
            array1[2].Margin = new Thickness(60, 60, 60, 60);
            array1[2].HorizontalAlignment = HorizontalAlignment.Left;
            array1[2].Click += new RoutedEventHandler(svar3_Click);
            array1[2].Visibility = Visibility.Collapsed;
            array1[2].Width = 260;
            array1[2].Background = Brushes.Red;

            array1[3].FontSize = 35;
            array1[3].Margin = new Thickness(60, 60, 60, 60);
            array1[3].HorizontalAlignment = HorizontalAlignment.Left;
            array1[3].Click += new RoutedEventHandler(svar4_Click);
            array1[3].Visibility = Visibility.Collapsed;
            array1[3].Width = 260;
            array1[3].Background = Brushes.Red;

        }


        private void startKnapp_Click(object sender, RoutedEventArgs e)
        {
            mittKort = frågor.Drakort();
            fråga.Text = mittKort.Fråga;
            startKnapp.Visibility = Visibility.Collapsed;
            välkommen.Visibility = Visibility.Collapsed;
            fråga.Visibility = Visibility.Visible;
            array1[0].Visibility = Visibility.Visible;
            array1[1].Visibility = Visibility.Visible;
            array1[2].Visibility = Visibility.Visible;
            array1[3].Visibility = Visibility.Visible;
            emptySpace.Visibility = Visibility.Collapsed;
            array1[0].Content = mittKort.GetSvar();
            List<String> Flersvar = ((Flersvar)mittKort).Getflersvar();
            array1[1].Content = Flersvar[0];
            array1[2].Content = Flersvar[1];
            array1[3].Content = Flersvar[2];
            Blanda_svar();
        }

        private void svar1_Click(object sender, RoutedEventArgs e)
        {
           
            fråga.Visibility = Visibility.Collapsed;
            array1[0].Visibility = Visibility.Collapsed;
            array1[1].Visibility = Visibility.Collapsed;
            array1[2].Visibility = Visibility.Collapsed;
            array1[3].Visibility = Visibility.Collapsed;
            nästaFråga.Visibility = Visibility.Visible;
            if (array1[0].Content == mittKort.GetSvar())
            {
                du_gissade_rätt.Visibility = Visibility.Visible;

                
            }
            else
            {
                du_gissade_fel.Visibility = Visibility.Visible;
            }
            
            

        }  
        
        private void svar2_Click(object sender, RoutedEventArgs e)
        {
            
            fråga.Visibility = Visibility.Collapsed;
            array1[0].Visibility = Visibility.Collapsed;
            array1[1].Visibility = Visibility.Collapsed;
            array1[2].Visibility = Visibility.Collapsed;
            array1[3].Visibility = Visibility.Collapsed;
            nästaFråga.Visibility = Visibility.Visible;
            if (array1[1].Content == mittKort.GetSvar())
            {
                du_gissade_rätt.Visibility = Visibility.Visible;


            }
            else
            {
                du_gissade_fel.Visibility = Visibility.Visible;
            }
        }

        private void svar3_Click(object sender, RoutedEventArgs e)
        {
            
            fråga.Visibility = Visibility.Collapsed;
            array1[0].Visibility = Visibility.Collapsed;
            array1[1].Visibility = Visibility.Collapsed;
            array1[2].Visibility = Visibility.Collapsed;
            array1[3].Visibility = Visibility.Collapsed;
            nästaFråga.Visibility = Visibility.Visible;
            if (array1[2].Content == mittKort.GetSvar())
            {
                du_gissade_rätt.Visibility = Visibility.Visible;


            }
            else
            {
                du_gissade_fel.Visibility = Visibility.Visible;
            }

        }

        private void svar4_Click(object sender, RoutedEventArgs e)
        {
            
            fråga.Visibility = Visibility.Collapsed;
            array1[0].Visibility = Visibility.Collapsed;
            array1[1].Visibility = Visibility.Collapsed;
            array1[2].Visibility = Visibility.Collapsed;
            array1[3].Visibility = Visibility.Collapsed;
            nästaFråga.Visibility = Visibility.Visible;
            if (array1[3].Content == mittKort.GetSvar())
            {
                du_gissade_rätt.Visibility = Visibility.Visible;


            }
            else
            {
                du_gissade_fel.Visibility = Visibility.Visible;
            }
        }

        private void Blanda_svar()
        {
            Random randomGenerator = new Random();
            int i = 0;
            while (i < 10)
            {


                int slump = randomGenerator.Next(0, 4);
                int slump2 = randomGenerator.Next(0, 4);
                string temp = (string)(array1[slump].Content);
                array1[slump].Content = array1[slump2].Content;
                array1[slump2].Content = temp;
                i = i + 1;
            }
        }

        private void nästaFråga_Click(object sender, RoutedEventArgs e)
        {
           
            mittKort = frågor.Drakort();
            if (mittKort == null)
            {
                klar.Visibility = Visibility.Visible;
                startKnapp.Visibility = Visibility.Collapsed;
                välkommen.Visibility = Visibility.Collapsed;
                du_gissade_fel.Visibility = Visibility.Collapsed;
                du_gissade_rätt.Visibility = Visibility.Collapsed;
                nästaFråga.Visibility = Visibility.Collapsed;
            }
            else
            {
                fråga.Text = mittKort.Fråga;
                startKnapp.Visibility = Visibility.Collapsed;
                välkommen.Visibility = Visibility.Collapsed;
                fråga.Visibility = Visibility.Visible;
                array1[0].Visibility = Visibility.Visible;
                array1[1].Visibility = Visibility.Visible;
                array1[2].Visibility = Visibility.Visible;
                array1[3].Visibility = Visibility.Visible;
                emptySpace.Visibility = Visibility.Collapsed;
                du_gissade_fel.Visibility = Visibility.Collapsed;
                du_gissade_rätt.Visibility = Visibility.Collapsed;
                //array1[0].Content = mittKort.GetSvar();
                List<String> Flersvar = ((Flersvar)mittKort).Getflersvar();
                array1[0].Content = Flersvar[0];
                array1[1].Content = Flersvar[1];
                array1[2].Content = Flersvar[2];
                array1[3].Content = Flersvar[3];
                Blanda_svar();
            }
        }




    }
}
