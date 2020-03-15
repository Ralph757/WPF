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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Banner_WPF
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

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        private void Banner(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleanimation = new DoubleAnimation();
            doubleanimation.From = 2;
            doubleanimation.To = 990;
            doubleanimation.Duration = TimeSpan.FromSeconds(1); 

            
            banner.BeginAnimation(WidthProperty, doubleanimation);

        }

       
    }
}
