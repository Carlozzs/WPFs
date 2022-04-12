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
using System.Windows.Shapes;
using System.Media;
namespace Login2
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SoundPlayer urn = new SoundPlayer(@"C:\Users\70393960250\Desktop\prototipo 2.1\Login2-master\Login2\Assets\urna.wav");//urna
        SoundPlayer clk = new SoundPlayer(@"C:\Users\70393960250\Desktop\prototipo 2.1\Login2-master\Login2\Assets\click urna.wav");//click urna

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            urn.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            clk.Play();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }
    }
}
