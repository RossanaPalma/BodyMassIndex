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

namespace BodyMassIndex
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
            double weight;
            double height;
            double bmi;
            weight = double.Parse(weightTxtBox.Text);
            height = double.Parse(heightTxtBox.Text);
            bmi = (weight * 720) / (height * height);
            bmiResultTxtBox.Text = bmi.ToString();
           // string healthRange;
            
            if (bmi <= 14)
            {
                bmiCanvas.Background = Brushes.Blue;
                //healthRange = "You are bellow health range.";
            }
            else if (bmi > 14 && bmi <= 26)
            {
                bmiCanvas.Background = Brushes.Green;
               // healthRange = "You are healthy!";
            }
            else if (bmi > 27)
            {
                bmiCanvas.Background = Brushes.Yellow;
                //healthRange = "You are above health range.";
            }
            messageUser.Text = ("Your Body Mass Index is " + bmi+ ".");
        }
    }
}
