using BLL.DTO;
using System.Windows;
using System.Windows.Controls;

namespace WPFUI.Views
{
    /// <summary>
    /// Логика взаимодействия для AddTicketWindow.xaml
    /// </summary>
    public partial class AddTicketWindow : Window
    {
        public TicketDTO newTicket { get; private set; }
        
        public AddTicketWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверка и парсинг данных
            if (string.IsNullOrWhiteSpace(SourceTextBox.Text) || string.IsNullOrWhiteSpace(DestinationTextBox.Text))
            {
                MessageBox.Show("Заполните места отправления и прибытия.");
                return;
            }

            if (!StartTimeDatePicker.SelectedDate.HasValue || !ArrivalTimeDatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Выберите даты отправления и прибытия.");
                return;
            }

            if (!int.TryParse(WagonNumberTextBox.Text, out int wagonNumber))
            {
                MessageBox.Show("Некорректный номер вагона.");
                return;
            }

            if (!int.TryParse(PlaceNumberTextBox.Text, out int placeNumber))
            {
                MessageBox.Show("Некорректный номер места.");
                return;
            }

            newTicket = new TicketDTO
            {
                Source = SourceTextBox.Text,
                Destination = DestinationTextBox.Text,
                StartTime = StartTimeDatePicker.SelectedDate.Value,
                ArrivalTime = ArrivalTimeDatePicker.SelectedDate.Value,
                WagonNumber = wagonNumber,
                PlaceNumber = placeNumber
            };

            DialogResult = true;
            this.Close();
        }
    }
}
