using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WpfApp2 {
    public class Window1 : Window {
        private Button button1;

        public Window1() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            // Configure the form.
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Code-Only Window";

            // Create a container to hold a button.
            DockPanel panel = new DockPanel();

            // Create the button.
            button1 = new Button();
            button1.Content = "Please click me.";
            button1.Margin = new Thickness(30);

            // Attach the event handler.
            button1.Click += Button1_Click;

            // Place the button in the panel.
            IAddChild container = panel;
            container.AddChild(button1);
        }

        private void Button1_Click(object sender, RoutedEventArgs e) {
            button1.Content = "Thank you.";
        }
    }
}
