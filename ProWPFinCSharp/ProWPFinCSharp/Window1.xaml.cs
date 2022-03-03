using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.IO;

namespace ProWPFinCSharp {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        private Button button1;

        public Window1() {
            InitializeComponent();
        }

        public Window1(string xamlFile) {
            // Configure the form.
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML";

            // Get the XAML content from an external file.
            DependencyObject rootElement;
            using(FileStream fs = new FileStream(xamlFile, FileMode.Open)) {
                rootElement = (DependencyObject)XamlReader.Load(fs);
            }

            // Insert the markup into this window.
            this.Content = rootElement;


        }
    }
}
