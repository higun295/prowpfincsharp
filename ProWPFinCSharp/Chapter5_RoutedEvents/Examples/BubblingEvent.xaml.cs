using System.Windows;
using System.Windows.Input;

namespace Chapter5_RoutedEvents.Examples {
    /// <summary>
    /// Interaction logic for BubblingEvent.xaml
    /// </summary>
    public partial class BubblingEvent : Window {
        protected int eventCounter = 0;

        public BubblingEvent() {
            InitializeComponent();
        }

        private void SomethingClicked(object sender, MouseButtonEventArgs e) {
            eventCounter++;
            string message = "#" + eventCounter.ToString() + ":\r\n" +
                " Sender : " + sender.ToString() + "\r\n" +
                " Source : " + e.Source + "\r\n" +
                " Original Source : " + e.OriginalSource;

            lstMessages.Items.Add(message);
            e.Handled = (bool)chkHandle.IsChecked;
        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e) {

        }

        private void cmdClear_Click(object sender, RoutedEventArgs e) {
            lstMessages.Items.Clear();
            eventCounter = 0;
        }
    }
}
