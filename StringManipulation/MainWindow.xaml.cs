using System.Windows;

namespace StringManipulation
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public static string InputVal { get; set; }

        public void Go_OnClick(object sender, RoutedEventArgs e)
        {
            StringManip.NumberClassify();
            InputText.Text = InputVal;
        }
    }
}