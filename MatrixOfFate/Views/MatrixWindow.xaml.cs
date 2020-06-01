using MatrixOfFate.Models;
using MatrixOfFate.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace MatrixOfFate.Views
{
    /// <summary>
    /// Interaction logic for MensMatrix.xaml
    /// </summary>
    public partial class MatrixWindow : Window
    {
        public Matrix Matrixs { get; set; }
        public MatrixWindow()
        {
            InitializeComponent();
            Matrixs = Calculate.GetMatrix();
            DataContext = Matrixs;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog
            {
                SelectedPagesEnabled = true,
                UserPageRangeEnabled = true
            };
            
            FlowDocument document = A4Page;

            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintDocument(((IDocumentPaginatorSource)document).DocumentPaginator, "Matrix Document");
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }
    }
}
