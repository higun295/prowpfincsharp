using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Chapter8_ElementBinding {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Binding binding = BindingOperations.GetBinding(valueTextBox, TextBlock.FontSizeProperty);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            if(e.NewValue >= e.OldValue) {
                valueTextBox.FontSize = valueTextBox.FontSize + e.NewValue;
            }
            else {
                valueTextBox.FontSize = valueTextBox.FontSize - e.NewValue;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            textSlider.Value += -1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            textSlider.Value = 10;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            textSlider.Value += 1;
        }
    }
}
