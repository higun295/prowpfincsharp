using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter4_DependencyProperties {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Test() {
            ComboBox comboBox = new ComboBox();
            comboBox.SetValue(PasswordBox.PasswordCharProperty, "*");

            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CoerceMaximum);

            DependencyProperty.Register("Maximum", typeof(double), typeof(RangeBase), metadata);
        }

        private static object CoerceMaximum(DependencyObject d, object value) {
            RangeBase base1 = (RangeBase)d;
            if(((double) value) < base1.Minimum) {
                return base1.Minimum;
            }
            return value;
        }
    }
}
