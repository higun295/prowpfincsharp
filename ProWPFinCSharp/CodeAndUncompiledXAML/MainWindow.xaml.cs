using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace CodeAndUncompiledXAML {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, System.Windows.Markup.IComponentConnector {
        internal System.Windows.Controls.TextBox txtQuestion;


        public MainWindow() {
            InitializeComponent();
        }

        public MainWindow(string xamlFile) {
            // Configure the form.
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML";

            //Get the XAML content from an external file.
            DependencyObject rootElement;
            using(FileStream fs = new FileStream(xamlFile, FileMode.Open)) {
                rootElement = (DependencyObject)XamlReader.Load(fs);
            }

            // Insert the markup into this window.
            this.Content = rootElement;

            // Find the control with the appropriate name.
            button1 = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "button1");

            // Wire up the event handler.
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, RoutedEventArgs e) {
            button1.Content = "Thank you.";
        }
    }
}
