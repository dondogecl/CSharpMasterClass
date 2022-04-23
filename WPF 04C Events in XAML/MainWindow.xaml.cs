using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_04C_Events_in_XAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("clicked: Direct Event");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse has been released: Bubbling Event");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse has been released: Tunneling event");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Left Mouse button went down: Tunneling event");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right Mouse button went up: Tunneling event");
        }

        // Events:
        /* Routed Events : WPF mechanisms to handle events
         * - 1 - Direct Routed Events : handled by the item itself (eg: click)
         * - 2 -Bubbling Events : happens when the event is Not handled by the element (ie: textbox)
         * and the event "bubbles" its way up the UI containers holding it.
         * Grid > TextBox > TextElement
         * - 3 - Tunneling Event: the opposite of bubbling. THe event travels down the visual tree to the
         * element that is considered the source.
         */
    }
}
