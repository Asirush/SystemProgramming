using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace RandNumGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int start { get; set; } = 2;
        public int end { get; set; }

        private TextBox GetStartBox()
        {
            return StartBox;
        }

        private void Window_ContentRendered(object sender, EventArgs e, TextBox startBox, TextBox endBox)
        {
            this.start = startBox.Text;
            this.end = endBox.Text;
            Thread2 thread = new(start, end);             //thread1() is run. prints fibonacci numbers with 0.5 seconds between each time it outputs
            SimpleNumbersOutput.Text = thread.ToString();
        }

        private void GenerateFibonachiSeries_Click(object sender, RoutedEventArgs e)
        {
            Thread1 thread = new();             //thread1() is run. prints fibonacci numbers with 0.5 seconds between each time it outputs
            SimpleNumbersOutput.Text = thread.ToString();
        }
        public MainWindow()
        {
            DataContext = this;
        }
    }
}
