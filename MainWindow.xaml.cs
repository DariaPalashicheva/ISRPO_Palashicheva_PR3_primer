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

namespace ISRPO_Palashicheva_PR3_primer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            X.Text = "5,5";
            Y.Text = "4,3";
            Z.Text = "2,8";
            Itog.Text = "Ст. гр. ИСП Палашичева 402";
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
