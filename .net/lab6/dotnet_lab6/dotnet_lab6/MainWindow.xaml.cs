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

namespace dotnet_lab6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int m = int.Parse(m_textbox.Text);
            int v = int.Parse(v_textbox.Text);
            int h = int.Parse(h_textbox.Text);
            e_textbox.Text = (1.0 / 2.0 * m * Math.Pow(v, 2)).ToString();
            p_textbox.Text = (m * 9.81 * h).ToString();
        }
    }
}
