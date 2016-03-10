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

namespace Rainfall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int[] regen = { 5, 18, 2, 8, 6, 0, 9 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int ind = Convert.ToInt32(txbIndex.Text);
            int waarde = Convert.ToInt32(txbWaarde.Text);
            if (ind >= 0 && ind < regen.Length)
            {
                regen[ind] = waarde;
            }
            else MessageBox.Show("Waarde moet tussen 0 en " + (regen.Length - 1) + " zijn");

            listBox.Items.Clear();

            for (int i = 0; i < regen.Length; i++)
            {
                string tekst = "dag " + (i + 1) + " regen:" + regen[i];
                listBox.Items.Add(tekst);

            }


            //Grootste waarde in array te zoeken:
            //Eerste element als beginmaatstaf gebruiken
            int grootste = regen[0];
            int index = 0;

            for (int i = 1; i < regen.Length; i++)
            {
                if(regen[i]> grootste)
                {
                    grootste = regen[i];
                    index = i;
                }
            }

            lblGrootste.Content = "Grootste waarde op dag " + (index + 1)
                + "met waarde " + grootste;
                

        }
    }
}
