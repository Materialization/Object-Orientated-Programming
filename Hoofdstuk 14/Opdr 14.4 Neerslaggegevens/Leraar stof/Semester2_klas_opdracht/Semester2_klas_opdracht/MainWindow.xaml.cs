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

namespace Semester2_klas_opdracht
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

        int[] regen = { 5, 8, 2, 8, 6, 0, 9 };


        private void button_Click(object sender, RoutedEventArgs e)
        {

            int ind = Convert.ToInt32(textBox.Text);
            int waarde = Convert.ToInt32(textBox1.Text);

            if (ind >= 0 && ind < regen.Length)
            {
                regen[ind] = waarde;
            }

            else MessageBox.Show("Waarde moet tussen 0 en " + (regen.Length - 1) + " zijn");
                

            listBox.Items.Clear();

            for (int i=0; i < regen.Length; i++)
            {
                string tekst = "dag " + (i+1) + " regen: " + regen[i];
                listBox.Items.Add(tekst);
            }

            //Grootste waarde in array zien te vinden
            //Eerste element als beginmaatstaf gebruiken

            int grootste = regen[0];
            int index = 0;

            for (int j = 1; j < regen.Length; j++)
            {
                if (regen[j]> grootste)
                {
                    grootste = regen[j];
                    index = j;
                }

            }

            label.Content = "Grootste waarde op dag " + (index + 1) + " met waarde " + grootste;

        }
    }
}
