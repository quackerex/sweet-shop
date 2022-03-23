using System.Collections.Generic;
using System.Windows;

namespace SweetShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Product> sweets = new List<Product>();

            sweets.Add(new Product("😃", "Happy face", "A beautiful smile to brighten up your day.", 10));
            sweets.Add(new Product("😃", "Happy face", "A beautiful smile to brighten up your day.", 10));
            sweets.Add(new Product("😃", "Happy face", "A beautiful smile to brighten up your day.", 10));
            sweets.Add(new Product("😃", "Happy face", "A beautiful smile to brighten up your day.", 10));
            sweets.Add(new Product("😃", "Happy face", "A beautiful smile to brighten up your day.", 10));

            icSweets.ItemsSource = sweets;
        }
    }
}
