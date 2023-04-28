using System.Collections.ObjectModel;
using System.Windows;

namespace st1009155progp12023.st1009155progp12023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Module> modules = new ObservableCollection<Module>();

        public MainWindow()
        {
            this.InitializeComponent();
            this.moduleDataGrid.ItemsSource = modules;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var module = new Module()
            {
                Code = this.codeTextBox.Text,
                Name = this.nameTextBox.Text,
                Credits = int.Parse(this.creditsTextBox.Text),
                ClassHoursPerWeek = int.Parse(this.classHoursTextBox.Text)
            };
            modules.Add(module);
        }
    }
}