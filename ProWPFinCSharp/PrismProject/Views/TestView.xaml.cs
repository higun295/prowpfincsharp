using PrismProject.ViewModels;
using System.Windows;

namespace PrismProject.Views {
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : Window {
        public TestView() {
            InitializeComponent();
            DataContext = new TestViewModel();
        }
    }
}
