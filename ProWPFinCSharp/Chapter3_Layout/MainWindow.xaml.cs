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
            WrapPanelWindow wrapPanelWindow = new WrapPanelWindow();
            wrapPanelWindow.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            DockPanelWindow dockPanelWindow = new DockPanelWindow();
            dockPanelWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            NestingLayoutContainersWindow nestingLayoutContainersWindow = new NestingLayoutContainersWindow();
            nestingLayoutContainersWindow.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            GridWindow gridWindow = new GridWindow();
            gridWindow.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            GridWindow_2 gridWindow2 = new GridWindow_2();
            gridWindow2.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) {
            GridSplitterWindow gridSplitterWindow = new GridSplitterWindow();
            gridSplitterWindow.ShowDialog();
        }
    }
}
