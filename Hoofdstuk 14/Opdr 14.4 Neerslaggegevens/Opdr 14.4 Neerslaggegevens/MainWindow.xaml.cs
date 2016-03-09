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

namespace Opdr_14._4_Neerslaggegevens
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

        int[] maxtemp = { 7, 11, 8, 9, 8, 9, 9, 8, 9, 9, 8, 8, 7, 6, 5, 7, 4, -1, 2, 2, 4, 5, 8, 9, 16, 12, 12, 9, 10, 9, 13 };  //in graden Celcius

        int[] mintemp = { 4, 8, 7, 7, 7, 6, 6, 6, 7, 8, 4, 7, 4, 3, 2, 3, 0, -4, -2, 0, 0, 0, 6, 7, 11, 10, 11, 7, 7, 7, 8 }; // in graden Celcius

        double[] neerslag = { 0.00, 0.51, 2.03, 0.00, 0.25, 1.02, 13.97, 0.00, 0.25, 0.51, 2.03, 6.10, 2.03, 4.06, 21.08, 0.76, 0.00, 0.00, 0.00, 0.51, 0.00, 4.06, 0.00, 1.02, 0.00, 2.03, 3.05, 0.00, 0.25, 16.00, 1.02 }; //in millimeter

        int[] windsnelheid = { 13, 16, 23, 14, 14, 8, 18, 16, 13, 21, 14, 19, 23, 19, 21, 14, 8, 8, 5, 8, 6, 11, 14, 16, 13, 18, 27, 16, 24, 26, 18 }; //in km/u

        int[] windhoek = { 152, 143, 174, 193, 170, 146, 175, 211, 174, 202, 187, 244, 258, 215, 322, 295, 41, 121, 175, 235, 137, 155, 224, 208, 188, 217, 215, 251, 220, 235, 228 }; //hoek in graden

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32(textBox.Text);

            if (index <= 0 || index >= neerslag.Length)
            {
                MessageBox.Show("Waarde moet tussen 0 en " + (neerslag.Length - 1) + " zijn");
            }

            











        }
    }
}
