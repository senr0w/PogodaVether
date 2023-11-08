using System.Windows;
using System.Windows.Input;


namespace PogodaVether
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
             if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void textSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

    }
}
