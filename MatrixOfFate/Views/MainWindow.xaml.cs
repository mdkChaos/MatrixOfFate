using System.Windows;
using MatrixOfFate.ViewModels;
using MatrixOfFate.Views;

namespace MatrixOfFate
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
            Calculate.SetDateOfBirth(Birthday.Text);
            MatrixWindow matrixWindow = new MatrixWindow();
            matrixWindow.DateOfBirth.Content = Calculate.DateOfBirth.Birthday;
            matrixWindow.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }
    }
}
