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

namespace Lab4_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Dollar(object sender, RoutedEventArgs e)
        {

            double rateD1 = Convert.ToDouble(rateD.Text);
            double sumD1 = Convert.ToDouble(sumD.Text);
            double resDoubleD = rateD1 * sumD1;
            resSumD.Text = resDoubleD.ToString(); }
        private void Button_Click_Euro(object sender, RoutedEventArgs e)
        {

            double rateE1 = Convert.ToDouble(rateE.Text);
            double sumE1 = Convert.ToDouble(sumE.Text);
            double resDoubleE = rateE1 * sumE1;
            resSumE.Text = resDoubleE.ToString();
        }
        private void Button_Click_Grivna(object sender, RoutedEventArgs e)
        {

            double rateG1 = Convert.ToDouble(rateG.Text);
            double sumG1 = Convert.ToDouble(sumG.Text);
            double resDoubleG = rateG1 * sumG1;
            resSumG.Text = resDoubleG.ToString();
        }
        private void Button_Click_Drama(object sender, RoutedEventArgs e)
        {
            double rateDr1 = Convert.ToDouble(rateDr.Text);
            double sumDr1 = Convert.ToDouble(sumDr.Text);
            double resDoubleDr = rateDr1 * sumDr1;
            resSumDr.Text = resDoubleDr.ToString();

        }

        private void InchButton_Click(object sender, RoutedEventArgs e)
        {
            double Inch1 = Convert.ToDouble(Inch.Text);
            double InchMeter = Inch1 * 0.025;
            resInch.Text = InchMeter.ToString();
        }
        private void MileButton_Click(object sender, RoutedEventArgs e)
        {
            double Mile1 = Convert.ToDouble(Mile.Text);
            double MileMeter = Mile1 * 1609.34;
            resMile.Text = MileMeter.ToString();
        }
        private void FootButton_Click(object sender, RoutedEventArgs e)
        {
            double Foot1 = Convert.ToDouble(Foot.Text);
            double FootMeter = Foot1 * 0.3;
            resFoot.Text = FootMeter.ToString();
        }
        private void VerstButton_Click(object sender, RoutedEventArgs e)
        {
            double Verst1 = Convert.ToDouble(Verst.Text);
            double VerstMeter = Verst1 * 1066.8;
            resVerst.Text = VerstMeter.ToString();
        }
    }
}
