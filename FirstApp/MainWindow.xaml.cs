using System;
using System.Collections.Generic;
using System.Data;
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

namespace FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement item in MyGrid.Children)
            {
                if (item is Button)
                {
                    ((Button)item).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = ((Button)e.OriginalSource).Content.ToString();

            if(str == "C")
            {
                text.Text = "";
            }
            else if(str == "=")
            {
                text.Text = new DataTable().Compute(text.Text, null).ToString();
            }
            else
            {
                text.Text += str;
            }
        }
    }
}
