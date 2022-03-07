using Chapter3_Layout.Chapter3_Example;
using System.Windows;

namespace Chapter3_Layout {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            WrapPanelWindow window = new WrapPanelWindow();
            window.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            DockPanelWindow window = new DockPanelWindow();
            window.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            NestingLayoutContainersWindow window = new NestingLayoutContainersWindow();
            window.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            GridWindow window = new GridWindow();
            window.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            GridWindow_2 window = new GridWindow_2();
            window.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) {
            GridSplitterWindow window = new GridSplitterWindow();
            window.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) {
            SharedSizeGroup window = new SharedSizeGroup();
            window.ShowDialog();
        }
    }
}
