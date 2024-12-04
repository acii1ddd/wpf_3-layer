using BLL.DTO;
using System.Windows;

namespace WPFUI.Views
{
    /// <summary>
    /// Логика взаимодействия для AddTrainWindow.xaml
    /// </summary>
    public partial class AddTrainWindow : Window
    {
        public TrainDTO newTrain { get; private set; }

        public AddTrainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверка и парсинг данных
            if (string.IsNullOrWhiteSpace(RouteTextBox.Text))
            {
                MessageBox.Show("Введите маршрут поезда.");
                return;
            }

            if (!int.TryParse(CapacityTextBox.Text, out int capacity))
            {
                MessageBox.Show("Введите количество мест поезда.");
                return;
            }

            if (!int.TryParse(WagonCountTextBox.Text, out int wagonCount))
            {
                MessageBox.Show("Введите количество вагонов поезда.");
                return;
            }

            newTrain = new TrainDTO
            {
                Route = RouteTextBox.Text,
                Capacity = capacity,
                WagonCount = wagonCount
            };

            DialogResult = true;
            this.Close();
        }
    }
}
