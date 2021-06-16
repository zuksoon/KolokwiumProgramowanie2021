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

namespace Kolokwiumw61919
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

        private void BtnNettoNaBrutto_Click(object sender, RoutedEventArgs e)
        {
            
            double kwotaNetto = 0;
            double SamaKwotaBrutto = 0;
            try
            {
                kwotaNetto = double.Parse(TextBoxNetto1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadzono błędne dane !");
            }

            if (ComboBoxNettoNaBrutto.SelectedIndex < 0)
            {
                MessageBox.Show("Nie wybrano kwoty Vat !");
            }
            else
            {
                if(ComboBoxNettoNaBrutto.SelectedIndex == 0)
                {
                    SamaKwotaBrutto = (kwotaNetto * 23)/100;
                    TextBoxBrutto1.Text = (kwotaNetto + SamaKwotaBrutto).ToString();
                }
                if (ComboBoxNettoNaBrutto.SelectedIndex == 1)
                {
                    SamaKwotaBrutto = (kwotaNetto * 8) / 100;
                    TextBoxBrutto1.Text = (kwotaNetto + SamaKwotaBrutto).ToString();
                }
                if (ComboBoxNettoNaBrutto.SelectedIndex == 2)
                {
                    SamaKwotaBrutto = (kwotaNetto * 7) / 100;
                    TextBoxBrutto1.Text = (kwotaNetto + SamaKwotaBrutto).ToString();
                }
                if (ComboBoxNettoNaBrutto.SelectedIndex == 3)
                {
                    SamaKwotaBrutto = (kwotaNetto * 5) / 100;
                    TextBoxBrutto1.Text = (kwotaNetto + SamaKwotaBrutto).ToString();
                }
                if (ComboBoxNettoNaBrutto.SelectedIndex == 4)
                {
                    TextBoxBrutto1.Text = kwotaNetto.ToString();
                }
            }
        }

        private void BtnBruttoNaNetto_Click(object sender, RoutedEventArgs e)
        {
            double kwotaBrutto = 0;
            double SamaKwotaNetto = 0;
            try
            {
                kwotaBrutto = double.Parse(TextBoxBrutto2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadzono błędne dane !");
            }

            if (ComboBoxBruttoNaNetto.SelectedIndex < 0)
            {
                MessageBox.Show("Nie wybrano kwoty Vat !");
            }
            else
            {
                if (ComboBoxBruttoNaNetto.SelectedIndex == 0)
                {
                    SamaKwotaNetto = (kwotaBrutto * 23) / 100;
                    TextBoxNetto2.Text = (kwotaBrutto - SamaKwotaNetto).ToString();
                }
                if (ComboBoxBruttoNaNetto.SelectedIndex == 1)
                {
                    SamaKwotaNetto = (kwotaBrutto * 8) / 100;
                    TextBoxNetto2.Text = (kwotaBrutto - SamaKwotaNetto).ToString();
                }
                if (ComboBoxBruttoNaNetto.SelectedIndex == 2)
                {
                    SamaKwotaNetto = (kwotaBrutto * 7) / 100;
                    TextBoxNetto2.Text = (kwotaBrutto - SamaKwotaNetto).ToString();
                }
                if (ComboBoxBruttoNaNetto.SelectedIndex == 3)
                {
                    SamaKwotaNetto = (kwotaBrutto * 5) / 100;
                    TextBoxNetto2.Text = (kwotaBrutto - SamaKwotaNetto).ToString();
                }
                if (ComboBoxBruttoNaNetto.SelectedIndex == 4)
                {
                    TextBoxNetto2.Text = kwotaBrutto.ToString();
                }
            }
        }
    }
}
